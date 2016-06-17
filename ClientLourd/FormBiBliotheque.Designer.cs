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
            this.tabPageAdherent = new System.Windows.Forms.TabPage();
            this.tabPageLivre = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageIdentification.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(604, 490);
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
            this.tabPageIdentification.Size = new System.Drawing.Size(596, 464);
            this.tabPageIdentification.TabIndex = 0;
            this.tabPageIdentification.Text = "Identification";
            this.tabPageIdentification.UseVisualStyleBackColor = true;
            // 
            // tabPageBibliothecaire
            // 
            this.tabPageBibliothecaire.Location = new System.Drawing.Point(4, 22);
            this.tabPageBibliothecaire.Name = "tabPageBibliothecaire";
            this.tabPageBibliothecaire.Size = new System.Drawing.Size(596, 464);
            this.tabPageBibliothecaire.TabIndex = 1;
            this.tabPageBibliothecaire.Text = "Bibliothécaire";
            this.tabPageBibliothecaire.UseVisualStyleBackColor = true;
            // 
            // tabPageAdherent
            // 
            this.tabPageAdherent.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdherent.Name = "tabPageAdherent";
            this.tabPageAdherent.Size = new System.Drawing.Size(596, 464);
            this.tabPageAdherent.TabIndex = 2;
            this.tabPageAdherent.Text = "Adhérent";
            this.tabPageAdherent.UseVisualStyleBackColor = true;
            // 
            // tabPageLivre
            // 
            this.tabPageLivre.Location = new System.Drawing.Point(4, 22);
            this.tabPageLivre.Name = "tabPageLivre";
            this.tabPageLivre.Size = new System.Drawing.Size(596, 464);
            this.tabPageLivre.TabIndex = 3;
            this.tabPageLivre.Text = "Livre";
            this.tabPageLivre.UseVisualStyleBackColor = true;
            // 
            // FormBiBliotheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 503);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormBiBliotheque";
            this.Text = "Bienvenue à la bibliothèque";
            this.tabControl1.ResumeLayout(false);
            this.tabPageIdentification.ResumeLayout(false);
            this.tabPageIdentification.PerformLayout();
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
    }
}

