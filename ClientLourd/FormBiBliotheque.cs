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
            TextBoxLogin.Focus();
        }

        private void LabelPass_click(object sender, EventArgs e)
        {
            TextBoxPass.Focus();
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
                    identificationToolStripMenuItem.Text = oBibliothecaire.bibliothecaire_prenom + " " + oBibliothecaire.bibliothecaire_nom;
                    adherentToolStripMenuItem.Visible = true;
                    bibliothécaireToolStripMenuItem.Visible = true;
                    livreToolStripMenuItem.Visible = true;
                    PanelIdentification.Visible = false;
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

        private void identificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null != oPanelVisible)
            {
                oPanelVisible.Visible = false;
            }
            PanelIdentification.Visible = true;
            oPanelVisible = PanelIdentification;
        }

        private void adhérentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (null != oPanelVisible)
            {
                oPanelVisible.Visible = false;
            }
            PanelAdherent.Visible = true;
            oPanelVisible = PanelAdherent;
        }

        private void livresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (null != oPanelVisible)
            {
                oPanelVisible.Visible = false;
            }
            PanelLivre.Visible = true;
            oPanelVisible = PanelLivre;
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //  StagiaireTableAdapter oDataAdapter = new StagiaireTableAdapter();
            //  DataSetStagiaire oDataSet = new DataSetStagiaire();
            //  oDataAdapter.Fill(oDataSet);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sSqlConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exemple;Integrated Security=True";
            SqlConnection oSqlConn = new SqlConnection(sSqlConnectionString);
            oSqlConn.Open();
            SqlCommand oSqlCommand = new SqlCommand("SELECT COUNT(1) FROM Stagiaire", oSqlConn);
            SqlDataReader oSqlReader = oSqlCommand.ExecuteReader();
            
            while(oSqlReader.Read())
            {
                MessageBox.Show("Votre table contient "+oSqlReader.GetInt32(0)+" enregistrements");
            }
            oSqlReader.Close();
            oSqlConn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sSqlConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exemple;Integrated Security=True";
            SqlConnection oSqlConn = new SqlConnection(sSqlConnectionString);
            //  oSqlConn.Open();
            //  SqlCommand oSqlCommand = new SqlCommand();
            SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter("SELECT COUNT(1) FROM Stagiaire", oSqlConn);
            DataSet oDataSet = new DataSet();

            oSqlDataAdapter.Fill(oDataSet, "Stagiaire");
            DataTableReader oDataTableReader = oDataSet.CreateDataReader();
            while(oDataTableReader.Read())
            {
                MessageBox.Show("Votre table contient " + oDataTableReader.GetInt32(0) + " enregistrements");
            }
            oSqlConn.Close();
        }

        private void aze(object sender, EventArgs e)
        {
            MessageBox.Show(((TextBox)sender).Name);
        }
    }
}