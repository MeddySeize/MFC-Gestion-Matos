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
    public partial class ModifSiteWind : Form
    {
        public ModifSiteWind()
        {
            InitializeComponent();
        }

        string conn = ("Data Source= .\\SQLEXPRESS;Initial Catalog = MFC; Integrated Security = True");

        int idsite;
        public ModifSiteWind(int id_Site)
        {
            idsite = id_Site;
            InitializeComponent();
            SqlConnection con = new SqlConnection(conn);
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT * FROM Site WHERE ID_Site = @ID_Site";
            con.Open();
            com.Parameters.Add("@ID_Site", SqlDbType.Int).Value = id_Site;
            SqlDataReader dataReader = com.ExecuteReader();
            if (dataReader.Read())
            {
                TBModifSite_Nom.Text = dataReader["Nom"].ToString();
                TBModifSite_Adr.Text = dataReader["Adresse"].ToString();
                TBModifSite_CP.Text = dataReader["CP"].ToString();
                TBModifSite_Ville.Text = dataReader["Ville"].ToString();
            }

        }


        private void BModifSite_OK_Click(object sender, EventArgs e)
        {
                String Strcom = "UPDATE dbo.Materiel SET Client = @Client, Email = @Email, Tel = @Tel  WHERE ID_Client = @ID_Client";
                SqlConnection con = new SqlConnection(conn);
                SqlCommand com = new SqlCommand(Strcom, con);
                SqlDataReader myReader;
                com.Parameters.Add("@ID_Client", SqlDbType.Int).Value = idsite;
                com.Parameters.AddWithValue("@Nom", TBModifSite_Nom.Text);
                com.Parameters.AddWithValue("@Adresse", TBModifSite_Adr.Text);
                com.Parameters.AddWithValue("@CP", TBModifSite_CP.Text);
                com.Parameters.AddWithValue("@Ville", TBModifSite_Ville.Text);


                try
                {
                    con.Open();
                    myReader = com.ExecuteReader();
                    MessageBox.Show("Modifié dans les sites");
                    this.Hide();

                    while (myReader.Read())
                    {
                        this.Close();
                        myReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void BModifSite_Annul_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


