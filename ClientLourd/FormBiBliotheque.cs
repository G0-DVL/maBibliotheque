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

namespace ClientLourd
{
    public partial class FormBiBliotheque : Form
    {
        //  static int iTentativeDeValidation = 3;
        static Panel oPanelVisible;

        public FormBiBliotheque()
        {
            InitializeComponent();
            using (maBibliothequeEntities monContext = new maBibliothequeEntities())
            {
                int iCount = monContext.bibliothecaires.Count<bibliothecaire>();
                if (iCount == 0)
                {
                    //  MessageBox.Show("On a personne dans la base (y'a quelqu'un ?)");
                    var monNouveauBibliothecaire = new bibliothecaire {
                        bibliothecaire_ID = 1,
                        bibliothecaire_login = "admin",
                        bibliothecaire_password = "admin",
                        bibliothecaire_nom = "par défaut",
                        bibliothecaire_prenom = "Administrateur"
                    };
                    monContext.bibliothecaires.Add(monNouveauBibliothecaire);
                }
                monContext.SaveChanges();
            }
        }

        private void LabelLogin_click(object sender, EventArgs e)
        {
            TextBoxLogin.SelectAll();
        }

        private void LabelPass_click(object sender, EventArgs e)
        {
            TextBoxPass.SelectAll();
        }

        private void ButtonIdentificationValidate_Click(object sender, EventArgs e)
        {
            using (maBibliothequeEntities cContext = new maBibliothequeEntities())
            {
                var oQuery = from bibliothecaire in cContext.bibliothecaires
                             where
                                bibliothecaire.bibliothecaire_login == TextBoxLogin.Text
                                &&
                                bibliothecaire.bibliothecaire_password == TextBoxPass.Text
                             select bibliothecaire;
                var oBibliothecaire = oQuery.FirstOrDefault();

                if (oBibliothecaire == null)
                {
                    MessageBox.Show("ACCES REFUSE");
                }
                else
                {
                    MessageBox.Show("Bonjour "+ oBibliothecaire.bibliothecaire_prenom + " " + oBibliothecaire.bibliothecaire_nom);
                }

            }
        }

        private void TextBoxLogin_keyPress(object sender, KeyPressEventArgs e)
        {            
            if((char)Keys.Return== e.KeyChar)
            {
                ButtonIdentificationValidate_Click(sender, e);
            }
        }

        private void TextBoxPass_keyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Return == e.KeyChar)
            {
                ButtonIdentificationValidate_Click(sender, e);
            }
        }

        private void TextBoxIdentification_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void buttonBibliothecaireCreation_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewLivre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}