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
    public partial class ModifMatWind : Form
    {
        public ModifMatWind()
        {
            InitializeComponent();
        }

        string conn = ("Data Source= .\\SQLEXPRESS;Initial Catalog = MFC; Integrated Security = True");

        int idmat;
        public ModifMatWind(int id_materiel)
        {
            idmat = id_materiel;
            InitializeComponent();
            SqlConnection con = new SqlConnection(conn);
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT * FROM Materiel WHERE ID_Mat = @ID_Mat";
            con.Open();
            com.Parameters.Add("@ID_Mat", SqlDbType.Int).Value = id_materiel;
            SqlDataReader dataReader = com.ExecuteReader();
            if (dataReader.Read())
            {
                TBModifMat_Materiel.Text = dataReader["Nom"].ToString();
                TBModifMat_NumSerie.Text = dataReader["NoSerie"].ToString();
                CBModifMat_TMateriel.Text = dataReader["NomType"].ToString();
                CBModifMat_Site.Text = dataReader["Site"].ToString();
                CBModifMat_Client.Text = dataReader["Client"].ToString();
                DTPModifMateriel_Date.Text = dataReader["Date_installation"].ToString();
                RTBModifMat_Desc.Text = dataReader["description"].ToString();
            }

        }

        private void BModifMat_OK_Click(object sender, EventArgs e)
        {
            String Strcom = "UPDATE dbo.Materiel SET Nom = @Matériel, NoSerie = @NSerie, Date_Installation = @Date, description = @Desc, NomType = @TypeMat, Site = @Site   WHERE ID_Mat = @ID_Mat";
            SqlConnection con = new SqlConnection(conn);
            SqlCommand com = new SqlCommand(Strcom, con);
            SqlDataReader myReader;
            com.Parameters.Add("@ID_Mat", SqlDbType.Int).Value = idmat;
            com.Parameters.AddWithValue("@Date", DTPModifMateriel_Date.Text);
            com.Parameters.AddWithValue("@Client", CBModifMat_Client.Text);
            com.Parameters.AddWithValue("@Matériel", TBModifMat_Materiel.Text);
            com.Parameters.AddWithValue("@TypeMat", CBModifMat_TMateriel.Text);
            com.Parameters.AddWithValue("@Site", CBModifMat_Site.Text);
            com.Parameters.AddWithValue("@NSerie", TBModifMat_NumSerie.Text);
            com.Parameters.AddWithValue("@Desc", RTBModifMat_Desc.Text);


            try
            {
                con.Open();
                myReader = com.ExecuteReader();
                MessageBox.Show("Modifié dans les interventions");
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


        private void BModifInter_Annul_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BModifInter_Annul_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BModifMat_Annul_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
