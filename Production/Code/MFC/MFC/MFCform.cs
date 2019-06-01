using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MFC
{
    public partial class MFCWind : Form
    {
        public MFCWind()
        {
            InitializeComponent();
        }
        //Informations du Serveur de base de donnée
        string conn = ("Data Source=DESKTOP-877GOHO\\SQLEXPRESS;Initial Catalog = MFC; Integrated Security = True");
        private void tabNav_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void MFCWind_Load(object sender, EventArgs e)
        {
            using (SqlConnection SQLcon = new SqlConnection(conn))
            {
                //Permet d'afficher les tables de la base de donnée sur les Grille de Donnée 
                SQLcon.Open();
                SqlDataAdapter daptCli = new SqlDataAdapter("SELECT Client, Telephone, Email FROM Client", SQLcon);
                DataTable dtablClient = new DataTable();
                daptCli.Fill(dtablClient);
                SqlDataAdapter daptSite = new SqlDataAdapter("SELECT Nom, Adresse, CP, Ville FROM Site", SQLcon);
                DataTable dtablSite = new DataTable();
                daptSite.Fill(dtablSite);
                SqlDataAdapter daptInter = new SqlDataAdapter("SELECT * FROM Intervention", SQLcon);
                DataTable dtablInt = new DataTable();
                daptInter.Fill(dtablInt);
                SqlDataAdapter daptMat = new SqlDataAdapter("SELECT * FROM Materiel", SQLcon);
                DataTable dtablMat = new DataTable();
                daptMat.Fill(dtablMat);
                SqlDataAdapter daptInterCours = new SqlDataAdapter("SELECT Date_Planifiee,Client,Materiel,Type_Materiel,Site FROM Intervention WHERE Statut = 'En Cours'", SQLcon);
                DataTable dtablIntC = new DataTable();
                daptInterCours.Fill(dtablIntC);


                GridInterCours.DataSource = dtablIntC;
                DGClient.DataSource = dtablClient;
                DGSites.DataSource = dtablSite;
                DGInter.DataSource = dtablInt;
                DGMat.DataSource = dtablMat;
            }
        }

        private void buttonAddMat_Click(object sender, EventArgs e)
        {
            //Ouvre la fenetre d'ajout Matériel
            AddMatWind f0 = new AddMatWind();
            f0.ShowDialog();
        }

        private void bAddInter2_Click(object sender, EventArgs e)
        {
            //Ouvre la fenetre d'ajout Intervention depuis l'onglet intervention
            AddInterWind f1 = new AddInterWind();
            f1.ShowDialog();
        }

        private void buttonAddInter1_Click(object sender, EventArgs e)
        {
            //Ouvre la fenetre d'ajout Intervention depuis l'accueil
            AddInterWind f1 = new AddInterWind();
            f1.ShowDialog();
        }

        private void buttonDecon_Click(object sender, EventArgs e)
        {
            //Bouton qui deconnecte l'utilisateur et le fait revenir sur la fenetre d'authentification
            FLogin f2 = new FLogin();
            f2.Show();
            this.Close();
           
        }

        private void BAjoutClient_Click(object sender, EventArgs e)
        {
            //Ouvre la fenetre d'ajout Client
            AddClientWind f3 = new AddClientWind();
            f3.ShowDialog();
        }

        private void BAjoutSites_Click(object sender, EventArgs e)
        {
            //Ouvre la fenetre d'ajout de site
            AddSiteWind f4 = new AddSiteWind();
            f4.ShowDialog();
        }

        private void bModifyInter_Click(object sender, EventArgs e)
        {
            ModifInterWind f5 = new ModifInterWind();
            f5.ShowDialog();
            //Selection des Cellule du Datagrid
            f5.CBModifInter_Client.Text = DGInter.CurrentRow.Cells[4].Value.ToString();
            f5.CBModifInter_Site.Text = DGInter.CurrentRow.Cells[7].Value.ToString();
            f5.CBModifInter_Matériel.Text = DGInter.CurrentRow.Cells[5].Value.ToString();
            f5.CBModifInter_TMateriel.Text = DGInter.CurrentRow.Cells[6].Value.ToString();
        }

        private void bDelInter2_Click(object sender, EventArgs e)
        {
            //Suppression d'une ligne du DataGrid
            int rowIndex = DGInter.CurrentCell.RowIndex;
            DGInter.Rows.RemoveAt(rowIndex);
        }
    }
}

 