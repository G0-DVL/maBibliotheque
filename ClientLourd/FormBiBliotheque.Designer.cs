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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.identificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adherentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelIdentification = new System.Windows.Forms.Panel();
            this.PanelAdherent = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelLivre = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.PanelIdentification.SuspendLayout();
            this.PanelAdherent.SuspendLayout();
            this.PanelLivre.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(60, 44);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLogin.TabIndex = 0;
            this.TextBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLogin_keyPress);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(15, 47);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(39, 13);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Login :";
            this.LabelLogin.Click += new System.EventHandler(this.LabelLogin_click);
            // 
            // LabelPass
            // 
            this.LabelPass.AutoSize = true;
            this.LabelPass.Location = new System.Drawing.Point(15, 86);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(36, 13);
            this.LabelPass.TabIndex = 3;
            this.LabelPass.Text = "Pass :";
            this.LabelPass.Click += new System.EventHandler(this.LabelPass_click);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(60, 83);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '*';
            this.TextBoxPass.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPass.TabIndex = 2;
            this.TextBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPass_keyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Veuillez saisir vos identifiants :";
            // 
            // ButtonIdentificationValidate
            // 
            this.ButtonIdentificationValidate.Location = new System.Drawing.Point(60, 110);
            this.ButtonIdentificationValidate.Name = "ButtonIdentificationValidate";
            this.ButtonIdentificationValidate.Size = new System.Drawing.Size(75, 23);
            this.ButtonIdentificationValidate.TabIndex = 5;
            this.ButtonIdentificationValidate.Text = "Valider";
            this.ButtonIdentificationValidate.UseVisualStyleBackColor = true;
            this.ButtonIdentificationValidate.Click += new System.EventHandler(this.ButtonIdentificationValidate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identificationToolStripMenuItem,
            this.adherentToolStripMenuItem,
            this.livreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // identificationToolStripMenuItem
            // 
            this.identificationToolStripMenuItem.Name = "identificationToolStripMenuItem";
            this.identificationToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.identificationToolStripMenuItem.Text = "Identification";
            this.identificationToolStripMenuItem.Click += new System.EventHandler(this.identificationToolStripMenuItem_Click);
            // 
            // adherentToolStripMenuItem
            // 
            this.adherentToolStripMenuItem.Name = "adherentToolStripMenuItem";
            this.adherentToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.adherentToolStripMenuItem.Text = "Adhérents";
            this.adherentToolStripMenuItem.Visible = false;
            this.adherentToolStripMenuItem.Click += new System.EventHandler(this.adhérentsToolStripMenuItem_Click);
            // 
            // livreToolStripMenuItem
            // 
            this.livreToolStripMenuItem.Name = "livreToolStripMenuItem";
            this.livreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.livreToolStripMenuItem.Text = "Livres";
            this.livreToolStripMenuItem.Visible = false;
            this.livreToolStripMenuItem.Click += new System.EventHandler(this.livresToolStripMenuItem_Click);
            // 
            // PanelIdentification
            // 
            this.PanelIdentification.Controls.Add(this.label1);
            this.PanelIdentification.Controls.Add(this.ButtonIdentificationValidate);
            this.PanelIdentification.Controls.Add(this.TextBoxLogin);
            this.PanelIdentification.Controls.Add(this.LabelLogin);
            this.PanelIdentification.Controls.Add(this.LabelPass);
            this.PanelIdentification.Controls.Add(this.TextBoxPass);
            this.PanelIdentification.Location = new System.Drawing.Point(28, 42);
            this.PanelIdentification.Name = "PanelIdentification";
            this.PanelIdentification.Size = new System.Drawing.Size(187, 151);
            this.PanelIdentification.TabIndex = 7;
            this.PanelIdentification.Visible = false;
            // 
            // PanelAdherent
            // 
            this.PanelAdherent.Controls.Add(this.label3);
            this.PanelAdherent.Location = new System.Drawing.Point(311, 75);
            this.PanelAdherent.Name = "PanelAdherent";
            this.PanelAdherent.Size = new System.Drawing.Size(200, 100);
            this.PanelAdherent.TabIndex = 8;
            this.PanelAdherent.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ici on affiche des adhérents";
            // 
            // PanelLivre
            // 
            this.PanelLivre.Controls.Add(this.label2);
            this.PanelLivre.Location = new System.Drawing.Point(364, 181);
            this.PanelLivre.Name = "PanelLivre";
            this.PanelLivre.Size = new System.Drawing.Size(200, 100);
            this.PanelLivre.TabIndex = 1;
            this.PanelLivre.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ici on affiche des bouquins";
            // 
            // FormBiBliotheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 503);
            this.Controls.Add(this.PanelLivre);
            this.Controls.Add(this.PanelAdherent);
            this.Controls.Add(this.PanelIdentification);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBiBliotheque";
            this.Text = "Bienvenue à la bibliothèque";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelIdentification.ResumeLayout(false);
            this.PanelIdentification.PerformLayout();
            this.PanelAdherent.ResumeLayout(false);
            this.PanelAdherent.PerformLayout();
            this.PanelLivre.ResumeLayout(false);
            this.PanelLivre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonIdentificationValidate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem identificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adherentToolStripMenuItem;
        private System.Windows.Forms.Panel PanelIdentification;
        private System.Windows.Forms.Panel PanelAdherent;
        private System.Windows.Forms.Panel PanelLivre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem livreToolStripMenuItem;
    }
}

