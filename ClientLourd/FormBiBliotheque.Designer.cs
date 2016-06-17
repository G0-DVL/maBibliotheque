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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageIdentification = new System.Windows.Forms.TabPage();
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
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxAdherentCodePostal = new System.Windows.Forms.TextBox();
            this.textBoxAdherentTelephone = new System.Windows.Forms.TextBox();
            this.textBoxAdherentEmail = new System.Windows.Forms.TextBox();
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
            this.dateTimePickerAdherentDateNaiss = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAdherentDateInscr = new System.Windows.Forms.DateTimePicker();
            this.textBoxLivreId = new System.Windows.Forms.TextBox();
            this.textBoxLivreTitre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePickerLivreAnneeParution = new System.Windows.Forms.DateTimePicker();
            this.buttonLivreCreation = new System.Windows.Forms.Button();
            this.buttonLivreModification = new System.Windows.Forms.Button();
            this.buttonLivreSuppression = new System.Windows.Forms.Button();
            this.dataGridViewLivre = new System.Windows.Forms.DataGridView();
            this.LivreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivreTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivreAnneeParution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageIdentification.SuspendLayout();
            this.tabPageBibliothecaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBibliothecaire)).BeginInit();
            this.tabPageAdherent.SuspendLayout();
            this.tabPageLivre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdherent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivre)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(261, 183);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLogin.TabIndex = 0;
            this.TextBoxLogin.Enter += new System.EventHandler(this.TextBoxIdentification_Enter);
            this.TextBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLogin_keyPress);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(216, 186);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(39, 13);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Login :";
            this.LabelLogin.Click += new System.EventHandler(this.LabelLogin_click);
            // 
            // LabelPass
            // 
            this.LabelPass.AutoSize = true;
            this.LabelPass.Location = new System.Drawing.Point(216, 225);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(36, 13);
            this.LabelPass.TabIndex = 3;
            this.LabelPass.Text = "Pass :";
            this.LabelPass.Click += new System.EventHandler(this.LabelPass_click);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(261, 222);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '*';
            this.TextBoxPass.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPass.TabIndex = 2;
            this.TextBoxPass.Enter += new System.EventHandler(this.TextBoxIdentification_Enter);
            this.TextBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPass_keyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Veuillez saisir vos identifiants :";
            // 
            // ButtonIdentificationValidate
            // 
            this.ButtonIdentificationValidate.Location = new System.Drawing.Point(261, 249);
            this.ButtonIdentificationValidate.Name = "ButtonIdentificationValidate";
            this.ButtonIdentificationValidate.Size = new System.Drawing.Size(75, 23);
            this.ButtonIdentificationValidate.TabIndex = 5;
            this.ButtonIdentificationValidate.Text = "Valider";
            this.ButtonIdentificationValidate.UseVisualStyleBackColor = true;
            this.ButtonIdentificationValidate.Click += new System.EventHandler(this.ButtonIdentificationValidate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageIdentification);
            this.tabControl1.Controls.Add(this.tabPageBibliothecaire);
            this.tabControl1.Controls.Add(this.tabPageAdherent);
            this.tabControl1.Controls.Add(this.tabPageLivre);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 490);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageIdentification
            // 
            this.tabPageIdentification.Controls.Add(this.label1);
            this.tabPageIdentification.Controls.Add(this.ButtonIdentificationValidate);
            this.tabPageIdentification.Controls.Add(this.TextBoxLogin);
            this.tabPageIdentification.Controls.Add(this.TextBoxPass);
            this.tabPageIdentification.Controls.Add(this.LabelLogin);
            this.tabPageIdentification.Controls.Add(this.LabelPass);
            this.tabPageIdentification.Location = new System.Drawing.Point(4, 22);
            this.tabPageIdentification.Name = "tabPageIdentification";
            this.tabPageIdentification.Size = new System.Drawing.Size(621, 464);
            this.tabPageIdentification.TabIndex = 0;
            this.tabPageIdentification.Text = "Identification";
            this.tabPageIdentification.UseVisualStyleBackColor = true;
            // 
            // tabPageBibliothecaire
            // 
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
            this.tabPageBibliothecaire.Size = new System.Drawing.Size(621, 464);
            this.tabPageBibliothecaire.TabIndex = 1;
            this.tabPageBibliothecaire.Text = "Bibliothécaire";
            this.tabPageBibliothecaire.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBibliothecaire
            // 
            this.dataGridViewBibliothecaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBibliothecaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Login,
            this.Nom,
            this.Prenom});
            this.dataGridViewBibliothecaire.Location = new System.Drawing.Point(226, 64);
            this.dataGridViewBibliothecaire.Name = "dataGridViewBibliothecaire";
            this.dataGridViewBibliothecaire.Size = new System.Drawing.Size(406, 315);
            this.dataGridViewBibliothecaire.TabIndex = 15;
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
            this.buttonBibliothecaireSuppression.Location = new System.Drawing.Point(28, 347);
            this.buttonBibliothecaireSuppression.Name = "buttonBibliothecaireSuppression";
            this.buttonBibliothecaireSuppression.Size = new System.Drawing.Size(75, 23);
            this.buttonBibliothecaireSuppression.TabIndex = 14;
            this.buttonBibliothecaireSuppression.Text = "Suppression";
            this.buttonBibliothecaireSuppression.UseVisualStyleBackColor = true;
            // 
            // buttonBibliothecaireModification
            // 
            this.buttonBibliothecaireModification.Location = new System.Drawing.Point(28, 305);
            this.buttonBibliothecaireModification.Name = "buttonBibliothecaireModification";
            this.buttonBibliothecaireModification.Size = new System.Drawing.Size(75, 23);
            this.buttonBibliothecaireModification.TabIndex = 13;
            this.buttonBibliothecaireModification.Text = "Modification";
            this.buttonBibliothecaireModification.UseVisualStyleBackColor = true;
            // 
            // buttonBibliothecaireCreation
            // 
            this.buttonBibliothecaireCreation.Location = new System.Drawing.Point(28, 265);
            this.buttonBibliothecaireCreation.Name = "buttonBibliothecaireCreation";
            this.buttonBibliothecaireCreation.Size = new System.Drawing.Size(75, 23);
            this.buttonBibliothecaireCreation.TabIndex = 12;
            this.buttonBibliothecaireCreation.Text = "Creation";
            this.buttonBibliothecaireCreation.UseVisualStyleBackColor = true;
            this.buttonBibliothecaireCreation.Click += new System.EventHandler(this.buttonBibliothecaireCreation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nom";
            // 
            // textBoxBibliothecairePrenom
            // 
            this.textBoxBibliothecairePrenom.Location = new System.Drawing.Point(101, 204);
            this.textBoxBibliothecairePrenom.Name = "textBoxBibliothecairePrenom";
            this.textBoxBibliothecairePrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxBibliothecairePrenom.TabIndex = 7;
            // 
            // textBoxBibliothecaireNom
            // 
            this.textBoxBibliothecaireNom.Location = new System.Drawing.Point(101, 166);
            this.textBoxBibliothecaireNom.Name = "textBoxBibliothecaireNom";
            this.textBoxBibliothecaireNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxBibliothecaireNom.TabIndex = 6;
            // 
            // textBoxBibliothecairePassword
            // 
            this.textBoxBibliothecairePassword.Location = new System.Drawing.Point(101, 121);
            this.textBoxBibliothecairePassword.Name = "textBoxBibliothecairePassword";
            this.textBoxBibliothecairePassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxBibliothecairePassword.TabIndex = 5;
            // 
            // textBoxBibliothecaireLogin
            // 
            this.textBoxBibliothecaireLogin.Location = new System.Drawing.Point(101, 87);
            this.textBoxBibliothecaireLogin.Name = "textBoxBibliothecaireLogin";
            this.textBoxBibliothecaireLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxBibliothecaireLogin.TabIndex = 4;
            // 
            // textBoxBibliothecaireId
            // 
            this.textBoxBibliothecaireId.Location = new System.Drawing.Point(101, 55);
            this.textBoxBibliothecaireId.Name = "textBoxBibliothecaireId";
            this.textBoxBibliothecaireId.Size = new System.Drawing.Size(100, 20);
            this.textBoxBibliothecaireId.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";
            // 
            // tabPageAdherent
            // 
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
            this.tabPageAdherent.Size = new System.Drawing.Size(621, 464);
            this.tabPageAdherent.TabIndex = 2;
            this.tabPageAdherent.Text = "Adhérent";
            this.tabPageAdherent.UseVisualStyleBackColor = true;
            // 
            // buttonAdherentSupp
            // 
            this.buttonAdherentSupp.Location = new System.Drawing.Point(10, 445);
            this.buttonAdherentSupp.Name = "buttonAdherentSupp";
            this.buttonAdherentSupp.Size = new System.Drawing.Size(75, 23);
            this.buttonAdherentSupp.TabIndex = 28;
            this.buttonAdherentSupp.Text = "Suppression";
            this.buttonAdherentSupp.UseVisualStyleBackColor = true;
            // 
            // buttonAdherentModif
            // 
            this.buttonAdherentModif.Location = new System.Drawing.Point(13, 416);
            this.buttonAdherentModif.Name = "buttonAdherentModif";
            this.buttonAdherentModif.Size = new System.Drawing.Size(75, 23);
            this.buttonAdherentModif.TabIndex = 27;
            this.buttonAdherentModif.Text = "Modification";
            this.buttonAdherentModif.UseVisualStyleBackColor = true;
            // 
            // buttonAdherentCreation
            // 
            this.buttonAdherentCreation.Location = new System.Drawing.Point(10, 387);
            this.buttonAdherentCreation.Name = "buttonAdherentCreation";
            this.buttonAdherentCreation.Size = new System.Drawing.Size(75, 23);
            this.buttonAdherentCreation.TabIndex = 26;
            this.buttonAdherentCreation.Text = "Creation";
            this.buttonAdherentCreation.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Adresse";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Date Naiss";
            // 
            // textBoxAdherentAdresse
            // 
            this.textBoxAdherentAdresse.Location = new System.Drawing.Point(101, 212);
            this.textBoxAdherentAdresse.Name = "textBoxAdherentAdresse";
            this.textBoxAdherentAdresse.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdherentAdresse.TabIndex = 23;
            // 
            // textBoxAdherentPrenom
            // 
            this.textBoxAdherentPrenom.Location = new System.Drawing.Point(101, 136);
            this.textBoxAdherentPrenom.Name = "textBoxAdherentPrenom";
            this.textBoxAdherentPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdherentPrenom.TabIndex = 21;
            // 
            // textBoxAdherentNom
            // 
            this.textBoxAdherentNom.Location = new System.Drawing.Point(101, 102);
            this.textBoxAdherentNom.Name = "textBoxAdherentNom";
            this.textBoxAdherentNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdherentNom.TabIndex = 20;
            // 
            // textBoxAdherentId
            // 
            this.textBoxAdherentId.Location = new System.Drawing.Point(101, 70);
            this.textBoxAdherentId.Name = "textBoxAdherentId";
            this.textBoxAdherentId.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdherentId.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Prenom";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Id";
            // 
            // tabPageLivre
            // 
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
            this.tabPageLivre.Size = new System.Drawing.Size(621, 464);
            this.tabPageLivre.TabIndex = 3;
            this.tabPageLivre.Text = "Livre";
            this.tabPageLivre.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Nom";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Code Postal";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Telephone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 311);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Email";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 343);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Date Inscription";
            // 
            // textBoxAdherentCodePostal
            // 
            this.textBoxAdherentCodePostal.Location = new System.Drawing.Point(101, 247);
            this.textBoxAdherentCodePostal.Name = "textBoxAdherentCodePostal";
            this.textBoxAdherentCodePostal.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdherentCodePostal.TabIndex = 35;
            // 
            // textBoxAdherentTelephone
            // 
            this.textBoxAdherentTelephone.Location = new System.Drawing.Point(101, 273);
            this.textBoxAdherentTelephone.Name = "textBoxAdherentTelephone";
            this.textBoxAdherentTelephone.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdherentTelephone.TabIndex = 36;
            // 
            // textBoxAdherentEmail
            // 
            this.textBoxAdherentEmail.Location = new System.Drawing.Point(101, 304);
            this.textBoxAdherentEmail.Name = "textBoxAdherentEmail";
            this.textBoxAdherentEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdherentEmail.TabIndex = 37;
            // 
            // dataGridViewAdherent
            // 
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
            this.dataGridViewAdherent.Location = new System.Drawing.Point(222, 70);
            this.dataGridViewAdherent.Name = "dataGridViewAdherent";
            this.dataGridViewAdherent.Size = new System.Drawing.Size(573, 150);
            this.dataGridViewAdherent.TabIndex = 39;
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
            this.AdherentPrenom.HeaderText = "Prenom";
            this.AdherentPrenom.Name = "AdherentPrenom";
            // 
            // AdherentDateNaiss
            // 
            this.AdherentDateNaiss.HeaderText = "Date Naissance";
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
            this.AdherentTel.HeaderText = "Telephone";
            this.AdherentTel.Name = "AdherentTel";
            // 
            // AdherentEmail
            // 
            this.AdherentEmail.HeaderText = "Email";
            this.AdherentEmail.Name = "AdherentEmail";
            // 
            // AdherentDateInscr
            // 
            this.AdherentDateInscr.HeaderText = "Date Inscription";
            this.AdherentDateInscr.Name = "AdherentDateInscr";
            // 
            // dateTimePickerAdherentDateNaiss
            // 
            this.dateTimePickerAdherentDateNaiss.CustomFormat = " dd/MM/yyyy";
            this.dateTimePickerAdherentDateNaiss.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAdherentDateNaiss.Location = new System.Drawing.Point(101, 181);
            this.dateTimePickerAdherentDateNaiss.Name = "dateTimePickerAdherentDateNaiss";
            this.dateTimePickerAdherentDateNaiss.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerAdherentDateNaiss.TabIndex = 40;
            // 
            // dateTimePickerAdherentDateInscr
            // 
            this.dateTimePickerAdherentDateInscr.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerAdherentDateInscr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAdherentDateInscr.Location = new System.Drawing.Point(101, 343);
            this.dateTimePickerAdherentDateInscr.Name = "dateTimePickerAdherentDateInscr";
            this.dateTimePickerAdherentDateInscr.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerAdherentDateInscr.TabIndex = 41;
            // 
            // textBoxLivreId
            // 
            this.textBoxLivreId.Location = new System.Drawing.Point(126, 95);
            this.textBoxLivreId.Name = "textBoxLivreId";
            this.textBoxLivreId.Size = new System.Drawing.Size(100, 20);
            this.textBoxLivreId.TabIndex = 0;
            // 
            // textBoxLivreTitre
            // 
            this.textBoxLivreTitre.Location = new System.Drawing.Point(126, 140);
            this.textBoxLivreTitre.Name = "textBoxLivreTitre";
            this.textBoxLivreTitre.Size = new System.Drawing.Size(100, 20);
            this.textBoxLivreTitre.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Id";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Titre";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 185);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Année Parution";
            // 
            // dateTimePickerLivreAnneeParution
            // 
            this.dateTimePickerLivreAnneeParution.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerLivreAnneeParution.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerLivreAnneeParution.Location = new System.Drawing.Point(126, 178);
            this.dateTimePickerLivreAnneeParution.Name = "dateTimePickerLivreAnneeParution";
            this.dateTimePickerLivreAnneeParution.Size = new System.Drawing.Size(105, 20);
            this.dateTimePickerLivreAnneeParution.TabIndex = 6;
            // 
            // buttonLivreCreation
            // 
            this.buttonLivreCreation.Location = new System.Drawing.Point(30, 263);
            this.buttonLivreCreation.Name = "buttonLivreCreation";
            this.buttonLivreCreation.Size = new System.Drawing.Size(75, 23);
            this.buttonLivreCreation.TabIndex = 7;
            this.buttonLivreCreation.Text = "Creation";
            this.buttonLivreCreation.UseVisualStyleBackColor = true;
            // 
            // buttonLivreModification
            // 
            this.buttonLivreModification.Location = new System.Drawing.Point(30, 312);
            this.buttonLivreModification.Name = "buttonLivreModification";
            this.buttonLivreModification.Size = new System.Drawing.Size(75, 23);
            this.buttonLivreModification.TabIndex = 8;
            this.buttonLivreModification.Text = "Modification";
            this.buttonLivreModification.UseVisualStyleBackColor = true;
            // 
            // buttonLivreSuppression
            // 
            this.buttonLivreSuppression.Location = new System.Drawing.Point(30, 364);
            this.buttonLivreSuppression.Name = "buttonLivreSuppression";
            this.buttonLivreSuppression.Size = new System.Drawing.Size(75, 23);
            this.buttonLivreSuppression.TabIndex = 9;
            this.buttonLivreSuppression.Text = "Suppression";
            this.buttonLivreSuppression.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLivre
            // 
            this.dataGridViewLivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LivreId,
            this.LivreTitre,
            this.LivreAnneeParution});
            this.dataGridViewLivre.Location = new System.Drawing.Point(289, 95);
            this.dataGridViewLivre.Name = "dataGridViewLivre";
            this.dataGridViewLivre.Size = new System.Drawing.Size(309, 150);
            this.dataGridViewLivre.TabIndex = 10;
            this.dataGridViewLivre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLivre_CellContentClick);
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
            // FormBiBliotheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormBiBliotheque";
            this.Text = "Bienvenue à la bibliothèque";
            this.tabControl1.ResumeLayout(false);
            this.tabPageIdentification.ResumeLayout(false);
            this.tabPageIdentification.PerformLayout();
            this.tabPageBibliothecaire.ResumeLayout(false);
            this.tabPageBibliothecaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBibliothecaire)).EndInit();
            this.tabPageAdherent.ResumeLayout(false);
            this.tabPageAdherent.PerformLayout();
            this.tabPageLivre.ResumeLayout(false);
            this.tabPageLivre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdherent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonIdentificationValidate;
        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentDateNaiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentCodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdherentDateInscr;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdherentDateInscr;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdherentDateNaiss;
        private System.Windows.Forms.DateTimePicker dateTimePickerLivreAnneeParution;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxLivreTitre;
        private System.Windows.Forms.TextBox textBoxLivreId;
        private System.Windows.Forms.DataGridView dataGridViewLivre;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivreTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivreAnneeParution;
        private System.Windows.Forms.Button buttonLivreSuppression;
        private System.Windows.Forms.Button buttonLivreModification;
        private System.Windows.Forms.Button buttonLivreCreation;
    }
}

