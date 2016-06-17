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
                    var monNouveauBibliothecaire = new bibliothecaire { bibliothecaire_ID = 1, bibliothecaire_login = "pouet" }; //  { bibliothecaire_ID = 1, bibliothecaire_login = "pouet" };
                }
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
            //  Pour insérer le premier utilisateur
            //    insert into bibliothecaire
            //    (
            //        bibliothecaire_login,
            //        bibliothecaire_password,
            //        bibliothecaire_nom,
            //        bibliothecaire_prenom
            //    )
            //    values
            //    (
            //        'admin',
            //        'admin',
            //        'admin',
            //        'admin'
            //    )


            // 127.0.01 est l'adresse localhost du serveur Apache XAMPP
            // Nous avons créer une base de données nommée "mli"
            // L'utilisateur par défaut lors de l'installation de XAMPP est "root" sans mot de passe.
            string connectionString = "SERVER=127.0.0.1; DATABASE=bibliotheque; UID=root; PASSWORD=";

            try
            {
                SqlConnection maConnexionSQL = new SqlConnection(connectionString);

                // Ouverture de la connexion SQL
                maConnexionSQL.Open();

               // Création d'une commande SQL en fonction de l'objet connection
               SqlCommand maCommandeSQL = maConnexionSQL.CreateCommand();
               
               // Requête SQL
               maCommandeSQL.CommandText =
                    "SELECT "+
                        "bibliothecaire_nom, " +
                        "bibliothecaire_prenom  " +
                    "FROM bibliothecaire " +
                    "WHERE " +
                         "bibliothecaire_login = '" + TextBoxLogin.Text + "' " +
                         "AND bibliothecaire_password = '" + TextBoxPass.Text + "'";

                // Exécution de la commande SQL
                SqlDataReader monReaderSQL = maCommandeSQL.ExecuteReader();
                if(monReaderSQL.Read())
                {
                    adherentToolStripMenuItem.Visible = true;
                    livreToolStripMenuItem.Visible = true;
                    PanelIdentification.Visible = false;

                }
                else
                {
                    MessageBox.Show("ACCES REFUSE");
                }

                // Fermeture de la connexion
                maConnexionSQL.Close();

            }
            catch(Exception eException)
            {
                MessageBox.Show("Impossible de se connecter à la base ! ("+eException.Message+")");
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