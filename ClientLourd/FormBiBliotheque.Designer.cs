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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageLivre = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageIdentification.SuspendLayout();
            this.tabPageBibliothecaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBibliothecaire)).BeginInit();
            this.tabPageAdherent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(814, 577);
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
            this.tabPageIdentification.Size = new System.Drawing.Size(806, 551);
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
            this.tabPageAdherent.Controls.Add(this.dataGridView1);
            this.tabPageAdherent.Controls.Add(this.button1);
            this.tabPageAdherent.Controls.Add(this.button2);
            this.tabPageAdherent.Controls.Add(this.button3);
            this.tabPageAdherent.Controls.Add(this.label7);
            this.tabPageAdherent.Controls.Add(this.label8);
            this.tabPageAdherent.Controls.Add(this.textBox1);
            this.tabPageAdherent.Controls.Add(this.textBox2);
            this.tabPageAdherent.Controls.Add(this.textBox3);
            this.tabPageAdherent.Controls.Add(this.textBox4);
            this.tabPageAdherent.Controls.Add(this.textBox5);
            this.tabPageAdherent.Controls.Add(this.label9);
            this.tabPageAdherent.Controls.Add(this.label10);
            this.tabPageAdherent.Controls.Add(this.label11);
            this.tabPageAdherent.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdherent.Name = "tabPageAdherent";
            this.tabPageAdherent.Size = new System.Drawing.Size(621, 464);
            this.tabPageAdherent.TabIndex = 2;
            this.tabPageAdherent.Text = "Adhérent";
            this.tabPageAdherent.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Location = new System.Drawing.Point(208, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 315);
            this.dataGridView1.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Login";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Suppression";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Modification";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Creation";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Prenom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nom";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(83, 70);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Login";
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
            this.tabPageLivre.Location = new System.Drawing.Point(4, 22);
            this.tabPageLivre.Name = "tabPageLivre";
            this.tabPageLivre.Size = new System.Drawing.Size(621, 464);
            this.tabPageLivre.TabIndex = 3;
            this.tabPageLivre.Text = "Livre";
            this.tabPageLivre.UseVisualStyleBackColor = true;
            // 
            // FormBiBliotheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 578);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

