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
        string conn = ("Data Source=SILVERDELL\\SQLEXPRESS;Initial Catalog = MFC; Integrated Security = True");
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

        }
    }
}

