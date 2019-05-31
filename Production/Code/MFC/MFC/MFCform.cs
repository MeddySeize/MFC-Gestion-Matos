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
        string conn = ("Data Source=DESKTOP-877GOHO\\SQLEXPRESS;Initial Catalog = MFC; Integrated Security = True");
        private void tabNav_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void MFCWind_Load(object sender, EventArgs e)
        {
            using (SqlConnection SQLcon = new SqlConnection(conn))
            {
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

                DGClient.DataSource = dtablClient;
                DGSites.DataSource = dtablSite;
                DGInter.DataSource = dtablInt;
                DGMat.DataSource = dtablMat;
            }
        }

        private void buttonAddMat_Click(object sender, EventArgs e)
        {
            AddMatWind f0 = new AddMatWind();
            f0.ShowDialog();
        }

        private void bAddInter2_Click(object sender, EventArgs e)
        {
            AddInterWind f1 = new AddInterWind();
            f1.ShowDialog();
        }

        private void buttonAddInter1_Click(object sender, EventArgs e)
        {
            AddInterWind f1 = new AddInterWind();
            f1.ShowDialog();
        }

        private void buttonDecon_Click(object sender, EventArgs e)
        {
            FLogin f2 = new FLogin();
            f2.Show();
            this.Close();
           
        }

        private void BAjoutClient_Click(object sender, EventArgs e)
        {
            AddClientWind f3 = new AddClientWind();
            f3.ShowDialog();
        }

        private void BAjoutSites_Click(object sender, EventArgs e)
        {
            AddSiteWind f4 = new AddSiteWind();
            f4.ShowDialog();
        }
    }
}

