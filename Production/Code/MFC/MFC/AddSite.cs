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
    public partial class AddSiteWind : Form
    {
        public AddSiteWind()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string conn = ("Data Source=DESKTOP-877GOHO\\SQLEXPRESS;Initial Catalog = MFC; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            String Strcom = " INSERT INTO dbo.Site(Nom, Adresse, CP, Ville) VALUES(@Nom, @Adresse, @CP, @Ville);";
            SqlConnection con = new SqlConnection(conn);
            SqlCommand com = new SqlCommand(Strcom, con);
            SqlDataReader myReader;
            com.Parameters.AddWithValue("@Nom", TBAddSite_Nom.Text);
            com.Parameters.AddWithValue("@Adresse", TBAddSite_Adr.Text);
            com.Parameters.AddWithValue("@CP", TBAddSite_CP.Text);
            com.Parameters.AddWithValue("@Ville", TBAddSite_Ville.Text);
            try
            {
                con.Open();
                myReader = com.ExecuteReader();
                MessageBox.Show("saved");

                while (myReader.Read())
                {
                    //J'essaye d'actualiser le Data Grid
                    SqlDataAdapter daptInter = new SqlDataAdapter("SELECT * FROM Site", con);
                    DataTable dtablInt = new DataTable();
                    daptInter.Fill(dtablInt);
                    myReader.Close();
                    con.Close();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
