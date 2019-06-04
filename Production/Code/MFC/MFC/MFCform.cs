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
        string conn = ("Data Source=.\\SQLEXPRESS;Initial Catalog = MFC; Integrated Security = True");
        private void tabNav_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        public void MFCWind_Load(object sender, EventArgs e)
        {
            using (SqlConnection SQLcon = new SqlConnection(conn))
            {
                //Permet d'afficher les tables de la base de donnée sur les Grille de Donnée 
                SQLcon.Open();
                SqlDataAdapter daptCli = new SqlDataAdapter("SELECT * FROM Client", SQLcon);
                DataTable dtablClient = new DataTable();
                daptCli.Fill(dtablClient);
                SqlDataAdapter daptSite = new SqlDataAdapter("SELECT * FROM Site", SQLcon);
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
            ModifInterWind f5 = new ModifInterWind((int)DGInter.SelectedRows[0].Cells[0].Value);
            f5.ShowDialog();
        }

        private void bDelInter2_Click(object sender, EventArgs e)
        {
            //Suppression d'une ligne du DataGrid
            

            
        }

        private void buttonModMat_Click(object sender, EventArgs e)
        {
            ModifMatWind f6 = new ModifMatWind((int)DGMat.SelectedRows[0].Cells[0].Value);
            f6.ShowDialog();

        }

        private void BModifClient_Click(object sender, EventArgs e)
        {
            ModifClientWind f7 = new ModifClientWind((int)DGClient.SelectedRows[0].Cells[0].Value);
            f7.ShowDialog();
            
        }

        private void BModifSites_Click(object sender, EventArgs e)
        {
            ModifSiteWind f7 = new ModifSiteWind((int)DGSites.SelectedRows[0].Cells[0].Value);
            f7.ShowDialog();
        }

        private void BRfreshDG_Click(object sender, EventArgs e)
        {
            DGClient.Refresh();

        }
    }
}

 