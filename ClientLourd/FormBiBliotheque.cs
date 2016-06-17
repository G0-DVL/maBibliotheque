﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                        bibliothecaire_ID = 1,
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
            tabControlBibliotheque.TabPages.Remove(tabPageBibliothecaire);
            tabControlBibliotheque.TabPages.Remove(tabPageAdherent);
            tabControlBibliotheque.TabPages.Remove(tabPageLivre);

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
                    MessageBox.Show("Bonjour " + oBibliothecaire.bibliothecaire_prenom + " " + oBibliothecaire.bibliothecaire_nom);
                    tabControlBibliotheque.TabPages.Add(oTabPageBibliothecaire);
                    tabControlBibliotheque.TabPages.Add(oTabPageAdherent);
                    tabControlBibliotheque.TabPages.Add(oTabPageLivre);
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
        private void buttonBibliothecaireCreation_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewLivre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}