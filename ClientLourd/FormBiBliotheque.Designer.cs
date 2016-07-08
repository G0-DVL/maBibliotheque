namespace ClientLourd
{
    partial class FormBiBliotheque
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPass = new System.Windows.Forms.Label();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonIdentificationValidate = new System.Windows.Forms.Button();
            this.tabControlBibliotheque = new System.Windows.Forms.TabControl();
            this.tabPageIdentification = new System.Windows.Forms.TabPage();
            this.panelIdentification = new System.Windows.Forms.Panel();
            this.tabPageBibliothecaire = new System.Windows.Forms.TabPage();
            this.dataGridViewBibliothecaire = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBibliothecaireSuppression = new System.Windows.Forms.Button();
            this.buttonBibliothecaireModification = new System.Windows.Forms.Button();
            this.buttonBibliothecaireCreation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBibliothecairePrenom = new System.Windows.Forms.TextBox();
            this.textBoxBibliothecaireNom = new System.Windows.Forms.TextBox();
            this.textBoxBibliothecairePassword = new System.Windows.Forms.TextBox();
            this.textBoxBibliothecaireLogin = new System.Windows.Forms.TextBox();
            this.textBoxBibliothecaireId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageAdherent = new System.Windows.Forms.TabPage();
            this.dateTimePickerAdherentDateInscr = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAdherentDateNaiss = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewAdherent = new System.Windows.Forms.DataGridView();
            this.AdherentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdherentNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdherentPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdherentDateNaiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdherentAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdherentCodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdherentTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdherentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdherentDateInscr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxAdherentEmail = new System.Windows.Forms.TextBox();
            this.textBoxAdherentTelephone = new System.Windows.Forms.TextBox();
            this.textBoxAdherentCodePostal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAdherentSupp = new System.Windows.Forms.Button();
            this.buttonAdherentModif = new System.Windows.Forms.Button();
            this.buttonAdherentCreation = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAdherentAdresse = new System.Windows.Forms.TextBox();
            this.textBoxAdherentPrenom = new System.Windows.Forms.TextBox();
            this.textBoxAdherentNom = new System.Windows.Forms.TextBox();
            this.textBoxAdherentId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageLivre = new System.Windows.Forms.TabPage();
            this.comboBoxLivreAuteurPrenom = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBoxLivreEmplacement = new System.Windows.Forms.ComboBox();
            this.comboBoxLivreGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxLivreAuteurNom = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridViewLivre = new System.Windows.Forms.DataGridView();
            this.buttonLivreSuppression = new System.Windows.Forms.Button();
            this.buttonLivreModification = new System.Windows.Forms.Button();
            this.buttonLivreCreation = new System.Windows.Forms.Button();
            this.dateTimePickerLivreAnneeParution = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxLivreTitre = new System.Windows.Forms.TextBox();
            this.textBoxLivreId = new System.Windows.Forms.TextBox();
            this.tabPageAuteur = new System.Windows.Forms.TabPage();
            this.dataGridViewAuteur = new System.Windows.Forms.DataGridView();
            this.AuteurID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuteurNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuteurPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAuteurSuppression = new System.Windows.Forms.Button();
            this.buttonAuteurModification = new System.Windows.Forms.Button();
            this.buttonAuteurCreation = new System.Windows.Forms.Button();
            this.textBoxAuteurPrenom = new System.Windows.Forms.TextBox();
            this.textBoxAuteurNom = new System.Windows.Forms.TextBox();
            this.textBoxAuteurId = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPageEmprunt = new System.Windows.Forms.TabPage();
            this.buttonListeRetards = new System.Windows.Forms.Button();
            this.dataGridViewEmprunter = new System.Windows.Forms.DataGridView();
            this.IdAdherent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomAdherent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomAdherent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLivre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitreLivre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEmprunt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRetour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRendre = new System.Windows.Forms.Button();
            this.buttonEmprunt = new System.Windows.Forms.Button();
            this.dateTimePickerDateRetour = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dateTimePickerDateEmprunt = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmprunterLivreId = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxEmprunterAdherentId = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.buttonEmpruntAfficherTout = new System.Windows.Forms.Button();
            this.buttonBibliothecaireRechercher = new System.Windows.Forms.Button();
            this.buttonBibliothecaireAfficherTout = new System.Windows.Forms.Button();
            this.buttonAdherentAfficherTout = new System.Windows.Forms.Button();
            this.buttonAdherentRechercher = new System.Windows.Forms.Button();
            this.buttonLivreAfficherTout = new System.Windows.Forms.Button();
            this.buttonLivreRechercher = new System.Windows.Forms.Button();
            this.LivreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivreTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivreAnneeParution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivreGenreLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivreAuteurNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivreAuteurPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivreEmplacementLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAuteurAfficherTout = new System.Windows.Forms.Button();
            this.buttonAuteurRechercher = new System.Windows.Forms.Button();
            this.tabControlBibliotheque.SuspendLayout();
            this.tabPageIdentification.SuspendLayout();
            this.panelIdentification.SuspendLayout();
            this.tabPageBibliothecaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBibliothecaire)).BeginInit();
            this.tabPageAdherent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdherent)).BeginInit();
            this.tabPageLivre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivre)).BeginInit();
            this.tabPageAuteur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuteur)).BeginInit();
            this.tabPageEmprunt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprunter)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(48, 31);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLogin.TabIndex = 0;
            this.TextBoxLogin.Text = "admin";
            this.TextBoxLogin.Enter += new System.EventHandler(this.TextBoxIdentification_Enter);
            this.TextBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLogin_keyPress);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(3, 34);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(39, 13);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Login :";
            this.LabelLogin.Click += new System.EventHandler(this.LabelLogin_click);
            // 
            // LabelPass
            // 
            this.LabelPass.AutoSize = true;
            this.LabelPass.Location = new System.Drawing.Point(3, 73);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(36, 13);
            this.LabelPass.TabIndex = 3;
            this.LabelPass.Text = "Pass :";
            this.LabelPass.Click += new System.EventHandler(this.LabelPass_click);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(48, 70);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '*';
            this.TextBoxPass.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPass.TabIndex = 1;
            this.TextBoxPass.Text = "admin";
            this.TextBoxPass.Enter += new System.EventHandler(this.TextBoxIdentification_Enter);
            this.TextBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPass_keyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Veuillez saisir vos identifiants :";
            // 
            // ButtonIdentificationValidate
            // 
            this.ButtonIdentificationValidate.Location = new System.Drawing.Point(48, 97);
            this.ButtonIdentificationValidate.Name = "ButtonIdentificationValidate";
            this.ButtonIdentificationValidate.Size = new System.Drawing.Size(75, 23);
            this.ButtonIdentificationValidate.TabIndex = 2;
            this.ButtonIdentificationValidate.Text = "Valider";
            this.ButtonIdentificationValidate.UseVisualStyleBackColor = true;
            this.ButtonIdentificationValidate.Click += new System.EventHandler(this.ButtonIdentificationValidate_Click);
            // 
            // tabControlBibliotheque
            // 
            this.tabControlBibliotheque.Controls.Add(this.tabPageIdentification);
            this.tabControlBibliotheque.Controls.Add(this.tabPageBibliothecaire);
            this.tabControlBibliotheque.Controls.Add(this.tabPageAdherent);
            this.tabControlBibliotheque.Controls.Add(this.tabPageLivre);
            this.tabControlBibliotheque.Controls.Add(this.tabPageAuteur);
            this.tabControlBibliotheque.Controls.Add(this.tabPageEmprunt);
            this.tabControlBibliotheque.Location = new System.Drawing.Point(2, 1);
            this.tabControlBibliotheque.Name = "tabControlBibliotheque";
            this.tabControlBibliotheque.SelectedIndex = 0;
            this.tabControlBibliotheque.Size = new System.Drawing.Size(886, 591);
            this.tabControlBibliotheque.TabIndex = 9;
            // 
            // tabPageIdentification
            // 
            this.tabPageIdentification.Controls.Add(this.panelIdentification);
            this.tabPageIdentification.Location = new System.Drawing.Point(4, 22);
            this.tabPageIdentification.Name = "tabPageIdentification";
            this.tabPageIdentification.Size = new System.Drawing.Size(878, 565);
            this.tabPageIdentification.TabIndex = 0;
            this.tabPageIdentification.Text = "Identification";
            this.tabPageIdentification.UseVisualStyleBackColor = true;
            // 
            // panelIdentification
            // 
            this.panelIdentification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelIdentification.Controls.Add(this.TextBoxPass);
            this.panelIdentification.Controls.Add(this.label1);
            this.panelIdentification.Controls.Add(this.LabelPass);
            this.panelIdentification.Controls.Add(this.ButtonIdentificationValidate);
            this.panelIdentification.Controls.Add(this.LabelLogin);
            this.panelIdentification.Controls.Add(this.TextBoxLogin);
            this.panelIdentification.Location = new System.Drawing.Point(292, 179);
            this.panelIdentification.Name = "panelIdentification";
            this.panelIdentification.Size = new System.Drawing.Size(155, 122);
            this.panelIdentification.TabIndex = 6;
            // 
            // tabPageBibliothecaire
            // 
            this.tabPageBibliothecaire.Controls.Add(this.buttonBibliothecaireAfficherTout);
            this.tabPageBibliothecaire.Controls.Add(this.buttonBibliothecaireRechercher);
            this.tabPageBibliothecaire.Controls.Add(this.dataGridViewBibliothecaire);
            this.tabPageBibliothecaire.Controls.Add(this.buttonBibliothecaireSuppression);
            this.tabPageBibliothecaire.Controls.Add(this.buttonBibliothecaireModification);
            this.tabPageBibliothecaire.Controls.Add(this.buttonBibliothecaireCreation);
            this.tabPageBibliothecaire.Controls.Add(this.label6);
            this.tabPageBibliothecaire.Controls.Add(this.label5);
            this.tabPageBibliothecaire.Controls.Add(this.textBoxBibliothecairePrenom);
            this.tabPageBibliothecaire.Controls.Add(this.textBoxBibliothecaireNom);
            this.tabPageBibliothecaire.Controls.Add(this.textBoxBibliothecairePassword);
            this.tabPageBibliothecaire.Controls.Add(this.textBoxBibliothecaireLogin);
            this.tabPageBibliothecaire.Controls.Add(this.textBoxBibliothecaireId);
            this.tabPageBibliothecaire.Controls.Add(this.label4);
            this.tabPageBibliothecaire.Controls.Add(this.label3);
            this.tabPageBibliothecaire.Controls.Add(this.label2);
            this.tabPageBibliothecaire.Location = new System.Drawing.Point(4, 22);
            this.tabPageBibliothecaire.Name = "tabPageBibliothecaire";
            this.tabPageBibliothecaire.Size = new System.Drawing.Size(878, 565);
            this.tabPageBibliothecaire.TabIndex = 1;
            this.tabPageBibliothecaire.Text = "Bibliothécaire";
            this.tabPageBibliothecaire.UseVisualStyleBackColor = true;
            this.tabPageBibliothecaire.Enter += new System.EventHandler(this.tabPageBibliothecaire_Enter);
            // 
            // dataGridViewBibliothecaire
            // 
            this.dataGridViewBibliothecaire.AllowUserToAddRows = false;
            this.dataGridViewBibliothecaire.AllowUserToDeleteRows = false;
            this.dataGridViewBibliothecaire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBibliothecaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBibliothecaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Login,
            this.Nom,
            this.Prenom});
            this.dataGridViewBibliothecaire.Location = new System.Drawing.Point(200, 9);
            this.dataGridViewBibliothecaire.Name = "dataGridViewBibliothecaire";
            this.dataGridViewBibliothecaire.Size = new System.Drawing.Size(675, 553);
            this.dataGridViewBibliothecaire.TabIndex = 10;
            this.dataGridViewBibliothecaire.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridViewBibliothecaire_CellStateChanged);
            this.dataGridViewBibliothecaire.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewBibliothecaire_RowStateChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // buttonBibliothecaireSuppression
            // 
            this.buttonBibliothecaireSuppression.Location = new System.Drawing.Point(94, 200);
            this.buttonBibliothecaireSuppression.Name = "buttonBibliothecaireSuppression";
            this.buttonBibliothecaireSuppression.Size = new System.Drawing.Size(100, 23);
            this.buttonBibliothecaireSuppression.TabIndex = 7;
            this.buttonBibliothecaireSuppression.Text = "Suppression";
            this.buttonBibliothecaireSuppression.UseVisualStyleBackColor = true;
            this.buttonBibliothecaireSuppression.Click += new System.EventHandler(this.buttonBibliothecaireSuppression_Click);
            // 
            // buttonBibliothecaireModification
            // 
            this.buttonBibliothecaireModification.Location = new System.Drawing.Point(94, 171);
            this.buttonBibliothecaireModification.Name = "buttonBibliothecaireModification";
            this.buttonBibliothecaireModification.Size = new System.Drawing.Size(100, 23);
            this.buttonBibliothecaireModification.TabIndex = 6;
            this.buttonBibliothecaireModification.Text = "Modification";
            this.buttonBibliothecaireModification.UseVisualStyleBackColor = true;
            this.buttonBibliothecaireModification.Click += new System.EventHandler(this.buttonBibliothecaireModification_Click);
            // 
            // buttonBibliothecaireCreation
            // 
            this.buttonBibliothecaireCreation.Location = new System.Drawing.Point(94, 142);
            this.buttonBibliothecaireCreation.Name = "buttonBibliothecaireCreation";
            this.buttonBibliothecaireCreation.Size = new System.Drawing.Size(100, 23);
            this.buttonBibliothecaireCreation.TabIndex = 5;
            this.buttonBibliothecaireCreation.Text = "Creation";
            this.buttonBibliothecaireCreation.UseVisualStyleBackColor = true;
            this.buttonBibliothecaireCreation.Click += new System.EventHandler(this.buttonBibliothecaireCreation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nom";
            // 
            // textBoxBibliothecairePrenom
            // 
            this.textBoxBibliothecairePrenom.Location = new System.Drawing.Point(94, 116);
            this.textBoxBibliothecairePrenom.Name = "textBoxBibliothecairePrenom";
            this.textBoxBibliothecairePrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxBibliothecairePrenom.TabIndex = 4;
            // 
            // textBoxBibliothecaireNom
            // 
            this.textBoxBibliothecaireNom.Location = new System.Drawing.Point(94, 87);
            this.textBoxBibliothecaireNom.Name = "textBoxBibliothecaireNom";
            this.textBoxBibliothecaireNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxBibliothecaireNom.TabIndex = 3;
            // 
            // textBoxBibliothecairePassword
            // 
            this.textBoxBibliothecairePassword.Location = new System.Drawing.Point(94, 61);
            this.textBoxBibliothecairePassword.Name = "textBoxBibliothecairePassword";
            this.textBoxBibliothecairePassword.PasswordChar = '*';
            this.textBoxBibliothecairePassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxBibliothecairePassword.TabIndex = 2;
            // 
            // textBoxBibliothecaireLogin
            // 
            this.textBoxBibliothecaireLogin.Location = new System.Drawing.Point(94, 35);
            this.textBoxBibliothecaireLogin.Name = "textBoxBibliothecaireLogin";
            this.textBoxBibliothecaireLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxBibliothecaireLogin.TabIndex = 1;
            // 
            // textBoxBibliothecaireId
            // 
            this.textBoxBibliothecaireId.Location = new System.Drawing.Point(94, 9);
            this.textBoxBibliothecaireId.Name = "textBoxBibliothecaireId";
            this.textBoxBibliothecaireId.Size = new System.Drawing.Size(100, 20);
            this.textBoxBibliothecaireId.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";
            // 
            // tabPageAdherent
            // 
            this.tabPageAdherent.Controls.Add(this.buttonAdherentAfficherTout);
            this.tabPageAdherent.Controls.Add(this.buttonAdherentRechercher);
            this.tabPageAdherent.Controls.Add(this.dateTimePickerAdherentDateInscr);
            this.tabPageAdherent.Controls.Add(this.dateTimePickerAdherentDateNaiss);
            this.tabPageAdherent.Controls.Add(this.dataGridViewAdherent);
            this.tabPageAdherent.Controls.Add(this.textBoxAdherentEmail);
            this.tabPageAdherent.Controls.Add(this.textBoxAdherentTelephone);
            this.tabPageAdherent.Controls.Add(this.textBoxAdherentCodePostal);
            this.tabPageAdherent.Controls.Add(this.label15);
            this.tabPageAdherent.Controls.Add(this.label14);
            this.tabPageAdherent.Controls.Add(this.label13);
            this.tabPageAdherent.Controls.Add(this.label12);
            this.tabPageAdherent.Controls.Add(this.label10);
            this.tabPageAdherent.Controls.Add(this.buttonAdherentSupp);
            this.tabPageAdherent.Controls.Add(this.buttonAdherentModif);
            this.tabPageAdherent.Controls.Add(this.buttonAdherentCreation);
            this.tabPageAdherent.Controls.Add(this.label7);
            this.tabPageAdherent.Controls.Add(this.label8);
            this.tabPageAdherent.Controls.Add(this.textBoxAdherentAdresse);
            this.tabPageAdherent.Controls.Add(this.textBoxAdherentPrenom);
            this.tabPageAdherent.Controls.Add(this.textBoxAdherentNom);
            this.tabPageAdherent.Controls.Add(this.textBoxAdherentId);
            this.tabPageAdherent.Controls.Add(this.label9);
            this.tabPageAdherent.Controls.Add(this.label11);
            this.tabPageAdherent.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdherent.Name = "tabPageAdherent";
            this.tabPageAdherent.Size = new System.Drawing.Size(878, 565);
            this.tabPageAdherent.TabIndex = 2;
            this.tabPageAdherent.Text = "Adhérent";
            this.tabPageAdherent.UseVisualStyleBackColor = true;
            this.tabPageAdherent.Enter += new System.EventHandler(this.tabPageAdherent_Enter);
            // 
            // dateTimePickerAdherentDateInscr
            // 
            this.dateTimePickerAdherentDateInscr.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerAdherentDateInscr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAdherentDateInscr.Location = new System.Drawing.Point(94, 217);
            this.dateTimePickerAdherentDateInscr.Name = "dateTimePickerAdherentDateInscr";
            this.dateTimePickerAdherentDateInscr.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerAdherentDateInscr.TabIndex = 8;
            // 
            // dateTimePickerAdherentDateNaiss
            // 
            this.dateTimePickerAdherentDateNaiss.CustomFormat = " dd/MM/yyyy";
            this.dateTimePickerAdherentDateNaiss.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAdherentDateNaiss.Location = new System.Drawing.Point(94, 87);
            this.dateTimePickerAdherentDateNaiss.Name = "dateTimePickerAdherentDateNaiss";
            this.dateTimePickerAdherentDateNaiss.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerAdherentDateNaiss.TabIndex = 3;
            // 
            // dataGridViewAdherent
            // 
            this.dataGridViewAdherent.AllowUserToAddRows = false;
            this.dataGridViewAdherent.AllowUserToDeleteRows = false;
            this.dataGridViewAdherent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAdherent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdherent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdherentId,
            this.AdherentNom,
            this.AdherentPrenom,
            this.AdherentDateNaiss,
            this.AdherentAdresse,
            this.AdherentCodePostal,
            this.AdherentTel,
            this.AdherentEmail,
            this.AdherentDateInscr});
            this.dataGridViewAdherent.Location = new System.Drawing.Point(200, 5);
            this.dataGridViewAdherent.Name = "dataGridViewAdherent";
            this.dataGridViewAdherent.Size = new System.Drawing.Size(675, 557);
            this.dataGridViewAdherent.TabIndex = 14;
            this.dataGridViewAdherent.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridViewAdherent_CellStateChanged);
            this.dataGridViewAdherent.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewAdherent_RowStateChanged);
            // 
            // AdherentId
            // 
            this.AdherentId.HeaderText = "Id";
            this.AdherentId.Name = "AdherentId";
            // 
            // AdherentNom
            // 
            this.AdherentNom.HeaderText = "Nom";
            this.AdherentNom.Name = "AdherentNom";
            // 
            // AdherentPrenom
            // 
            this.AdherentPrenom.HeaderText = "Prénom";
            this.AdherentPrenom.Name = "AdherentPrenom";
            // 
            // AdherentDateNaiss
            // 
            this.AdherentDateNaiss.HeaderText = "Date de naissance";
            this.AdherentDateNaiss.Name = "AdherentDateNaiss";
            // 
            // AdherentAdresse
            // 
            this.AdherentAdresse.HeaderText = "Adresse";
            this.AdherentAdresse.Name = "AdherentAdresse";
            // 
            // AdherentCodePostal
            // 
            this.AdherentCodePostal.HeaderText = "Code Postal";
            this.AdherentCodePostal.Name = "AdherentCodePostal";
            // 
            // AdherentTel
            // 
            this.AdherentTel.HeaderText = "Téléphone";
            this.AdherentTel.Name = "AdherentTel";
            // 
            // AdherentEmail
            // 
            this.AdherentEmail.HeaderText = "Email";
            this.AdherentEmail.Name = "AdherentEmail";
            // 
            // AdherentDateInscr
            // 
            this.AdherentDateInscr.HeaderText = "Date d\'inscription";
            this.AdherentDateInscr.Name = "AdherentDateInscr";
            // 
            // textBoxAdherentEmail
            // 
            this.textBoxAdherentEmail.Location = new System.Drawing.Point(94, 191);
            this.textBoxAdherentEmail.Name = "textBoxAdherentEmail";
            this.textBoxAdherentEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdherentEmail.TabIndex = 7;
            // 
            // textBoxAdherentTelephone
            // 
            this.textBoxAdherentTelephone.Location = new System.Drawing.Point(94, 165);
            this.textBoxAdherentTelephone.Name = "textBoxAdherentTelephone";
            this.textBoxAdherentTelephone.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdherentTelephone.TabIndex = 6;
            // 
            // textBoxAdherentCodePostal
            // 
            this.textBoxAdherentCodePostal.Location = new System.Drawing.Point(94, 139);
            this.textBoxAdherentCodePostal.Name = "textBoxAdherentCodePostal";
            this.textBoxAdherentCodePostal.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdherentCodePostal.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Date Inscription";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Telephone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Code Postal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Nom";
            // 
            // buttonAdherentSupp
            // 
            this.buttonAdherentSupp.Location = new System.Drawing.Point(94, 301);
            this.buttonAdherentSupp.Name = "buttonAdherentSupp";
            this.buttonAdherentSupp.Size = new System.Drawing.Size(100, 23);
            this.buttonAdherentSupp.TabIndex = 11;
            this.buttonAdherentSupp.Text = "Suppression";
            this.buttonAdherentSupp.UseVisualStyleBackColor = true;
            this.buttonAdherentSupp.Click += new System.EventHandler(this.buttonAdherentSupp_Click);
            // 
            // buttonAdherentModif
            // 
            this.buttonAdherentModif.Location = new System.Drawing.Point(94, 272);
            this.buttonAdherentModif.Name = "buttonAdherentModif";
            this.buttonAdherentModif.Size = new System.Drawing.Size(100, 23);
            this.buttonAdherentModif.TabIndex = 10;
            this.buttonAdherentModif.Text = "Modification";
            this.buttonAdherentModif.UseVisualStyleBackColor = true;
            this.buttonAdherentModif.Click += new System.EventHandler(this.buttonAdherentModif_Click);
            // 
            // buttonAdherentCreation
            // 
            this.buttonAdherentCreation.Location = new System.Drawing.Point(94, 243);
            this.buttonAdherentCreation.Name = "buttonAdherentCreation";
            this.buttonAdherentCreation.Size = new System.Drawing.Size(100, 23);
            this.buttonAdherentCreation.TabIndex = 9;
            this.buttonAdherentCreation.Text = "Creation";
            this.buttonAdherentCreation.UseVisualStyleBackColor = true;
            this.buttonAdherentCreation.Click += new System.EventHandler(this.buttonAdherentCreation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Adresse";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Date Naiss";
            // 
            // textBoxAdherentAdresse
            // 
            this.textBoxAdherentAdresse.Location = new System.Drawing.Point(94, 113);
            this.textBoxAdherentAdresse.Name = "textBoxAdherentAdresse";
            this.textBoxAdherentAdresse.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdherentAdresse.TabIndex = 4;
            // 
            // textBoxAdherentPrenom
            // 
            this.textBoxAdherentPrenom.Location = new System.Drawing.Point(94, 61);
            this.textBoxAdherentPrenom.Name = "textBoxAdherentPrenom";
            this.textBoxAdherentPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdherentPrenom.TabIndex = 2;
            // 
            // textBoxAdherentNom
            // 
            this.textBoxAdherentNom.Location = new System.Drawing.Point(94, 35);
            this.textBoxAdherentNom.Name = "textBoxAdherentNom";
            this.textBoxAdherentNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdherentNom.TabIndex = 1;
            // 
            // textBoxAdherentId
            // 
            this.textBoxAdherentId.Location = new System.Drawing.Point(94, 9);
            this.textBoxAdherentId.Name = "textBoxAdherentId";
            this.textBoxAdherentId.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdherentId.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Prenom";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Id";
            // 
            // tabPageLivre
            // 
            this.tabPageLivre.Controls.Add(this.buttonLivreAfficherTout);
            this.tabPageLivre.Controls.Add(this.buttonLivreRechercher);
            this.tabPageLivre.Controls.Add(this.comboBoxLivreAuteurPrenom);
            this.tabPageLivre.Controls.Add(this.label21);
            this.tabPageLivre.Controls.Add(this.comboBoxLivreEmplacement);
            this.tabPageLivre.Controls.Add(this.comboBoxLivreGenre);
            this.tabPageLivre.Controls.Add(this.comboBoxLivreAuteurNom);
            this.tabPageLivre.Controls.Add(this.label20);
            this.tabPageLivre.Controls.Add(this.label19);
            this.tabPageLivre.Controls.Add(this.dataGridViewLivre);
            this.tabPageLivre.Controls.Add(this.buttonLivreSuppression);
            this.tabPageLivre.Controls.Add(this.buttonLivreModification);
            this.tabPageLivre.Controls.Add(this.buttonLivreCreation);
            this.tabPageLivre.Controls.Add(this.dateTimePickerLivreAnneeParution);
            this.tabPageLivre.Controls.Add(this.label18);
            this.tabPageLivre.Controls.Add(this.label17);
            this.tabPageLivre.Controls.Add(this.label16);
            this.tabPageLivre.Controls.Add(this.textBoxLivreTitre);
            this.tabPageLivre.Controls.Add(this.textBoxLivreId);
            this.tabPageLivre.Location = new System.Drawing.Point(4, 22);
            this.tabPageLivre.Name = "tabPageLivre";
            this.tabPageLivre.Size = new System.Drawing.Size(878, 565);
            this.tabPageLivre.TabIndex = 3;
            this.tabPageLivre.Text = "Livre";
            this.tabPageLivre.UseVisualStyleBackColor = true;
            this.tabPageLivre.Enter += new System.EventHandler(this.tabPageLivre_Enter);
            // 
            // comboBoxLivreAuteurPrenom
            // 
            this.comboBoxLivreAuteurPrenom.FormattingEnabled = true;
            this.comboBoxLivreAuteurPrenom.Location = new System.Drawing.Point(124, 114);
            this.comboBoxLivreAuteurPrenom.Name = "comboBoxLivreAuteurPrenom";
            this.comboBoxLivreAuteurPrenom.Size = new System.Drawing.Size(70, 21);
            this.comboBoxLivreAuteurPrenom.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Emplacement";
            // 
            // comboBoxLivreEmplacement
            // 
            this.comboBoxLivreEmplacement.FormattingEnabled = true;
            this.comboBoxLivreEmplacement.Location = new System.Drawing.Point(89, 141);
            this.comboBoxLivreEmplacement.Name = "comboBoxLivreEmplacement";
            this.comboBoxLivreEmplacement.Size = new System.Drawing.Size(105, 21);
            this.comboBoxLivreEmplacement.TabIndex = 6;
            // 
            // comboBoxLivreGenre
            // 
            this.comboBoxLivreGenre.FormattingEnabled = true;
            this.comboBoxLivreGenre.Location = new System.Drawing.Point(89, 87);
            this.comboBoxLivreGenre.Name = "comboBoxLivreGenre";
            this.comboBoxLivreGenre.Size = new System.Drawing.Size(105, 21);
            this.comboBoxLivreGenre.TabIndex = 3;
            // 
            // comboBoxLivreAuteurNom
            // 
            this.comboBoxLivreAuteurNom.FormattingEnabled = true;
            this.comboBoxLivreAuteurNom.Location = new System.Drawing.Point(48, 114);
            this.comboBoxLivreAuteurNom.Name = "comboBoxLivreAuteurNom";
            this.comboBoxLivreAuteurNom.Size = new System.Drawing.Size(70, 21);
            this.comboBoxLivreAuteurNom.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Genre";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 117);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Auteur";
            // 
            // dataGridViewLivre
            // 
            this.dataGridViewLivre.AllowUserToAddRows = false;
            this.dataGridViewLivre.AllowUserToDeleteRows = false;
            this.dataGridViewLivre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LivreId,
            this.LivreTitre,
            this.LivreAnneeParution,
            this.LivreGenreLibelle,
            this.LivreAuteurNom,
            this.LivreAuteurPrenom,
            this.LivreEmplacementLibelle});
            this.dataGridViewLivre.Location = new System.Drawing.Point(200, 9);
            this.dataGridViewLivre.Name = "dataGridViewLivre";
            this.dataGridViewLivre.Size = new System.Drawing.Size(675, 553);
            this.dataGridViewLivre.TabIndex = 12;
            this.dataGridViewLivre.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridViewLivre_CellStateChanged);
            this.dataGridViewLivre.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewLivre_RowStateChanged);
            // 
            // buttonLivreSuppression
            // 
            this.buttonLivreSuppression.Location = new System.Drawing.Point(94, 226);
            this.buttonLivreSuppression.Name = "buttonLivreSuppression";
            this.buttonLivreSuppression.Size = new System.Drawing.Size(100, 23);
            this.buttonLivreSuppression.TabIndex = 9;
            this.buttonLivreSuppression.Text = "Suppression";
            this.buttonLivreSuppression.UseVisualStyleBackColor = true;
            this.buttonLivreSuppression.Click += new System.EventHandler(this.buttonLivreSuppression_Click);
            // 
            // buttonLivreModification
            // 
            this.buttonLivreModification.Location = new System.Drawing.Point(94, 197);
            this.buttonLivreModification.Name = "buttonLivreModification";
            this.buttonLivreModification.Size = new System.Drawing.Size(100, 23);
            this.buttonLivreModification.TabIndex = 8;
            this.buttonLivreModification.Text = "Modification";
            this.buttonLivreModification.UseVisualStyleBackColor = true;
            this.buttonLivreModification.Click += new System.EventHandler(this.buttonLivreModification_Click);
            // 
            // buttonLivreCreation
            // 
            this.buttonLivreCreation.Location = new System.Drawing.Point(94, 168);
            this.buttonLivreCreation.Name = "buttonLivreCreation";
            this.buttonLivreCreation.Size = new System.Drawing.Size(100, 23);
            this.buttonLivreCreation.TabIndex = 7;
            this.buttonLivreCreation.Text = "Creation";
            this.buttonLivreCreation.UseVisualStyleBackColor = true;
            this.buttonLivreCreation.Click += new System.EventHandler(this.buttonLivreCreation_Click);
            // 
            // dateTimePickerLivreAnneeParution
            // 
            this.dateTimePickerLivreAnneeParution.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerLivreAnneeParution.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerLivreAnneeParution.Location = new System.Drawing.Point(94, 61);
            this.dateTimePickerLivreAnneeParution.Name = "dateTimePickerLivreAnneeParution";
            this.dateTimePickerLivreAnneeParution.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerLivreAnneeParution.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Année Parution";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Titre";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Id";
            // 
            // textBoxLivreTitre
            // 
            this.textBoxLivreTitre.Location = new System.Drawing.Point(94, 35);
            this.textBoxLivreTitre.Name = "textBoxLivreTitre";
            this.textBoxLivreTitre.Size = new System.Drawing.Size(100, 20);
            this.textBoxLivreTitre.TabIndex = 1;
            // 
            // textBoxLivreId
            // 
            this.textBoxLivreId.Location = new System.Drawing.Point(94, 9);
            this.textBoxLivreId.Name = "textBoxLivreId";
            this.textBoxLivreId.Size = new System.Drawing.Size(100, 20);
            this.textBoxLivreId.TabIndex = 0;
            // 
            // tabPageAuteur
            // 
            this.tabPageAuteur.Controls.Add(this.buttonAuteurAfficherTout);
            this.tabPageAuteur.Controls.Add(this.buttonAuteurRechercher);
            this.tabPageAuteur.Controls.Add(this.dataGridViewAuteur);
            this.tabPageAuteur.Controls.Add(this.buttonAuteurSuppression);
            this.tabPageAuteur.Controls.Add(this.buttonAuteurModification);
            this.tabPageAuteur.Controls.Add(this.buttonAuteurCreation);
            this.tabPageAuteur.Controls.Add(this.textBoxAuteurPrenom);
            this.tabPageAuteur.Controls.Add(this.textBoxAuteurNom);
            this.tabPageAuteur.Controls.Add(this.textBoxAuteurId);
            this.tabPageAuteur.Controls.Add(this.label24);
            this.tabPageAuteur.Controls.Add(this.label23);
            this.tabPageAuteur.Controls.Add(this.label22);
            this.tabPageAuteur.Location = new System.Drawing.Point(4, 22);
            this.tabPageAuteur.Name = "tabPageAuteur";
            this.tabPageAuteur.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuteur.Size = new System.Drawing.Size(878, 565);
            this.tabPageAuteur.TabIndex = 4;
            this.tabPageAuteur.Text = "Auteur";
            this.tabPageAuteur.UseVisualStyleBackColor = true;
            this.tabPageAuteur.Enter += new System.EventHandler(this.tabPageAuteur_Enter);
            // 
            // dataGridViewAuteur
            // 
            this.dataGridViewAuteur.AllowUserToAddRows = false;
            this.dataGridViewAuteur.AllowUserToDeleteRows = false;
            this.dataGridViewAuteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAuteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuteurID,
            this.AuteurNom,
            this.AuteurPrenom});
            this.dataGridViewAuteur.Location = new System.Drawing.Point(200, 9);
            this.dataGridViewAuteur.Name = "dataGridViewAuteur";
            this.dataGridViewAuteur.Size = new System.Drawing.Size(675, 553);
            this.dataGridViewAuteur.TabIndex = 9;
            this.dataGridViewAuteur.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridViewAuteur_CellStateChanged);
            this.dataGridViewAuteur.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewAuteur_RowStateChanged);
            // 
            // AuteurID
            // 
            this.AuteurID.HeaderText = "ID";
            this.AuteurID.Name = "AuteurID";
            // 
            // AuteurNom
            // 
            this.AuteurNom.HeaderText = "Nom";
            this.AuteurNom.Name = "AuteurNom";
            // 
            // AuteurPrenom
            // 
            this.AuteurPrenom.HeaderText = "Prenom";
            this.AuteurPrenom.Name = "AuteurPrenom";
            // 
            // buttonAuteurSuppression
            // 
            this.buttonAuteurSuppression.Location = new System.Drawing.Point(94, 145);
            this.buttonAuteurSuppression.Name = "buttonAuteurSuppression";
            this.buttonAuteurSuppression.Size = new System.Drawing.Size(100, 23);
            this.buttonAuteurSuppression.TabIndex = 8;
            this.buttonAuteurSuppression.Text = "Suppression";
            this.buttonAuteurSuppression.UseVisualStyleBackColor = true;
            this.buttonAuteurSuppression.Click += new System.EventHandler(this.buttonAuteurSuppression_Click);
            // 
            // buttonAuteurModification
            // 
            this.buttonAuteurModification.Location = new System.Drawing.Point(94, 116);
            this.buttonAuteurModification.Name = "buttonAuteurModification";
            this.buttonAuteurModification.Size = new System.Drawing.Size(100, 23);
            this.buttonAuteurModification.TabIndex = 7;
            this.buttonAuteurModification.Text = "Modification";
            this.buttonAuteurModification.UseVisualStyleBackColor = true;
            this.buttonAuteurModification.Click += new System.EventHandler(this.buttonAuteurModification_Click);
            // 
            // buttonAuteurCreation
            // 
            this.buttonAuteurCreation.Location = new System.Drawing.Point(94, 87);
            this.buttonAuteurCreation.Name = "buttonAuteurCreation";
            this.buttonAuteurCreation.Size = new System.Drawing.Size(100, 23);
            this.buttonAuteurCreation.TabIndex = 6;
            this.buttonAuteurCreation.Text = "Creation";
            this.buttonAuteurCreation.UseVisualStyleBackColor = true;
            this.buttonAuteurCreation.Click += new System.EventHandler(this.buttonAuteurCreation_Click);
            // 
            // textBoxAuteurPrenom
            // 
            this.textBoxAuteurPrenom.Location = new System.Drawing.Point(94, 61);
            this.textBoxAuteurPrenom.Name = "textBoxAuteurPrenom";
            this.textBoxAuteurPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuteurPrenom.TabIndex = 5;
            // 
            // textBoxAuteurNom
            // 
            this.textBoxAuteurNom.Location = new System.Drawing.Point(94, 35);
            this.textBoxAuteurNom.Name = "textBoxAuteurNom";
            this.textBoxAuteurNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuteurNom.TabIndex = 4;
            // 
            // textBoxAuteurId
            // 
            this.textBoxAuteurId.Location = new System.Drawing.Point(94, 9);
            this.textBoxAuteurId.Name = "textBoxAuteurId";
            this.textBoxAuteurId.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuteurId.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 64);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "prenom";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 38);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "nom";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 12);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Id";
            // 
            // tabPageEmprunt
            // 
            this.tabPageEmprunt.Controls.Add(this.buttonEmpruntAfficherTout);
            this.tabPageEmprunt.Controls.Add(this.buttonListeRetards);
            this.tabPageEmprunt.Controls.Add(this.dataGridViewEmprunter);
            this.tabPageEmprunt.Controls.Add(this.buttonRendre);
            this.tabPageEmprunt.Controls.Add(this.buttonEmprunt);
            this.tabPageEmprunt.Controls.Add(this.dateTimePickerDateRetour);
            this.tabPageEmprunt.Controls.Add(this.label28);
            this.tabPageEmprunt.Controls.Add(this.label27);
            this.tabPageEmprunt.Controls.Add(this.dateTimePickerDateEmprunt);
            this.tabPageEmprunt.Controls.Add(this.textBoxEmprunterLivreId);
            this.tabPageEmprunt.Controls.Add(this.label26);
            this.tabPageEmprunt.Controls.Add(this.textBoxEmprunterAdherentId);
            this.tabPageEmprunt.Controls.Add(this.label25);
            this.tabPageEmprunt.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmprunt.Name = "tabPageEmprunt";
            this.tabPageEmprunt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmprunt.Size = new System.Drawing.Size(878, 565);
            this.tabPageEmprunt.TabIndex = 5;
            this.tabPageEmprunt.Text = "Emprunt";
            this.tabPageEmprunt.UseVisualStyleBackColor = true;
            this.tabPageEmprunt.Enter += new System.EventHandler(this.tabPageEmprunt_Enter);
            // 
            // buttonListeRetards
            // 
            this.buttonListeRetards.Location = new System.Drawing.Point(94, 200);
            this.buttonListeRetards.Name = "buttonListeRetards";
            this.buttonListeRetards.Size = new System.Drawing.Size(100, 23);
            this.buttonListeRetards.TabIndex = 6;
            this.buttonListeRetards.Text = "Liste des retards";
            this.buttonListeRetards.UseVisualStyleBackColor = true;
            this.buttonListeRetards.Click += new System.EventHandler(this.buttonListeRetards_Click);
            // 
            // dataGridViewEmprunter
            // 
            this.dataGridViewEmprunter.AllowUserToAddRows = false;
            this.dataGridViewEmprunter.AllowUserToDeleteRows = false;
            this.dataGridViewEmprunter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmprunter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmprunter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAdherent,
            this.NomAdherent,
            this.PrenomAdherent,
            this.IdLivre,
            this.TitreLivre,
            this.DateEmprunt,
            this.DateRetour});
            this.dataGridViewEmprunter.Location = new System.Drawing.Point(200, 9);
            this.dataGridViewEmprunter.Name = "dataGridViewEmprunter";
            this.dataGridViewEmprunter.Size = new System.Drawing.Size(675, 553);
            this.dataGridViewEmprunter.TabIndex = 7;
            // 
            // IdAdherent
            // 
            this.IdAdherent.HeaderText = "ID Adherent";
            this.IdAdherent.Name = "IdAdherent";
            // 
            // NomAdherent
            // 
            this.NomAdherent.HeaderText = "Nom Adherent";
            this.NomAdherent.Name = "NomAdherent";
            // 
            // PrenomAdherent
            // 
            this.PrenomAdherent.HeaderText = "Prenom Adherent";
            this.PrenomAdherent.Name = "PrenomAdherent";
            // 
            // IdLivre
            // 
            this.IdLivre.HeaderText = "ID Livre";
            this.IdLivre.Name = "IdLivre";
            // 
            // TitreLivre
            // 
            this.TitreLivre.HeaderText = "Titre";
            this.TitreLivre.Name = "TitreLivre";
            // 
            // DateEmprunt
            // 
            this.DateEmprunt.HeaderText = "Date Emprunt";
            this.DateEmprunt.Name = "DateEmprunt";
            // 
            // DateRetour
            // 
            this.DateRetour.HeaderText = "Date Retour";
            this.DateRetour.Name = "DateRetour";
            // 
            // buttonRendre
            // 
            this.buttonRendre.Location = new System.Drawing.Point(94, 142);
            this.buttonRendre.Name = "buttonRendre";
            this.buttonRendre.Size = new System.Drawing.Size(100, 23);
            this.buttonRendre.TabIndex = 5;
            this.buttonRendre.Text = "Rendre";
            this.buttonRendre.UseVisualStyleBackColor = true;
            this.buttonRendre.Click += new System.EventHandler(this.buttonRendre_Click);
            // 
            // buttonEmprunt
            // 
            this.buttonEmprunt.Location = new System.Drawing.Point(94, 113);
            this.buttonEmprunt.Name = "buttonEmprunt";
            this.buttonEmprunt.Size = new System.Drawing.Size(100, 23);
            this.buttonEmprunt.TabIndex = 4;
            this.buttonEmprunt.Text = "Emprunter";
            this.buttonEmprunt.UseVisualStyleBackColor = true;
            this.buttonEmprunt.Click += new System.EventHandler(this.buttonEmprunt_Click);
            // 
            // dateTimePickerDateRetour
            // 
            this.dateTimePickerDateRetour.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDateRetour.Enabled = false;
            this.dateTimePickerDateRetour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateRetour.Location = new System.Drawing.Point(94, 87);
            this.dateTimePickerDateRetour.Name = "dateTimePickerDateRetour";
            this.dateTimePickerDateRetour.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDateRetour.TabIndex = 3;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 90);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(65, 13);
            this.label28.TabIndex = 6;
            this.label28.Text = "Date Retour";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 64);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(75, 13);
            this.label27.TabIndex = 5;
            this.label27.Text = "Date  Emprunt";
            // 
            // dateTimePickerDateEmprunt
            // 
            this.dateTimePickerDateEmprunt.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDateEmprunt.Enabled = false;
            this.dateTimePickerDateEmprunt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateEmprunt.Location = new System.Drawing.Point(94, 61);
            this.dateTimePickerDateEmprunt.Name = "dateTimePickerDateEmprunt";
            this.dateTimePickerDateEmprunt.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDateEmprunt.TabIndex = 2;
            // 
            // textBoxEmprunterLivreId
            // 
            this.textBoxEmprunterLivreId.Location = new System.Drawing.Point(94, 35);
            this.textBoxEmprunterLivreId.Name = "textBoxEmprunterLivreId";
            this.textBoxEmprunterLivreId.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmprunterLivreId.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 38);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "ID Livre";
            // 
            // textBoxEmprunterAdherentId
            // 
            this.textBoxEmprunterAdherentId.Location = new System.Drawing.Point(94, 9);
            this.textBoxEmprunterAdherentId.Name = "textBoxEmprunterAdherentId";
            this.textBoxEmprunterAdherentId.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmprunterAdherentId.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "ID Adherent";
            // 
            // buttonEmpruntAfficherTout
            // 
            this.buttonEmpruntAfficherTout.Location = new System.Drawing.Point(94, 171);
            this.buttonEmpruntAfficherTout.Name = "buttonEmpruntAfficherTout";
            this.buttonEmpruntAfficherTout.Size = new System.Drawing.Size(100, 23);
            this.buttonEmpruntAfficherTout.TabIndex = 8;
            this.buttonEmpruntAfficherTout.Text = "Afficher tout";
            this.buttonEmpruntAfficherTout.UseVisualStyleBackColor = true;
            this.buttonEmpruntAfficherTout.Click += new System.EventHandler(this.buttonEmpruntAfficherTout_Click);
            // 
            // buttonBibliothecaireRechercher
            // 
            this.buttonBibliothecaireRechercher.Location = new System.Drawing.Point(94, 229);
            this.buttonBibliothecaireRechercher.Name = "buttonBibliothecaireRechercher";
            this.buttonBibliothecaireRechercher.Size = new System.Drawing.Size(100, 23);
            this.buttonBibliothecaireRechercher.TabIndex = 8;
            this.buttonBibliothecaireRechercher.Text = "Rechercher";
            this.buttonBibliothecaireRechercher.UseVisualStyleBackColor = true;
            this.buttonBibliothecaireRechercher.Click += new System.EventHandler(this.buttonBibliothecaireRechercher_Click);
            // 
            // buttonBibliothecaireAfficherTout
            // 
            this.buttonBibliothecaireAfficherTout.Location = new System.Drawing.Point(94, 258);
            this.buttonBibliothecaireAfficherTout.Name = "buttonBibliothecaireAfficherTout";
            this.buttonBibliothecaireAfficherTout.Size = new System.Drawing.Size(100, 23);
            this.buttonBibliothecaireAfficherTout.TabIndex = 9;
            this.buttonBibliothecaireAfficherTout.Text = "Afficher tout";
            this.buttonBibliothecaireAfficherTout.UseVisualStyleBackColor = true;
            this.buttonBibliothecaireAfficherTout.Click += new System.EventHandler(this.buttonBibliothecaireAfficherTout_Click);
            // 
            // buttonAdherentAfficherTout
            // 
            this.buttonAdherentAfficherTout.Location = new System.Drawing.Point(94, 359);
            this.buttonAdherentAfficherTout.Name = "buttonAdherentAfficherTout";
            this.buttonAdherentAfficherTout.Size = new System.Drawing.Size(100, 23);
            this.buttonAdherentAfficherTout.TabIndex = 13;
            this.buttonAdherentAfficherTout.Text = "Afficher tout";
            this.buttonAdherentAfficherTout.UseVisualStyleBackColor = true;
            this.buttonAdherentAfficherTout.Visible = false;
            this.buttonAdherentAfficherTout.Click += new System.EventHandler(this.buttonAdherentAfficherTout_Click);
            // 
            // buttonAdherentRechercher
            // 
            this.buttonAdherentRechercher.Location = new System.Drawing.Point(94, 330);
            this.buttonAdherentRechercher.Name = "buttonAdherentRechercher";
            this.buttonAdherentRechercher.Size = new System.Drawing.Size(100, 23);
            this.buttonAdherentRechercher.TabIndex = 12;
            this.buttonAdherentRechercher.Text = "Rechercher";
            this.buttonAdherentRechercher.UseVisualStyleBackColor = true;
            this.buttonAdherentRechercher.Click += new System.EventHandler(this.buttonAdherentRechercher_Click);
            // 
            // buttonLivreAfficherTout
            // 
            this.buttonLivreAfficherTout.Location = new System.Drawing.Point(94, 284);
            this.buttonLivreAfficherTout.Name = "buttonLivreAfficherTout";
            this.buttonLivreAfficherTout.Size = new System.Drawing.Size(100, 23);
            this.buttonLivreAfficherTout.TabIndex = 11;
            this.buttonLivreAfficherTout.Text = "Afficher tout";
            this.buttonLivreAfficherTout.UseVisualStyleBackColor = true;
            this.buttonLivreAfficherTout.Visible = false;
            this.buttonLivreAfficherTout.Click += new System.EventHandler(this.buttonLivreAfficherTout_Click);
            // 
            // buttonLivreRechercher
            // 
            this.buttonLivreRechercher.Location = new System.Drawing.Point(94, 255);
            this.buttonLivreRechercher.Name = "buttonLivreRechercher";
            this.buttonLivreRechercher.Size = new System.Drawing.Size(100, 23);
            this.buttonLivreRechercher.TabIndex = 10;
            this.buttonLivreRechercher.Text = "Rechercher";
            this.buttonLivreRechercher.UseVisualStyleBackColor = true;
            this.buttonLivreRechercher.Click += new System.EventHandler(this.buttonLivreRechercher_Click);
            // 
            // LivreId
            // 
            this.LivreId.HeaderText = "Id";
            this.LivreId.Name = "LivreId";
            // 
            // LivreTitre
            // 
            this.LivreTitre.HeaderText = "Titre";
            this.LivreTitre.Name = "LivreTitre";
            // 
            // LivreAnneeParution
            // 
            this.LivreAnneeParution.HeaderText = "Annee Parution";
            this.LivreAnneeParution.Name = "LivreAnneeParution";
            // 
            // LivreGenreLibelle
            // 
            this.LivreGenreLibelle.HeaderText = "Genre";
            this.LivreGenreLibelle.Name = "LivreGenreLibelle";
            // 
            // LivreAuteurNom
            // 
            this.LivreAuteurNom.HeaderText = "Nom";
            this.LivreAuteurNom.Name = "LivreAuteurNom";
            // 
            // LivreAuteurPrenom
            // 
            this.LivreAuteurPrenom.HeaderText = "Prénom";
            this.LivreAuteurPrenom.Name = "LivreAuteurPrenom";
            // 
            // LivreEmplacementLibelle
            // 
            this.LivreEmplacementLibelle.HeaderText = "Emplacement";
            this.LivreEmplacementLibelle.Name = "LivreEmplacementLibelle";
            // 
            // buttonAuteurAfficherTout
            // 
            this.buttonAuteurAfficherTout.Location = new System.Drawing.Point(94, 203);
            this.buttonAuteurAfficherTout.Name = "buttonAuteurAfficherTout";
            this.buttonAuteurAfficherTout.Size = new System.Drawing.Size(100, 23);
            this.buttonAuteurAfficherTout.TabIndex = 13;
            this.buttonAuteurAfficherTout.Text = "Afficher tout";
            this.buttonAuteurAfficherTout.UseVisualStyleBackColor = true;
            this.buttonAuteurAfficherTout.Visible = false;
            this.buttonAuteurAfficherTout.Click += new System.EventHandler(this.buttonAuteurAfficherTout_Click);
            // 
            // buttonAuteurRechercher
            // 
            this.buttonAuteurRechercher.Location = new System.Drawing.Point(94, 174);
            this.buttonAuteurRechercher.Name = "buttonAuteurRechercher";
            this.buttonAuteurRechercher.Size = new System.Drawing.Size(100, 23);
            this.buttonAuteurRechercher.TabIndex = 12;
            this.buttonAuteurRechercher.Text = "Rechercher";
            this.buttonAuteurRechercher.UseVisualStyleBackColor = true;
            this.buttonAuteurRechercher.Click += new System.EventHandler(this.buttonAuteurRechercher_Click);
            // 
            // FormBiBliotheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 602);
            this.Controls.Add(this.tabControlBibliotheque);
            this.Name = "FormBiBliotheque";
            this.Text = "Bienvenue à la bibliothèque";
            this.tabControlBibliotheque.ResumeLayout(false);
            this.tabPageIdentification.ResumeLayout(false);
            this.panelIdentification.ResumeLayout(false);
            this.panelIdentification.PerformLayout();
            this.tabPageBibliothecaire.ResumeLayout(false);
            this.tabPageBibliothecaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBibliothecaire)).EndInit();
            this.tabPageAdherent.ResumeLayout(false);
            this.tabPageAdherent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdherent)).EndInit();
            this.tabPageLivre.ResumeLayout(false);
            this.tabPageLivre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivre)).EndInit();
            this.tabPageAuteur.ResumeLayout(false);
            this.tabPageAuteur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuteur)).EndInit();
            this.tabPageEmprunt.ResumeLayout(false);
            this.tabPageEmprunt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprunter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonIdentificationValidate;
        private System.Windows.Forms.TabControl tabControlBibliotheque;
        private System.Windows.Forms.TabPage tabPageIdentification;
        private System.Windows.Forms.TabPage tabPageBibliothecaire;
        private System.Windows.Forms.TabPage tabPageAdherent;
        private System.Windows.Forms.TabPage tabPageLivre;
        private System.Windows.Forms.DataGridView dataGridViewBibliothecaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.Button buttonBibliothecaireSuppression;
        private System.Windows.Forms.Button buttonBibliothecaireModification;
        private System.Windows.Forms.Button buttonBibliothecaireCreation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBibliothecairePrenom;
        private System.Windows.Forms.TextBox textBoxBibliothecaireNom;
        private System.Windows.Forms.TextBox textBoxBibliothecairePassword;
        private System.Windows.Forms.TextBox textBoxBibliothecaireLogin;
        private System.Windows.Forms.TextBox textBoxBibliothecaireId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdherentSupp;
        private System.Windows.Forms.Button buttonAdherentModif;
        private System.Windows.Forms.Button buttonAdherentCreation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAdherentAdresse;
        private System.Windows.Forms.TextBox textBoxAdherentPrenom;
        private System.Windows.Forms.TextBox textBoxAdherentNom;
        private System.Windows.Forms.TextBox textBoxAdherentId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAdherentEmail;
        private System.Windows.Forms.TextBox textBoxAdherentTelephone;
        private System.Windows.Forms.TextBox textBoxAdherentCodePostal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewAdherent;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdherentDateInscr;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdherentDateNaiss;
        private System.Windows.Forms.DateTimePicker dateTimePickerLivreAnneeParution;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxLivreTitre;
        private System.Windows.Forms.TextBox textBoxLivreId;
        private System.Windows.Forms.DataGridView dataGridViewLivre;
        private System.Windows.Forms.Button buttonLivreSuppression;
        private System.Windows.Forms.Button buttonLivreModification;
        private System.Windows.Forms.Button buttonLivreCreation;
        private System.Windows.Forms.Panel panelIdentification;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentDateNaiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentCodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentDateInscr;
        private System.Windows.Forms.ComboBox comboBoxLivreGenre;
        private System.Windows.Forms.ComboBox comboBoxLivreAuteurNom;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBoxLivreEmplacement;
        private System.Windows.Forms.TabPage tabPageAuteur;
        private System.Windows.Forms.DataGridView dataGridViewAuteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuteurID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuteurNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuteurPrenom;
        private System.Windows.Forms.Button buttonAuteurSuppression;
        private System.Windows.Forms.Button buttonAuteurModification;
        private System.Windows.Forms.Button buttonAuteurCreation;
        private System.Windows.Forms.TextBox textBoxAuteurPrenom;
        private System.Windows.Forms.TextBox textBoxAuteurNom;
        private System.Windows.Forms.TextBox textBoxAuteurId;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBoxLivreAuteurPrenom;
        private System.Windows.Forms.TabPage tabPageEmprunt;
        private System.Windows.Forms.DataGridView dataGridViewEmprunter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAdherent;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomAdherent;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomAdherent;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLivre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitreLivre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEmprunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRetour;
        private System.Windows.Forms.Button buttonRendre;
        private System.Windows.Forms.Button buttonEmprunt;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateRetour;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateEmprunt;
        private System.Windows.Forms.TextBox textBoxEmprunterLivreId;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxEmprunterAdherentId;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button buttonListeRetards;
        private System.Windows.Forms.Button buttonEmpruntAfficherTout;
        private System.Windows.Forms.Button buttonBibliothecaireRechercher;
        private System.Windows.Forms.Button buttonBibliothecaireAfficherTout;
        private System.Windows.Forms.Button buttonAdherentAfficherTout;
        private System.Windows.Forms.Button buttonAdherentRechercher;
        private System.Windows.Forms.Button buttonLivreAfficherTout;
        private System.Windows.Forms.Button buttonLivreRechercher;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivreTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivreAnneeParution;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivreGenreLibelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivreAuteurNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivreAuteurPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivreEmplacementLibelle;
        private System.Windows.Forms.Button buttonAuteurAfficherTout;
        private System.Windows.Forms.Button buttonAuteurRechercher;
    }
}

