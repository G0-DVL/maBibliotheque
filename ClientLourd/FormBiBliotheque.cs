using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace ClientLourd
{
    public partial class FormBiBliotheque : Form
    {   //  constantes  :
        //  Nombre maximum de tentatives de connexion possibles
        const int NOMBRE_MAXIMUM_DE_TENTATIVES_DE_CONNEXION = 3;

        //  attributs privés    :
        //  Contient le nombre de tentatives de connexion restantes :
        //  est initialisé au lancement du programme
        //  est réinitialisé à chaque connexion réussie
        private int iTentativeDeValidation = NOMBRE_MAXIMUM_DE_TENTATIVES_DE_CONNEXION;

        //  Contient les onglets que l'on pourra afficher/cacher :
        //  Il est nécessaire d'utiliser des variables pour stocker nos tabPages car on ne peut pas les cacher
        //  en changeant la propriété Visible : Il faut les enlever de la collection TabPages du TabControl
        private TabPage oTabPageBibliothecaire;
        private TabPage oTabPageAdherent;
        private TabPage oTabPageLivre;
        private TabPage oTabPageAuteur;
        private TabPage oTabPageEmprunt;


        //  Fonction lancée à la création de la fenêtre (constructeur)
        public FormBiBliotheque()
        {
            InitializeComponent();

            //  Nous nous connectons systématiquement à la base au lancement du logiciel
            using (maBibliothequeEntities monContext = new maBibliothequeEntities())
            {
                //  Nous comptons le nombre de bibliothécaires dans la base
                int iCount = monContext.bibliothecaires.Count<bibliothecaire>();
                //  Si nous en avons aucun...
                if (iCount == 0)
                {
                    //  Nous en créeons un nouveau
                    var monNouveauBibliothecaire = new bibliothecaire
                    {
                        bibliothecaire_login = "admin",
                        bibliothecaire_password = "admin",
                        bibliothecaire_nom = "par défaut",
                        bibliothecaire_prenom = "Administrateur"
                    };
                    //  Nous l'ajoutons à la base
                    monContext.bibliothecaires.Add(monNouveauBibliothecaire);
                }
                // et nous le sauvegardons dans la base
                monContext.SaveChanges();
            }

            //  Nous cachons les tab dont l'utilisateur n'a pas besoin tant qu'il n'est pas identifié !
            oTabPageBibliothecaire = tabPageBibliothecaire;
            oTabPageAdherent       = tabPageAdherent;
            oTabPageLivre          = tabPageLivre;
            oTabPageAuteur         = tabPageAuteur;
            oTabPageEmprunt        = tabPageEmprunt;

            tabControlBibliotheque.TabPages.Remove(tabPageBibliothecaire);
            tabControlBibliotheque.TabPages.Remove(tabPageAdherent);
            tabControlBibliotheque.TabPages.Remove(tabPageLivre);
            tabControlBibliotheque.TabPages.Remove(tabPageAuteur);
            tabControlBibliotheque.TabPages.Remove(tabPageEmprunt);

            //  Pour notre tabControl, nous voulons qu'il soit redimensionné à la taille de notre fenêtre
            //  Pour cela, nous utilisons des ancres (Anchor) en haut, à gauche
            tabControlBibliotheque.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right);
        }

        //  Fonction lancée au clic sur le label "Login :" dans le tab d'identification
        private void LabelLogin_click(object sender, EventArgs e)
        {
            TextBoxLogin.SelectAll();
        }

        //  Fonction lancée au clic sur le label "Pass :" dans le tab d'identification
        private void LabelPass_click(object sender, EventArgs e)
        {
            TextBoxPass.SelectAll();
        }

        //  Fonction lancée au clic sur le bouton "Valider" dans le tab d'identification
        private void ButtonIdentificationValidate_Click(object sender, EventArgs e)
        {
            //  Nous nous connectons à la base
            using (maBibliothequeEntities cContext = new maBibliothequeEntities())
            {   //  Nous requêtons via l'entity bibliothecaires la table bibliothecaire (logique...), un bibliothécaire
                var oQuery = from bibliothecaire in cContext.bibliothecaires
                             where   //  dont le login est égal à celui saisi par l'utilisateur dans le TextBoxLogin
                                bibliothecaire.bibliothecaire_login == TextBoxLogin.Text
                                &&   //  dont le password est égal à celui saisi par l'utilisateur dans le TextBoxPass
                                bibliothecaire.bibliothecaire_password == TextBoxPass.Text
                             select bibliothecaire; //  On sélectionne le jeu du résultat

                //  Nous récupérons le (seul) premier bibliothécaire de la requête
                var oBibliothecaire = oQuery.FirstOrDefault();

                //  Si nous ne trouvons pas de bibliothécaire
                if (oBibliothecaire == null)
                {   //  On refuse l'accès et on diminue le nombre de tentatives restantes
                    --iTentativeDeValidation;
                    MessageBox.Show("ACCES REFUSE" + "\n"
                    + "Il vous reste " + iTentativeDeValidation
                    + " tentative" + (iTentativeDeValidation > 1 ? "s" : "") + "."
                    + (iTentativeDeValidation == 0 ? "\nAurevoir !" : ""));

                    if (0 == iTentativeDeValidation)
                    {   //  Si le nombre de tentatives est dépassé, on ferme la fenêtre (dans ta gueule)
                        this.Close();
                    }
                }
                else
                {   //  Si le bibliothécaire éxiste dans la base, on lui souhaite le bonjour :)
                    tabControlBibliotheque.TabPages[0].Text = oBibliothecaire.bibliothecaire_prenom + " " + oBibliothecaire.bibliothecaire_nom;
                    tabControlBibliotheque.TabPages.Add(oTabPageBibliothecaire);
                    tabControlBibliotheque.TabPages.Add(oTabPageAdherent);
                    tabControlBibliotheque.TabPages.Add(oTabPageLivre);
                    tabControlBibliotheque.TabPages.Add(oTabPageAuteur);
                    tabControlBibliotheque.TabPages.Add(oTabPageEmprunt);

                    TextBoxLogin.Enabled = false;
                    TextBoxPass.Enabled = false;
                    ButtonIdentificationValidate.Enabled = false;
                }

            }
        }

        //  Fonction appellée à chaque touche du clavier appuyée sur le TextBoxLogin
        private void TextBoxLogin_keyPress(object sender, KeyPressEventArgs e)
        {   //  Si l'utilisateur appuie sur la touche ENTREE
            if ((char)Keys.Return == e.KeyChar)
            {   //  Nous appelons la fonction de validation de l'identification
                //  comme s'il avait appuyé sur le bouton "Valider"
                ButtonIdentificationValidate_Click(sender, e);
            }
        }

        //  Fonction appellée à chaque touche du clavier appuyée sur le TextBoxPass
        private void TextBoxPass_keyPress(object sender, KeyPressEventArgs e)
        {   //  Si l'utilisateur appuie sur la touche ENTREE
            if ((char)Keys.Return == e.KeyChar)
            {   //  Nous appelons la fonction de validation de l'identification
                //  comme s'il avait appuyé sur le bouton "Valider"
                ButtonIdentificationValidate_Click(sender, e);
            }
        }

        //  Fonction appellée à chaque fois que l'on "rentre" dans une TextBox du tab d'identification
        private void TextBoxIdentification_Enter(object sender, EventArgs e)
        {   //  Nous sélectionnons tout le texte du TextBox
            ((TextBoxBase)sender).SelectAll();
        }

        #region tabPageBibliothecaire
        //  Fonction appellée au clic sur le bouton Création dans le tabPage Bibliothécaire
        private void buttonBibliothecaireCreation_Click(object sender, EventArgs e)
        {
            if ("" == textBoxBibliothecaireLogin.Text
              || "" == textBoxBibliothecairePassword.Text
              || "" == textBoxBibliothecaireNom.Text
              || "" == textBoxBibliothecairePrenom.Text
                             )
            {
                MessageBox.Show("Tous les champs saisis doivent être obligatoires");
                return;
            }
            using (maBibliothequeEntities monContext = new maBibliothequeEntities())
            {
                try
                { // Nous en créeons un nouveau
                    var monNouveauBibliothecaire = new bibliothecaire
                    {
                        bibliothecaire_login = textBoxBibliothecaireLogin.Text,
                        bibliothecaire_password = textBoxBibliothecairePassword.Text,
                        bibliothecaire_nom = textBoxBibliothecaireNom.Text,
                        bibliothecaire_prenom = textBoxBibliothecairePrenom.Text
                    };
                    //  Nous l'ajoutons à la base
                    monContext.bibliothecaires.Add(monNouveauBibliothecaire);
                    monContext.SaveChanges();

                    //  Nous rajoutons le nouveau bibliothécaire à la DataGridView
                    dataGridViewBibliothecaire.Rows.Add(
                        monNouveauBibliothecaire.bibliothecaire_ID,
                        monNouveauBibliothecaire.bibliothecaire_login,
                        //  monNouveauBibliothecaire.bibliothecaire_password,   //  Nous n'affichons pas la colonne Password !
                        monNouveauBibliothecaire.bibliothecaire_nom,
                        monNouveauBibliothecaire.bibliothecaire_prenom
                    );
                }
                catch (Exception eException)
                {
                    MessageBox.Show("Erreur dans la creation du bibliothecaire " + eException.Message);
                }          
            }

        }

        private void buttonBibliothecaireModification_Click(object sender, EventArgs e)
        {
            string sMessageDErreur = "";
            try
            {
                if ("" == textBoxBibliothecaireId.Text)
                {   //  Il nous faut obligatoirement l'ID pour continuer
                    sMessageDErreur += "\n" + "- Vous devez saisir l'ID du bibliothecaire à modifier";
                }


                if ("" != sMessageDErreur)
                {   //  Pour le moindre motif d'erreur, nous levons une exception et on interrompt l'éxécution du code
                    throw new Exception(sMessageDErreur);
                }

                using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                {   //  On va rechercher en base si l'ID de notre bibliothecaire éxiste toujours
                    var oBibliothecaires = monContext.bibliothecaires.Find(int.Parse(textBoxBibliothecaireId.Text));
                    if (oBibliothecaires == null)
                    {   //  Si on le trouve pas, l'objet est null et on ne modifie rien !
                        throw new Exception("Le bibliothecaire avec un ID " + textBoxBibliothecaireId.Text + " n'éxiste pas !");
                    }

                    //  Pour chacun des champs, on vérifie s'il est vide. S'il ne l'est pas, on me modifie pas sa valeur !
                    if ("" != textBoxBibliothecaireNom.Text)
                    {
                        oBibliothecaires.bibliothecaire_nom = textBoxBibliothecaireNom.Text;
                    }
                    if ("" != textBoxBibliothecairePrenom.Text)
                    {
                        oBibliothecaires.bibliothecaire_prenom = textBoxBibliothecairePrenom.Text;
                    }
                    if ("" != textBoxBibliothecaireLogin.Text)
                    {
                        oBibliothecaires.bibliothecaire_login = textBoxBibliothecaireLogin.Text;
                    }
                    if ("" != textBoxBibliothecairePassword.Text)
                    {
                        oBibliothecaires.bibliothecaire_password = textBoxBibliothecairePassword.Text;
                    }
                    //  Une fois qu'on a mis à jour toutes les propriétés de l'objet, on n'a plus qu'à sauvegarder le contexte
                    monContext.SaveChanges();

                    //  Nous recherchons dans la DataGridView le bibliothécaire modifié et nous mettons à jour les cellules
                    foreach (DataGridViewRow oDataGridViewRow in dataGridViewBibliothecaire.Rows)
                    {
                        if (textBoxBibliothecaireId.Text == oDataGridViewRow.Cells[0].Value.ToString())
                        {
                            oDataGridViewRow.SetValues(
                                oBibliothecaires.bibliothecaire_ID.ToString(),
                                oBibliothecaires.bibliothecaire_login,
                                oBibliothecaires.bibliothecaire_nom,
                                oBibliothecaires.bibliothecaire_prenom
                            );
                            break;
                        }
                    }
                }
            }
            catch (Exception eException)
            {
                MessageBox.Show("Impossible de modifier le bibliothecaire !\n" + eException.Message);
            }
        }

        private void buttonBibliothecaireSuppression_Click(object sender, EventArgs e)
        {
            string sMessageDErreur = "";
            try
            {
                if ("" == textBoxBibliothecaireId.Text)
                {   //  Il nous faut obligatoirement l'ID pour continuer
                    sMessageDErreur += "\n" + "- Vous devez saisir l'ID du bibliothequaire à supprimer";
                }

                if ("" != sMessageDErreur)
                {   //  Pour le moindre motif d'erreur, nous levons une exception et on interrompt l'éxécution du code
                    throw new Exception(sMessageDErreur);
                }

                using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                {   //  On va rechercher en base si l'ID de notre bibliothecaire éxiste toujours
                    var oBibliothecaires = monContext.bibliothecaires.Find(int.Parse(textBoxBibliothecaireId.Text));
                    if (oBibliothecaires == null)
                    {   //  Si on le trouve pas, l'objet est null et on a rien à supprimer !
                        throw new Exception("Le bibliothecaire avec un ID " + textBoxBibliothecaireId.Text + " n'éxiste pas !");
                    }

                    monContext.bibliothecaires.Remove(oBibliothecaires); //  On supprime l'adhérent
                    monContext.SaveChanges();   //  On sauvegarde les données

                    //  Nous recherchons dans la DataGridView le bibliothécaire supprimé et nous l'enlevons du DataGridView
                    foreach (DataGridViewRow oDataGridViewRow in dataGridViewBibliothecaire.Rows)
                    {
                        if (textBoxBibliothecaireId.Text == oDataGridViewRow.Cells[0].Value.ToString())
                        {
                            //  oDataGridViewRow.Cells[0] = textBoxAdherentId.Text;
                            dataGridViewBibliothecaire.Rows.Remove(oDataGridViewRow);
                            break;
                        }
                    }
                }
            }
            catch (Exception eException)
            {
                MessageBox.Show("Impossible de supprimer le bibliothecaire !\n" + eException.Message);
            }
        }
        
        //  Se produit lors du clic sur le bouton "Rechercher"
        private void buttonBibliothecaireRechercher_Click(object sender, EventArgs e)
        {
            buttonBibliothecaireAfficherTout.Visible = true;
            rechercherBibliothecaire(
                textBoxBibliothecaireId.Text,
                textBoxBibliothecaireLogin.Text,
                textBoxBibliothecaireNom.Text,
                textBoxBibliothecairePrenom.Text
            );
        }

        //  Se produit lors du clic sur le bouton "Afficher tout"
        private void buttonBibliothecaireAfficherTout_Click(object sender, EventArgs e)
        {
            buttonBibliothecaireAfficherTout.Visible = false;
            rechercherBibliothecaire();
        }

        //  Fonction qui gère l'affichage des bibliothécaires en fonction des paramètres de recherche
        private void rechercherBibliothecaire(string sId = "", string sLogin = "", string sNom = "", string sPrenom = "")
        {
            using (maBibliothequeEntities monContext = new maBibliothequeEntities())
            {
                var oBibliothecaireQuery = from tableBibliothecaire in monContext.bibliothecaires
                                           select tableBibliothecaire;

                if ("" != sId)
                {
                    int iBibliothecaireId = int.Parse(sId);
                    oBibliothecaireQuery = oBibliothecaireQuery.Where(
                        tableBibliothecaire => tableBibliothecaire.bibliothecaire_ID == iBibliothecaireId
                    );
                }
                if ("" != sLogin)
                {
                    oBibliothecaireQuery = oBibliothecaireQuery.Where(
                        tableBibliothecaire => tableBibliothecaire.bibliothecaire_login.Contains(sLogin)
                    );
                }
                if ("" != sNom)
                {
                    oBibliothecaireQuery = oBibliothecaireQuery.Where(
                        tableBibliothecaire => tableBibliothecaire.bibliothecaire_nom.Contains(sNom)
                    );
                }
                if ("" != sPrenom)
                {
                    oBibliothecaireQuery = oBibliothecaireQuery.Where(
                        tableBibliothecaire => tableBibliothecaire.bibliothecaire_prenom.Contains(sPrenom)
                    );
                }

                var oListResultats = oBibliothecaireQuery.ToList();
                dataGridViewBibliothecaire.Rows.Clear();
                foreach (bibliothecaire oBibliothecaire in oListResultats)
                {
                    dataGridViewBibliothecaire.Rows.Add(
                        oBibliothecaire.bibliothecaire_ID,
                        oBibliothecaire.bibliothecaire_login,
                        oBibliothecaire.bibliothecaire_nom,
                        oBibliothecaire.bibliothecaire_prenom
                    );
                }
            }
        }

        private void tabPageBibliothecaire_Enter(object sender, EventArgs e)
        {
            if (0 == dataGridViewBibliothecaire.Rows.Count)
            {
                buttonBibliothecaireAfficherTout_Click(sender, e);
            }
        }

        private void dataGridViewBibliothecaire_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            dataGridViewBibliothecaire_StateChanged();
        }

        private void dataGridViewBibliothecaire_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            dataGridViewBibliothecaire_StateChanged();
        }

        private void dataGridViewBibliothecaire_StateChanged()
        {
            DataGridViewSelectedCellCollection oCellCollection = dataGridViewBibliothecaire.SelectedCells;
            if (0 == oCellCollection.Count)
            {
                return;
            }
            DataGridViewCellCollection oRowCells = oCellCollection[0].OwningRow.Cells;

            textBoxBibliothecaireId.Text = oRowCells[0].Value.ToString();
            textBoxBibliothecaireLogin.Text = oRowCells[1].Value.ToString();
            textBoxBibliothecairePassword.Text = "";    //  On ne récupère pas le mot de passe ! On le met donc à "vide"
            textBoxBibliothecaireNom.Text = oRowCells[2].Value.ToString();
            textBoxBibliothecairePrenom.Text = oRowCells[3].Value.ToString();
        }
        #endregion tabPageBibliothecaire

        #region tabPageAdherent
        //****************************************************************************
        //  Fonction appellée au clic sur le bouton Création dans le tabPage Adhérent
        //**************************************************************************** 
        private void buttonAdherentCreation_Click(object sender, EventArgs e)
        {   //  On initialise une variable message d'erreur. Si le message d'erreur reste vide, alors on n'a pas d'erreur
            string sMessageDErreur = "";
            try
            {
                if ("" == textBoxAdherentNom.Text
                 || "" == textBoxAdherentPrenom.Text
                 || "" == textBoxAdherentAdresse.Text
                 || "" == textBoxAdherentCodePostal.Text
                 || "" == textBoxAdherentTelephone.Text
                 || "" == textBoxAdherentEmail.Text
                    )
                {   //  Si le moindre de nos controle est vide (hormis ID)
                    sMessageDErreur += "\n" + "- Tous les champs saisis doivent être obligatoires";
                }
                else if (dateTimePickerAdherentDateInscr.Value > DateTime.Now)
                {   //  Si la date d'inscription est supérieure à la date du jour
                    sMessageDErreur += "\n" + "- Vous ne pouvez pas inscrire un adhérent à l'avance !";
                }
                else if (dateTimePickerAdherentDateNaiss.Value > DateTime.Now)
                {   //  Si la date de naissance est supérieure à la date du jour
                    sMessageDErreur += "\n" + "- Vous ne pouvez pas faire naître un adhérent à l'avance !";
                }

                if ("" != sMessageDErreur)
                {   //  Pour le moindre motif d'erreur, nous levons une exception et on interrompt l'éxécution du code
                    throw new Exception(sMessageDErreur);
                }

                using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                {   //  Nous créeons un nouvel adhérent, et utilisons nos TextBox pour alimenter chacune des valeurs
                    var oAdherent = new adherent
                    {
                        adherent_nom = textBoxAdherentNom.Text
                        , adherent_prenom = textBoxAdherentPrenom.Text
                        , adherent_date_naissance = dateTimePickerAdherentDateNaiss.Value
                        , adherent_adresse = textBoxAdherentAdresse.Text
                        , adherent_code_postal = textBoxAdherentCodePostal.Text
                        , adherent_telephone = textBoxAdherentTelephone.Text
                        , adherent_email = textBoxAdherentEmail.Text
                        , adherent_date_inscription = dateTimePickerAdherentDateInscr.Value
                    };
                    monContext.adherents.Add(oAdherent);    //  On ajoute le nouvel adhérent à notre table dans le contexte
                    monContext.SaveChanges();   //  puis nous sauvegardons le tout dans la base

                    //  Nous rajoutons le nouvel adhérent à la DataGridView
                    dataGridViewAdherent.Rows.Add(
                        oAdherent.adherent_ID,
                        oAdherent.adherent_nom,
                        oAdherent.adherent_prenom,
                        oAdherent.adherent_date_naissance,
                        oAdherent.adherent_adresse,
                        oAdherent.adherent_code_postal,
                        oAdherent.adherent_telephone,
                        oAdherent.adherent_email,
                        oAdherent.adherent_date_inscription
                    );
                }
            }
            catch (Exception eException)
            {
                MessageBox.Show("Impossible de créer l'adhérent !\n" + eException.Message);
            }
        }

        //********************************************************************************
        //  Fonction appellée au clic sur le bouton Modification dans le tabPage Adhérent
        //********************************************************************************
        private void buttonAdherentModif_Click(object sender, EventArgs e)
        {   //  On initialise une variable message d'erreur. Si le message d'erreur reste vide, alors on n'a pas d'erreur
            string sMessageDErreur = "";
            try
            {
                if ("" == textBoxAdherentId.Text)
                {   //  Il nous faut obligatoirement l'ID pour continuer
                    sMessageDErreur += "\n" + "- Vous devez saisir l'ID de l'adhérent à modifier";
                }
                if (dateTimePickerAdherentDateInscr.Value > DateTime.Now)
                {   //  On empêche des valeurs impossibles d'être saisies
                    sMessageDErreur += "\n" + "- Vous ne pouvez pas modifier la date d'inscription d'un adhérent au delà de la date du jour !";
                }
                if (dateTimePickerAdherentDateNaiss.Value > DateTime.Now)
                {   //  On empêche des valeurs impossibles d'être saisies
                    sMessageDErreur += "\n" + "- Vous ne pouvez pas faire naître un adhérent à l'avance !";
                }
                if (dateTimePickerAdherentDateNaiss.Value > dateTimePickerAdherentDateInscr.Value)
                {   //  On empêche des valeurs impossibles d'être saisies
                    sMessageDErreur += "\n" + "- Vous ne pouvez pas inscrire un adhérent qui n'est pas né !";
                }

                if ("" != sMessageDErreur)
                {   //  Pour le moindre motif d'erreur, nous levons une exception et on interrompt l'éxécution du code
                    throw new Exception(sMessageDErreur);
                }

                using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                {   //  On va rechercher en base si l'ID de notre adhérent éxiste toujours
                    var oAdherent = monContext.adherents.Find(int.Parse(textBoxAdherentId.Text));
                    if (oAdherent == null)
                    {   //  Si on le trouve pas, l'objet est null et on ne modifie rien !
                        throw new Exception("L'adhérent avec un ID " + textBoxAdherentId.Text + " n'éxiste pas !");
                    }

                    //  Pour chacun des champs, on vérifie s'il est vide. S'il ne l'est pas, on me modifie pas sa valeur !
                    if ("" != textBoxAdherentNom.Text)
                    {
                        oAdherent.adherent_nom = textBoxAdherentNom.Text;
                    }
                    if ("" != textBoxAdherentPrenom.Text)
                    {
                        oAdherent.adherent_prenom = textBoxAdherentPrenom.Text;
                    }
                    if (oAdherent.adherent_date_naissance != dateTimePickerAdherentDateNaiss.Value)
                    {
                        oAdherent.adherent_date_naissance = dateTimePickerAdherentDateNaiss.Value;
                    }
                    if ("" != textBoxAdherentAdresse.Text)
                    {
                        oAdherent.adherent_adresse = textBoxAdherentAdresse.Text;
                    }
                    if ("" != textBoxAdherentCodePostal.Text)
                    {
                        oAdherent.adherent_code_postal = textBoxAdherentCodePostal.Text;
                    }
                    if ("" != textBoxAdherentTelephone.Text)
                    {
                        oAdherent.adherent_telephone = textBoxAdherentTelephone.Text;
                    }
                    if ("" != textBoxAdherentEmail.Text)
                    {
                        oAdherent.adherent_email = textBoxAdherentEmail.Text;
                    }
                    if (oAdherent.adherent_date_inscription != dateTimePickerAdherentDateInscr.Value)
                    {
                        oAdherent.adherent_date_inscription = dateTimePickerAdherentDateInscr.Value;
                    }

                    //  Une fois qu'on a mis à jour toutes les propriétés de l'objet, on n'a plus qu'à sauvegarder le contexte
                    monContext.SaveChanges();

                    //  Nous recherchons dans la DataGridView l'adhérent modifié et nous mettons à jour les cellules
                    foreach (DataGridViewRow oDataGridViewRow in dataGridViewAdherent.Rows)
                    {
                        if(textBoxAdherentId.Text == oDataGridViewRow.Cells[0].Value.ToString())
                        {
                            //  oDataGridViewRow.Cells[0] = textBoxAdherentId.Text;
                            oDataGridViewRow.SetValues(
                                oAdherent.adherent_ID.ToString(),
                                oAdherent.adherent_nom,
                                oAdherent.adherent_prenom,
                                oAdherent.adherent_date_naissance,
                                oAdherent.adherent_adresse,
                                oAdherent.adherent_code_postal,
                                oAdherent.adherent_telephone,
                                oAdherent.adherent_email,
                                oAdherent.adherent_date_inscription
                            );
                            break;
                        }
                    }
                }
            }
            catch(Exception eException)
            {
                MessageBox.Show("Impossible de modifier l'adhérent !\n" + eException.Message);
            }
        }
        //********************************************************************************
        //  Fonction appellée au clic sur le bouton Suppression dans le tabPage Adhérent
        //********************************************************************************
        private void buttonAdherentSupp_Click(object sender, EventArgs e)
        {   //  On initialise une variable message d'erreur. Si le message d'erreur reste vide, alors on n'a pas d'erreur
            string sMessageDErreur = "";
            try
            {
                if ("" == textBoxAdherentId.Text)
                {   //  Il nous faut obligatoirement l'ID pour continuer
                    sMessageDErreur += "\n" + "- Vous devez saisir l'ID de l'adhérent à supprimer";
                }

                if ("" != sMessageDErreur)
                {   //  Pour le moindre motif d'erreur, nous levons une exception et on interrompt l'éxécution du code
                    throw new Exception(sMessageDErreur);
                }

                using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                {   //  On va rechercher en base si l'ID de notre adhérent éxiste toujours
                    var oAdherent = monContext.adherents.Find(int.Parse(textBoxAdherentId.Text));
                    if (oAdherent == null)
                    {   //  Si on le trouve pas, l'objet est null et on a rien à supprimer !
                        throw new Exception("L'adhérent avec un ID " + textBoxAdherentId.Text + " n'éxiste pas !");
                    }
                    // vérifier que l'adherent n'a pas d'emprunts en cours
                    var iAdherentId = int.Parse(textBoxAdherentId.Text);

                    var oEmprunter = monContext.emprunters.Where(t => t.adherent_ID==iAdherentId).FirstOrDefault();
                    if (oEmprunter != null)
                    {
                        //si on trouve des emprunts pour l'usager ne pas le supprimer
                        throw new Exception("L'adherent a des emprunts en cours.On ne peut le supprimer !");

                    }
                     
                    monContext.adherents.Remove(oAdherent); //  On supprime l'adhérent
                    monContext.SaveChanges();   //  On sauvegarde les données

                    //  Nous recherchons dans la DataGridView l'adhérent supprimé et nous l'enlevons du DataGridView
                    foreach (DataGridViewRow oDataGridViewRow in dataGridViewAdherent.Rows)
                    {
                        if (textBoxAdherentId.Text == oDataGridViewRow.Cells[0].Value.ToString())
                        {
                            //  oDataGridViewRow.Cells[0] = textBoxAdherentId.Text;
                            dataGridViewAdherent.Rows.Remove(oDataGridViewRow);
                            break;
                        }
                    }
                }
            }
            catch (Exception eException)
            {
                MessageBox.Show("Impossible de supprimer l'adhérent !\n" + eException.Message);
            }
        }

        private void buttonAdherentRechercher_Click(object sender, EventArgs e)
        {
            buttonAdherentAfficherTout.Visible = true;
            rechercherAdherent(
                textBoxAdherentId.Text,
                textBoxAdherentNom.Text,
                textBoxAdherentPrenom.Text,
                dateTimePickerAdherentDateNaiss.Value,
                textBoxAdherentAdresse.Text,
                textBoxAdherentCodePostal.Text,
                textBoxAdherentTelephone.Text,
                textBoxAdherentEmail.Text,
                dateTimePickerAdherentDateInscr.Value
            );
        }

        private void buttonAdherentAfficherTout_Click(object sender, EventArgs e)
        {
            buttonAdherentAfficherTout.Visible = false;
            rechercherAdherent();
        }

        private void rechercherAdherent(string sId="", string sNom="", string sPrenom="", DateTime? dDateNaiss=null, string sAdresse="",string sCodePostal = "", string sTelephone = "", string sEmail = "", DateTime? dDateInscr=null)
        {
            using (maBibliothequeEntities monContext = new maBibliothequeEntities())
            {
                var oAdherentQuery = from tableAdherent in monContext.adherents
                                     select tableAdherent;
                if ("" != sId)
                {
                    int iAdherentId = int.Parse(sId);
                    oAdherentQuery = oAdherentQuery.Where(
                        tableAdherent => tableAdherent.adherent_ID == iAdherentId
                    );
                }

                if ("" != sNom)
                {
                    oAdherentQuery = oAdherentQuery.Where(
                        tableAdherent => tableAdherent.adherent_nom.Contains(sNom)
                    );
                }

                if ("" != sPrenom)
                {
                    oAdherentQuery = oAdherentQuery.Where(
                        tableAdherent => tableAdherent.adherent_prenom.Contains(sPrenom)
                    );
                }

                if (null != dDateNaiss)
                {
                    oAdherentQuery = oAdherentQuery.Where(
                        tableAdherent => tableAdherent.adherent_date_naissance == dDateNaiss
                    );
                }

                if ("" != sAdresse)
                {
                    oAdherentQuery = oAdherentQuery.Where(
                        tableAdherent => tableAdherent.adherent_adresse.Contains(sAdresse)
                    );
                }

                if ("" != sCodePostal)
                {
                    oAdherentQuery = oAdherentQuery.Where(
                        tableAdherent => tableAdherent.adherent_code_postal.Contains(sCodePostal)
                    );
                }

                if ("" != sTelephone)
                {
                    oAdherentQuery = oAdherentQuery.Where(
                        tableAdherent => tableAdherent.adherent_telephone.Contains(sTelephone)
                    );
                }

                if ("" != sEmail)
                {
                    oAdherentQuery = oAdherentQuery.Where(
                        tableAdherent => tableAdherent.adherent_email.Contains(sEmail)
                    );
                }

                if (null != dDateInscr)
                {
                    oAdherentQuery = oAdherentQuery.Where(
                        tableAdherent => tableAdherent.adherent_date_inscription == dDateInscr
                    );
                }


                var oListResultats = oAdherentQuery.ToList();
                dataGridViewAdherent.Rows.Clear();
                foreach (adherent oAdherent in oListResultats)
                {
                    dataGridViewAdherent.Rows.Add(
                        oAdherent.adherent_ID,
                        oAdherent.adherent_nom,
                        oAdherent.adherent_prenom,
                        oAdherent.adherent_date_naissance,
                        oAdherent.adherent_adresse,
                        oAdherent.adherent_code_postal,
                        oAdherent.adherent_telephone,
                        oAdherent.adherent_email,
                        oAdherent.adherent_date_inscription
                    );
                }
            }
        }

        private void tabPageAdherent_Enter(object sender, EventArgs e)
        {
            if ( 0 == dataGridViewAdherent.Rows.Count )
            {
                buttonAdherentAfficherTout_Click(sender, e);
            }
        }

        private void dataGridViewAdherent_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            dataGridViewAdherent_StateChanged();
        }

        private void dataGridViewAdherent_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            dataGridViewAdherent_StateChanged();
        }

        private void dataGridViewAdherent_StateChanged()
        {
            DataGridViewSelectedCellCollection oCellCollection = dataGridViewAdherent.SelectedCells;
            if (0 == oCellCollection.Count)
            {
                return;
            }
            DataGridViewCellCollection oRowCells = oCellCollection[0].OwningRow.Cells;

            textBoxAdherentId.Text = oRowCells[0].Value.ToString();
            textBoxAdherentNom.Text = oRowCells[1].Value.ToString();
            textBoxAdherentPrenom.Text = oRowCells[2].Value.ToString();
            dateTimePickerAdherentDateNaiss.Value = (DateTime)oRowCells[3].Value;
            textBoxAdherentAdresse.Text = oRowCells[4].Value.ToString();
            textBoxAdherentCodePostal.Text = oRowCells[5].Value.ToString();
            textBoxAdherentTelephone.Text = oRowCells[6].Value.ToString();
            textBoxAdherentEmail.Text = oRowCells[7].Value.ToString();
            dateTimePickerAdherentDateInscr.Value = (DateTime)oRowCells[8].Value;
        }
        #endregion tabPageAdherent

        #region tabPageLivre
        //*******************************************************************
        //  Se produit au clic du bouton création dans l'onglet tabPageLivre
        //*******************************************************************
        private void buttonLivreCreation_Click(object sender, EventArgs e)
        {   //  On initialise une variable message d'erreur. Si le message d'erreur reste vide, alors on n'a pas d'erreur



            string sMessageDErreur = "";
            try
            {
                if ("" == textBoxLivreTitre.Text
                 || "" == comboBoxLivreAuteurNom.Text
                 || "" == comboBoxLivreGenre.Text
                 || "" == comboBoxLivreEmplacement.Text
                    )
                {   //  Si le moindre de nos controle est vide (hormis ID)
                    sMessageDErreur += "\n" + "- Tous les champs saisis doivent être obligatoires";
                }

                if ("" != sMessageDErreur)
                {   //  Pour le moindre motif d'erreur, nous levons une exception et on interrompt l'éxécution du code
                    throw new Exception(sMessageDErreur);
                }

                using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                {   //  Nous créeons un nouveau livre à partir des données saisies, mais nous devons pour cela nous assurer
                    //  que les auteurs, genres et emplacements éxistent
                    var oAuteurQuery = from tableAuteur in monContext.auteurs
                                       where tableAuteur.auteur_nom == comboBoxLivreAuteurNom.Text
                                       && tableAuteur.auteur_prenom == comboBoxLivreAuteurPrenom.Text
                                       select tableAuteur;
                    auteur oAuteurTrouve = oAuteurQuery.FirstOrDefault();
                    if (oAuteurTrouve == null)
                    {
                        oAuteurTrouve = new auteur
                        {
                            auteur_nom = comboBoxLivreAuteurNom.Text,
                            auteur_prenom = comboBoxLivreAuteurPrenom.Text
                        };
                        monContext.auteurs.Add(oAuteurTrouve);
                        monContext.SaveChanges();

                        dataGridViewAuteur.Rows.Add(
                            oAuteurTrouve.auteur_ID,
                            oAuteurTrouve.auteur_nom,
                            oAuteurTrouve.auteur_prenom
                        );
                        comboBoxLivreAuteurNom.Items.Add(oAuteurTrouve.auteur_nom);
                        comboBoxLivreAuteurPrenom.Items.Add(oAuteurTrouve.auteur_prenom);
                    }

                    var oGenreQuery = from tableGenre in monContext.genres
                                      where tableGenre.genre_libelle == comboBoxLivreGenre.Text
                                      select tableGenre;
                    genre oGenreTrouve = oGenreQuery.FirstOrDefault();
                    if (oGenreTrouve == null)
                    {
                        oGenreTrouve = new genre
                        {
                            genre_libelle = comboBoxLivreGenre.Text
                        };
                        monContext.genres.Add(oGenreTrouve);
                        monContext.SaveChanges();
                        comboBoxLivreGenre.Items.Add(
                            oGenreTrouve.genre_libelle
                        );
                    }

                    var oEmplacementQuery = from tableEmplacement in monContext.emplacements
                                            where tableEmplacement.emplacement_libelle == comboBoxLivreEmplacement.Text
                                            select tableEmplacement;
                    emplacement oEmplacementTrouve = oEmplacementQuery.FirstOrDefault();
                    if (oEmplacementTrouve == null)
                    {
                        oEmplacementTrouve = new emplacement
                        {
                            emplacement_libelle = comboBoxLivreEmplacement.Text
                        };
                        monContext.emplacements.Add(oEmplacementTrouve);
                        monContext.SaveChanges();
                        comboBoxLivreEmplacement.Items.Add(
                            oEmplacementTrouve.emplacement_libelle
                        );
                    }

                    var oLivre = new livre
                    {
                        livre_titre = textBoxLivreTitre.Text,
                        livre_annee_parution = dateTimePickerLivreAnneeParution.Value,
                        auteur_ID = oAuteurTrouve.auteur_ID,
                        genre_ID = oGenreTrouve.genre_ID,
                        emplacement_ID = oEmplacementTrouve.emplacement_ID
                    };
                    monContext.livres.Add(oLivre);    //  On ajoute le nouveau livre
                    monContext.SaveChanges();   //  puis nous sauvegardons le tout dans la base

                    //  Nous rajoutons le nouvel adhérent à la DataGridView
                    dataGridViewLivre.Rows.Add(
                        oLivre.livre_ID,
                        oLivre.livre_titre,
                        oLivre.livre_annee_parution,
                        oGenreTrouve.genre_libelle,
                        oAuteurTrouve.auteur_nom,
                        oAuteurTrouve.auteur_prenom,
                        oEmplacementTrouve.emplacement_libelle
                    );
                }
            }
            catch (Exception eException)
            {
                MessageBox.Show("Impossible de créer le livre !\n" + eException.Message);
            }
        }
        //**********************************************************************
        //  Se produit au clic du bouton Modification dans l'onglet tabPageLivre
        //**********************************************************************

        private void buttonLivreModification_Click(object sender, EventArgs e)
        {
             

            string sMessageDErreur = "";
            try
            {
                if ("" == textBoxLivreId.Text)
                {   //  Il nous faut obligatoirement l'ID pour continuer
                    sMessageDErreur += "\n" + "- Vous devez saisir l'ID du livre à modifier";
                }

                if ("" != sMessageDErreur)
                {   //  Pour le moindre motif d'erreur, nous levons une exception et on interrompt l'éxécution du code
                    throw new Exception(sMessageDErreur);
                }

                using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                {   //  On va rechercher en base si l'ID de notre bibliothecaire éxiste toujours
                    var oLivre = monContext.livres.Find(int.Parse(textBoxLivreId.Text));
                    if (oLivre == null)
                    {   //  Si on le trouve pas, l'objet est null et on a rien à supprimer !
                        throw new Exception("Le livre avec un ID " + textBoxLivreId.Text + " n'éxiste pas !");
                    }

                    foreach(DataGridViewRow oDataGridViewRow in dataGridViewLivre.Rows)
                    {
                        if(textBoxLivreId.Text == oDataGridViewRow.Cells[0].Value.ToString())
                        {
                            if ("" != textBoxLivreTitre.Text)
                            {
                                oLivre.livre_titre = textBoxLivreTitre.Text;
                                oDataGridViewRow.Cells[1].Value = textBoxLivreTitre.Text;
                            }

                            oLivre.livre_annee_parution = dateTimePickerLivreAnneeParution.Value;
                            oDataGridViewRow.Cells[2].Value = dateTimePickerLivreAnneeParution.Value;

                            var oGenreQuery = from tableGenre in monContext.genres
                                              where tableGenre.genre_libelle == comboBoxLivreGenre.Text
                                              select tableGenre;
                            genre oGenreTrouve = oGenreQuery.FirstOrDefault();
                            if (oGenreTrouve == null)
                            {
                                oGenreTrouve = new genre
                                {
                                    genre_libelle = comboBoxLivreGenre.Text
                                };
                                monContext.genres.Add(oGenreTrouve);
                                monContext.SaveChanges();
                            }
                            oLivre.genre_ID = oGenreTrouve.genre_ID;
                            oDataGridViewRow.Cells[3].Value = oGenreTrouve.genre_libelle;

                            var oAuteurQuery = from tableAuteur in monContext.auteurs
                                               where tableAuteur.auteur_nom == comboBoxLivreAuteurNom.Text
                                               && tableAuteur.auteur_prenom == comboBoxLivreAuteurPrenom.Text
                                               select tableAuteur;
                            auteur oAuteurTrouve = oAuteurQuery.FirstOrDefault();
                            if (oAuteurTrouve == null)
                            {
                                oAuteurTrouve = new auteur
                                {
                                    auteur_nom = comboBoxLivreAuteurNom.Text,
                                    auteur_prenom = comboBoxLivreAuteurPrenom.Text
                                };
                                monContext.auteurs.Add(oAuteurTrouve);
                                monContext.SaveChanges();

                                dataGridViewAuteur.Rows.Add(
                                    oAuteurTrouve.auteur_ID,
                                    oAuteurTrouve.auteur_nom,
                                    oAuteurTrouve.auteur_prenom
                                );
                            }
                            oLivre.auteur_ID = oAuteurTrouve.auteur_ID;
                            oDataGridViewRow.Cells[4].Value = oAuteurTrouve.auteur_nom;
                            oDataGridViewRow.Cells[5].Value = oAuteurTrouve.auteur_prenom;

                            var oEmplacementQuery = from tableEmplacement in monContext.emplacements
                                                    where tableEmplacement.emplacement_libelle == comboBoxLivreEmplacement.Text
                                                    select tableEmplacement;
                            emplacement oEmplacementTrouve = oEmplacementQuery.FirstOrDefault();
                            if (oEmplacementTrouve == null)
                            {
                                oEmplacementTrouve = new emplacement
                                {
                                    emplacement_libelle = comboBoxLivreEmplacement.Text
                                };
                                monContext.emplacements.Add(oEmplacementTrouve);
                                monContext.SaveChanges();
                            }
                            oLivre.emplacement_ID = oEmplacementTrouve.emplacement_ID;
                            oDataGridViewRow.Cells[6].Value = oEmplacementTrouve.emplacement_libelle;

                            break;
                        }
                    }

                    monContext.SaveChanges();   //  On sauvegarde les données
                }
            }
            catch (Exception eException)
            {
                MessageBox.Show("Impossible de modifier le livre !\n" + eException.Message);
            }
        }

        //***********************************************************************
        //  Se produit au clic du bouton suppression dans l'onglet tabPageLivre
        //***********************************************************************
        private void buttonLivreSuppression_Click(object sender, EventArgs e)
        {
             

            string sMessageDErreur = "";
            try
            {
                if ("" == textBoxLivreId.Text)
                {   //  Il nous faut obligatoirement l'ID pour continuer
                    sMessageDErreur += "\n" + "- Vous devez saisir l'ID du livre à supprimer";
                }

                if ("" != sMessageDErreur)
                {   //  Pour le moindre motif d'erreur, nous levons une exception et on interrompt l'éxécution du code
                    throw new Exception(sMessageDErreur);
                }

                using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                {   //  On va rechercher en base si l'ID du livre éxiste toujours
                    var iLivreId = int.Parse(textBoxLivreId.Text);
                    var oLivre = monContext.livres.Find(int.Parse(textBoxLivreId.Text));
                    if (oLivre == null)
                    {   //  Si on le trouve pas, l'objet est null et on a rien à supprimer !
                        throw new Exception("Le livre avec un ID " + textBoxLivreId.Text + " n'éxiste pas !");
                    }

                    var oEmprunter = monContext.emprunters.Where(tableEmprunter => tableEmprunter.livre_ID == iLivreId).FirstOrDefault();
                    if (oEmprunter != null)
                    {
                        //si on trouve des emprunts pour l'usager ne pas le supprimer
                        throw new Exception("Le livre n'a pas encore été rendu. On ne peut le supprimer !");

                    }
                    monContext.livres.Remove(oLivre); //  On supprime le livre
                    monContext.SaveChanges();   //  On sauvegarde les données

                    //  Nous recherchons dans la DataGridView le livre supprimé et nous l'enlevons du DataGridView
                    foreach (DataGridViewRow oDataGridViewRow in dataGridViewLivre.Rows)
                    {
                        if (textBoxLivreId.Text == oDataGridViewRow.Cells[0].Value.ToString())
                        {
                            dataGridViewLivre.Rows.Remove(oDataGridViewRow);
                            break;
                        }
                    }
                }
            }
            catch (Exception eException)
            {
                MessageBox.Show("Impossible de supprimer le livre !\n" + eException.Message);
            }
        }


        private void buttonLivreRechercher_Click(object sender, EventArgs e)
        {
            buttonLivreAfficherTout.Visible = true;
            rechercherLivre(
                textBoxLivreId.Text,
                textBoxLivreTitre.Text,
                dateTimePickerLivreAnneeParution.Value,
                comboBoxLivreGenre.Text,
                comboBoxLivreAuteurNom.Text,
                comboBoxLivreAuteurPrenom.Text,
                comboBoxLivreEmplacement.Text
            );
        }

        private void buttonLivreAfficherTout_Click(object sender, EventArgs e)
        {
            buttonLivreAfficherTout.Visible = false;
            rechercherLivre();
        }

        private void rechercherLivre(string sId = "", string sTitre = "", DateTime? dAnneeParution = null, string sGenre = "", string sAuteurNom = "", string sAuteurPrenom = "", string sEmplacement = "")
        {
            using (maBibliothequeEntities monContext = new maBibliothequeEntities())
            {
                var oLivreQuery = from tableLivre in monContext.livres
                                  join tableGenre in monContext.genres on tableLivre.genre_ID equals tableGenre.genre_ID
                                  join tableAuteur in monContext.auteurs on tableLivre.auteur_ID equals tableAuteur.auteur_ID
                                  join tableEmplacement in monContext.emplacements on tableLivre.emplacement_ID equals tableEmplacement.emplacement_ID
                                  select new
                                  {
                                      tableLivre.livre_ID,
                                      tableLivre.livre_titre,
                                      tableLivre.livre_annee_parution,
                                      tableLivre.genre_ID,
                                      tableGenre.genre_libelle,
                                      tableLivre.auteur_ID,
                                      tableAuteur.auteur_nom,
                                      tableAuteur.auteur_prenom,
                                      tableLivre.emplacement_ID,
                                      tableEmplacement.emplacement_libelle
                                  };
                if ("" != sId)
                {
                    int iLivreId = int.Parse(sId);
                    oLivreQuery = oLivreQuery.Where(
                        tableLivre => tableLivre.livre_ID == iLivreId
                    );
                }

                if ("" != sTitre)
                {
                    oLivreQuery = oLivreQuery.Where(
                        tableLivre => tableLivre.livre_titre.Contains(sTitre)
                    );
                }

                if (null != dAnneeParution)
                {
                    oLivreQuery = oLivreQuery.Where(
                        tableLivre => tableLivre.livre_annee_parution.Value.Year == dAnneeParution.Value.Year
                    );
                }

                if (null != sGenre)
                {
                    oLivreQuery = oLivreQuery.Where(
                        tableLivre => tableLivre.genre_libelle.Contains(sGenre)
                    );
                }

                if ("" != sAuteurNom)
                {
                    oLivreQuery = oLivreQuery.Where(
                        tableLivre => tableLivre.auteur_nom.Contains(sAuteurNom)
                    );
                }

                if ( "" != sAuteurPrenom)
                {
                    oLivreQuery = oLivreQuery.Where(
                        tableLivre => tableLivre.auteur_prenom.Contains(sAuteurPrenom)
                    );
                }

                if (null != sEmplacement)
                {
                    oLivreQuery = oLivreQuery.Where(
                        tableLivre => tableLivre.emplacement_libelle.Contains(sEmplacement)
                    );
                }

                var oListResultats = oLivreQuery.ToList();
                dataGridViewLivre.Rows.Clear();
                foreach(var oResult in oListResultats)
                {
                    dataGridViewLivre.Rows.Add(
                        oResult.livre_ID,
                        oResult.livre_titre,
                        oResult.livre_annee_parution,
                        oResult.genre_libelle,
                        oResult.auteur_nom,
                        oResult.auteur_prenom,
                        oResult.emplacement_libelle
                    );
                }
            }
        }

        private void tabPageLivre_Enter(object sender, EventArgs e)
        {
            if (0 == dataGridViewLivre.Rows.Count)
            {
                buttonLivreAfficherTout_Click(sender, e);

                if (0 == comboBoxLivreAuteurNom.Items.Count)
                {//  On remplit le ComboBox des genres
                    using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                    {
                        var oQuery = from nimportequoi in monContext.auteurs select nimportequoi;
                        var oListResultats = oQuery.ToList();
                        foreach (auteur oAuteur in oListResultats)
                        {
                            comboBoxLivreAuteurNom.Items.Add(oAuteur.auteur_nom);
                            comboBoxLivreAuteurPrenom.Items.Add(oAuteur.auteur_prenom);
                        }
                    }
                }

                if (0 == comboBoxLivreGenre.Items.Count)
                {//  On remplit le ComboBox des genres
                    using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                    {
                        var oQuery = from nimportequoi in monContext.genres select nimportequoi;
                        var oListResultats = oQuery.ToList();
                        foreach (genre oGenre in oListResultats)
                        {
                            comboBoxLivreGenre.Items.Add(
                                oGenre.genre_libelle
                            );
                        }
                    }

                }

                if (0 == comboBoxLivreEmplacement.Items.Count)
                {//  On remplit le ComboBox des emplacements
                    using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                    {
                        var oQuery = from nimportequoi in monContext.emplacements select nimportequoi;
                        var oListResultats = oQuery.ToList();
                        foreach (emplacement oEmplacement in oListResultats)
                        {
                            comboBoxLivreEmplacement.Items.Add(
                                oEmplacement.emplacement_libelle
                            );
                        }
                    }
                }
            }
        }
        
        private void dataGridViewLivre_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            dataGridViewLivre_StateChanged();
        }

        private void dataGridViewLivre_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            dataGridViewLivre_StateChanged();
        }

        private void dataGridViewLivre_StateChanged()
        {
            DataGridViewSelectedCellCollection oCellCollection = dataGridViewLivre.SelectedCells;
            if (0 == oCellCollection.Count)
            {
                return;
            }
            DataGridViewCellCollection oRowCells = oCellCollection[0].OwningRow.Cells;

            textBoxLivreId.Text = oRowCells[0].Value.ToString();
            textBoxLivreTitre.Text = oRowCells[1].Value.ToString();
            dateTimePickerLivreAnneeParution.Value = (DateTime)oRowCells[2].Value;
            comboBoxLivreGenre.Text = oRowCells[3].Value.ToString();
            comboBoxLivreAuteurNom.Text = oRowCells[4].Value.ToString();
            comboBoxLivreAuteurPrenom.Text = oRowCells[5].Value.ToString();
            comboBoxLivreEmplacement.Text = oRowCells[6].Value.ToString();
        }

        #endregion tabPageLivre

        #region tabPageAuteur
        //**************************************************************************
        //  Fonction appellée au clic sur le bouton Création dans le tabPage Auteur
        //***************************************************************************
        private void buttonAuteurCreation_Click(object sender, EventArgs e)
        {
            
            if  ( "" == textBoxAuteurNom.Text
              || "" == textBoxAuteurPrenom.Text
                             )
            {
                MessageBox.Show("Tous les champs saisis doivent être obligatoires");
                return;
            }
            using (maBibliothequeEntities monContext = new maBibliothequeEntities())
            {
                try
                { // Nous en créeons un nouveau
                    var monNouveauAuteur = new auteur
                    {
                        auteur_nom = textBoxAuteurNom.Text,
                        auteur_prenom = textBoxAuteurPrenom.Text
                    };
                    //  Nous l'ajoutons à la base
                    monContext.auteurs.Add(monNouveauAuteur);
                    monContext.SaveChanges();

                    //  Nous rajoutons le nouveau auteur à la DataGridView
                    dataGridViewAuteur.Rows.Add(
                        monNouveauAuteur.auteur_ID,
                        monNouveauAuteur.auteur_nom,
                        monNouveauAuteur.auteur_prenom
                    );
                }
                catch (Exception eException)
                {
                    MessageBox.Show("Erreur dans la creation de l'auteur" + eException.Message);
                }
            }

        }

        //**************************************************************************
        //  Fonction appellée au clic sur le bouton Modification dans le tabPage Auteur
        //***************************************************************************
        private void buttonAuteurModification_Click(object sender, EventArgs e)
        {
            string sMessageDErreur = "";
            try
            {
                if ("" == textBoxAuteurId.Text)
                {   //  Il nous faut obligatoirement l'ID pour continuer
                    sMessageDErreur += "\n" + "- Vous devez saisir l'ID l'auteur à modifier";
                }


                if ("" != sMessageDErreur)
                {   //  Pour le moindre motif d'erreur, nous levons une exception et on interrompt l'éxécution du code
                    throw new Exception(sMessageDErreur);
                }

                using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                {   //  On va rechercher en base si l'ID de notre auteur éxiste toujours
                    var oAuteurs = monContext.auteurs.Find(int.Parse(textBoxAuteurId.Text));
                    if (oAuteurs == null)
                    {   //  Si on le trouve pas, l'objet est null et on ne modifie rien !
                        throw new Exception("L'auteur avec un ID " + textBoxAuteurId.Text + " n'éxiste pas !");
                    }

                    //  Pour chacun des champs, on vérifie s'il est vide. S'il ne l'est pas, on me modifie pas sa valeur !
                    if ("" != textBoxAuteurNom.Text)
                    {
                        oAuteurs.auteur_nom = textBoxAuteurNom.Text;
                    }
                    if ("" != textBoxAuteurPrenom.Text)
                    {
                        oAuteurs.auteur_prenom = textBoxAuteurPrenom.Text;
                    }
                    
                    //  Une fois qu'on a mis à jour toutes les propriétés de l'objet, on n'a plus qu'à sauvegarder le contexte
                    monContext.SaveChanges();

                    //  Nous recherchons dans la DataGridView le bibliothécaire modifié et nous mettons à jour les cellules
                    foreach (DataGridViewRow oDataGridViewRow in dataGridViewAuteur.Rows)
                    {
                        if (textBoxAuteurId.Text == oDataGridViewRow.Cells[0].Value.ToString())
                        {
                            oDataGridViewRow.SetValues(
                                oAuteurs.auteur_ID.ToString(),
                                oAuteurs.auteur_nom,
                                oAuteurs.auteur_prenom
                            );
                            break;
                        }
                    }
                }
            }
            catch (Exception eException)
            {
                MessageBox.Show("Impossible de modifier l'auteur !\n" + eException.Message);
            }
        }
        //**************************************************************************
        //  Fonction appellée au clic sur le bouton Suppression dans le tabPage Auteur
        //***************************************************************************
        private void buttonAuteurSuppression_Click(object sender, EventArgs e)
        {
            string sMessageDErreur = "";
            try
            {
                if ("" == textBoxAuteurId.Text)
                {   //  Il nous faut obligatoirement l'ID pour continuer
                    sMessageDErreur += "\n" + "- Vous devez saisir l'ID de l'auteur à supprimer";
                }

                if ("" != sMessageDErreur)
                {   //  Pour le moindre motif d'erreur, nous levons une exception et on interrompt l'éxécution du code
                    throw new Exception(sMessageDErreur);
                }

                using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                {   //  On va rechercher en base si l'ID de l'auteur éxiste toujours
                    var oAuteurs = monContext.auteurs.Find(int.Parse(textBoxAuteurId.Text));
                    if (oAuteurs == null)
                    {   //  Si on le trouve pas, l'objet est null et on a rien à supprimer !
                        throw new Exception("L'auteur avec un ID " + textBoxAuteurId.Text + " n'éxiste pas !");
                    }
                    //
                    // vérifier qu'à l'auteur ne correspond aucun livre
                    //
                    var iAuteurId = int.Parse(textBoxAuteurId.Text);
                    var oLivre= monContext.livres.Where(t => t.auteur_ID == iAuteurId).FirstOrDefault();
                    if (oLivre != null)
                    {
                        //si on trouve des livres pour l'auteur ne pas le supprimer
                        throw new Exception("L'auteur a des livres.\nOn ne peut le supprimer !");

                    }

                    monContext.auteurs.Remove(oAuteurs); //  On supprime l'adhérent
                    monContext.SaveChanges();   //  On sauvegarde les données

                    //  Nous recherchons dans la DataGridView l'auteur supprimé et nous l'enlevons du DataGridView
                    foreach (DataGridViewRow oDataGridViewRow in dataGridViewAuteur.Rows)
                    {
                        if (textBoxAuteurId.Text == oDataGridViewRow.Cells[0].Value.ToString())
                        {
                            //  oDataGridViewRow.Cells[0] = textBoxAuteurId.Text;
                            dataGridViewAuteur.Rows.Remove(oDataGridViewRow);
                            break;
                        }
                    }
                }
            }
            catch (Exception eException)
            {
                MessageBox.Show("Impossible de supprimer l'auteur !\n" + eException.Message);
            }
        }

        private void buttonAuteurRechercher_Click(object sender, EventArgs e)
        {
            buttonAuteurAfficherTout.Visible = true;
            rechercherAuteur(
                textBoxAuteurId.Text,
                textBoxAuteurNom.Text,
                textBoxAuteurPrenom.Text
            );
        }

        private void buttonAuteurAfficherTout_Click(object sender, EventArgs e)
        {
            buttonAuteurAfficherTout.Visible = false;
            rechercherAuteur();
        }

        private void rechercherAuteur(string sId = "", string sAuteurNom = "", string sAuteurPrenom = "")
        {
            using (maBibliothequeEntities monContext = new maBibliothequeEntities())
            {
                var oAuteurQuery = from tableAuteur in monContext.auteurs
                                   select tableAuteur;
                if ("" != sId)
                {
                    int iAuteurId = int.Parse(sId);
                    oAuteurQuery = oAuteurQuery.Where(
                        tableAuteur => tableAuteur.auteur_ID == iAuteurId
                    );
                }

                if ("" != sAuteurNom)
                {
                    oAuteurQuery = oAuteurQuery.Where(
                        tableAuteur => tableAuteur.auteur_nom.Contains(sAuteurNom)
                    );
                }


                if ("" != sAuteurPrenom)
                {
                    oAuteurQuery = oAuteurQuery.Where(
                        tableAuteur => tableAuteur.auteur_prenom.Contains(sAuteurPrenom)
                    );
                }

                var oListResultats = oAuteurQuery.ToList();
                dataGridViewAuteur.Rows.Clear();
                foreach (auteur oAuteur in oListResultats)
                {
                    dataGridViewAuteur.Rows.Add(
                        oAuteur.auteur_ID,
                        oAuteur.auteur_nom,
                        oAuteur.auteur_prenom
                    );
                }
            }
        }

        private void tabPageAuteur_Enter(object sender, EventArgs e)
        {
            dataGridViewAuteur.Rows.Clear();

                using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                {
                    var oQuery = from nimportequoi in monContext.auteurs select nimportequoi;
                    var oListResultats = oQuery.ToList();
                    foreach (auteur oAuteur in oListResultats)
                    {
                        dataGridViewAuteur.Rows.Add(
                            oAuteur.auteur_ID,
                            oAuteur.auteur_nom,
                            oAuteur.auteur_prenom
                        );
                    }
                }
        }

        private void dataGridViewAuteur_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            dataGridViewAuteur_StateChanged();
        }

        private void dataGridViewAuteur_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            dataGridViewAuteur_StateChanged();
        }

        private void dataGridViewAuteur_StateChanged()
        {
            DataGridViewSelectedCellCollection oCellCollection = dataGridViewAuteur.SelectedCells;
            if (0 == oCellCollection.Count)
            {
                return;
            }
            DataGridViewCellCollection oRowCells = oCellCollection[0].OwningRow.Cells;

            textBoxAuteurId.Text = oRowCells[0].Value.ToString();
            textBoxAuteurNom.Text = oRowCells[1].Value.ToString();
            textBoxAuteurPrenom.Text = oRowCells[2].Value.ToString();
        }

        #endregion tabPageAuteur

        #region tabPageEmprunt

        //************************
        // Traitement de l'emprunt
        //************************
        private void buttonEmprunt_Click(object sender, EventArgs e)
        {
            string sMessageDErreur = "";
            try
            {
                if ("" == textBoxEmprunterAdherentId.Text || "" == textBoxEmprunterLivreId.Text)
                {   //  Il nous faut obligatoirement l'ID pour continuer
                    sMessageDErreur += "\n" + "- Vous devez saisir l'ID de l'adherent et l'ID du livre";
                }


                if ("" != sMessageDErreur)
                {   //  Pour le moindre motif d'erreur, nous levons une exception et on interrompt l'éxécution du code
                    throw new Exception(sMessageDErreur);
                }

                using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                {   //  On va rechercher en base si l'ID de l'adherent éxiste toujours
                    var oEmpruntAdherent = monContext.adherents.Find(int.Parse(textBoxEmprunterAdherentId.Text));
                    if (oEmpruntAdherent == null)
                    {   //  Si on le trouve pas, l'adherent n'est pas trouvé !
                        throw new Exception("L'adherent avec un ID " + textBoxEmprunterAdherentId.Text + " n'éxiste pas !");
                    }

                    var oEmpruntLivre = monContext.livres.Find(int.Parse(textBoxEmprunterLivreId.Text));
                    if (oEmpruntLivre == null)
                    {   //  Si on le trouve pas, le livre n'est pas trouvé !
                        throw new Exception("Le livre avec un ID " + textBoxEmprunterLivreId.Text + " n'éxiste pas !");
                    }

                    // verifier qu'il n'y a pas 5 emprunts 

                    int iAdherentId = int.Parse(textBoxEmprunterAdherentId.Text);
                    if (monContext.emprunters.Count(t => t.adherent_ID == iAdherentId)>4)
                    {
                        throw new Exception("l'adherent a déjà 5 emprunts ! Nouvel emprunt non autorisé ");
                    }

                    var oEmprunter = new emprunter
                    {
                        date_emprunt = dateTimePickerDateEmprunt.Value,
                        date_retour = dateTimePickerDateRetour.Value,
                        livre_ID = oEmpruntLivre.livre_ID,
                        adherent_ID = oEmpruntAdherent.adherent_ID

                    };

                    monContext.emprunters.Add(oEmprunter);    //  On ajoute le nouveau emprunt
                    monContext.SaveChanges();   //  puis nous sauvegardons le tout dans la base

                    // Remplir la dataGridView avec les informations de l'emprunt
                    dataGridViewEmprunter.Rows.Add(
                        oEmpruntAdherent.adherent_ID,
                        oEmpruntAdherent.adherent_nom,
                        oEmpruntAdherent.adherent_prenom,
                        oEmpruntLivre.livre_ID,
                        oEmpruntLivre.livre_titre,
                        dateTimePickerDateEmprunt.Value,
                        dateTimePickerDateRetour.Value
                        );
                    
                }
            }
            catch (Exception eException)
            {
                MessageBox.Show("Impossible de realiser l'emprunt !\n" + eException.Message);
            }
            
         }

        private void tabPageEmprunt_Enter(object sender, EventArgs e)
        {
            if (0 == dataGridViewEmprunter.Rows.Count)
            {
                dateTimePickerDateRetour.Value = dateTimePickerDateEmprunt.Value.AddDays(21);
                buttonEmpruntAfficherTout_Click(sender, e);
            }
        }

        //************************
        // Traitement du retour
        //************************
        private void buttonRendre_Click(object sender, EventArgs e)
        {
            string sMessageDErreur = "";
            try
            {
                if ("" == textBoxEmprunterAdherentId.Text || "" == textBoxEmprunterLivreId.Text)
                {   //  Il nous faut obligatoirement l'ID pour continuer
                    sMessageDErreur += "\n" + "- Vous devez saisir l'ID de l'adherent et l'ID du livre";
                }


                if ("" != sMessageDErreur)
                {   //  Pour le moindre motif d'erreur, nous levons une exception et on interrompt l'éxécution du code
                    throw new Exception(sMessageDErreur);
                }

                using (maBibliothequeEntities monContext = new maBibliothequeEntities())
                {
                    int iAdherentId = int.Parse(textBoxEmprunterAdherentId.Text);
                    int iLivreId = int.Parse(textBoxEmprunterLivreId.Text);
                    var oEmprunt = monContext.emprunters.Where(t => t.adherent_ID == iAdherentId && t.livre_ID == iLivreId).FirstOrDefault();
                    monContext.emprunters.Remove(oEmprunt); //  On supprime l'emprunt
                    monContext.SaveChanges();   //  On sauvegarde les données

                    //  Nous recherchons dans la DataGridView l'emprunt supprimé et nous l'enlevons du DataGridView
                    foreach (DataGridViewRow oDataGridViewRow in dataGridViewEmprunter.Rows)
                    {
                        if (oEmprunt.adherent_ID == (int)oDataGridViewRow.Cells[0].Value
                            && oEmprunt.livre_ID == (int)oDataGridViewRow.Cells[3].Value
                            )
                        {
                            dataGridViewEmprunter.Rows.Remove(oDataGridViewRow);
                            break;
                        }
                    }
                }

            }
            catch (Exception eException)
            {
                MessageBox.Show("Impossible de supprimer l'emprunt !\n" + eException.Message);
            }
        }

        //************************************** 
        // Traitement de la liste des retards
        //**************************************
        private void buttonListeRetards_Click(object sender, EventArgs e)
        {
            buttonEmpruntAfficherTout.Visible = true;
            rechercherEmprunt("", "", null, null, true);
        }

        private void dataGridViewEmprunter_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            dataGridViewEmprunter_StateChanged();
        }

        private void dataGridViewEmprunter_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            dataGridViewEmprunter_StateChanged();
        }

        private void dataGridViewEmprunter_StateChanged()
        {
            DataGridViewSelectedCellCollection oCellCollection = dataGridViewEmprunter.SelectedCells;
            if (0 == oCellCollection.Count)
            {
                return;
            }
            DataGridViewCellCollection oRowCells = oCellCollection[0].OwningRow.Cells;

            textBoxEmprunterAdherentId.Text = oRowCells[0].Value.ToString();
            textBoxEmprunterLivreId.Text = oRowCells[1].Value.ToString();
            //  dateTimePickerDateEmprunt.Value = (DateTime)oRowCells[2].Value;
            //  dateTimePickerDateRetour.Value = (DateTime)oRowCells[3].Value;
        }

        #endregion tabPageEmprunt

        private void buttonEmpruntRechercher_Click(object sender, EventArgs e)
        {
            buttonEmpruntAfficherTout.Visible = true;
            rechercherEmprunt(
                textBoxEmprunterAdherentId.Text,
                textBoxEmprunterLivreId.Text
            );
        }

        private void buttonEmpruntAfficherTout_Click(object sender, EventArgs e)
        {
            buttonEmpruntAfficherTout.Visible = false;
            rechercherEmprunt();
        }

        private void rechercherEmprunt(string sIdAdherent = "", string sIdLivre = "", DateTime? dDateEmprunt = null, DateTime? dDateRetour = null, Boolean bAfficherRetards = false)
        {
            using (maBibliothequeEntities monContext = new maBibliothequeEntities())
            {
                var oEmpruntQuery = from tableEmprunt in monContext.emprunters
                                    join tableAdherent in monContext.adherents
                                      on tableEmprunt.adherent_ID equals tableAdherent.adherent_ID
                                    join tableLivre in monContext.livres
                                      on tableEmprunt.livre_ID equals tableLivre.livre_ID
                                    select new
                                    {
                                        tableAdherent.adherent_ID,
                                        tableAdherent.adherent_nom,
                                        tableAdherent.adherent_prenom,
                                        tableLivre.livre_ID,
                                        tableLivre.livre_titre,
                                        tableEmprunt.date_emprunt,
                                        tableEmprunt.date_retour
                                    };

                if ("" != sIdAdherent)
                {
                    int iIdAdherent = int.Parse(sIdAdherent);
                    oEmpruntQuery = oEmpruntQuery.Where(
                        tableEmprunt => tableEmprunt.adherent_ID == iIdAdherent
                    );
                }

                if ("" != sIdLivre)
                {
                    int iIdLivre = int.Parse(sIdLivre);
                    oEmpruntQuery = oEmpruntQuery.Where(
                        tableEmprunt => tableEmprunt.livre_ID == iIdLivre
                    );
                }

                if (null != dDateEmprunt)
                {
                    oEmpruntQuery = oEmpruntQuery.Where(
                        tableEmprunt => tableEmprunt.date_emprunt.Value.Date == dDateEmprunt.Value.Date
                    );
                }

                if (null != dDateRetour)
                {
                    oEmpruntQuery = oEmpruntQuery.Where(
                        tableEmprunt => tableEmprunt.date_retour.Value.Date == dDateRetour.Value.Date
                    );
                }

                if(false != bAfficherRetards)
                {
                    DateTime dDateDemain = DateTime.Now.AddDays(1).Date;
                    oEmpruntQuery = oEmpruntQuery.Where(
                        tableEmprunt => tableEmprunt.date_retour.Value <= dDateDemain
                    );
                }


                var oListResultats = oEmpruntQuery.ToList();
                dataGridViewEmprunter.Rows.Clear();
                foreach (var oEmprunt in oListResultats)
                {
                    dataGridViewEmprunter.Rows.Add(
                        oEmprunt.adherent_ID,
                        oEmprunt.adherent_nom,
                        oEmprunt.adherent_prenom,
                        oEmprunt.livre_ID,
                        oEmprunt.livre_titre,
                        oEmprunt.date_emprunt,
                        oEmprunt.date_retour
                    );
                }
            }
        }

        private void dataGridViewEmprunt_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            dataGridViewEmprunt_StateChanged();
        }

        private void dataGridViewEmprunt_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            dataGridViewEmprunt_StateChanged();
        }

        private void dataGridViewEmprunt_StateChanged()
        {
            DataGridViewSelectedCellCollection oCellCollection = dataGridViewEmprunter.SelectedCells;
            if (0 == oCellCollection.Count)
            {
                return;
            }
            DataGridViewCellCollection oRowCells = oCellCollection[0].OwningRow.Cells;

            textBoxEmprunterAdherentId.Text = oRowCells[0].Value.ToString();
            textBoxEmprunterLivreId.Text = oRowCells[3].Value.ToString();
        }
    }
}