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
    public partial class AddMatWind : Form
    {
        public AddMatWind()
        {
            InitializeComponent();
            FillComboTMateriel();
            FillComboClient();
            FillComboSite();
        }
        string conn = ("Data Source=DESKTOP-877GOHO\\SQLEXPRESS;Initial Catalog = MFC; Integrated Security = True");

        void FillComboTMateriel()
        {

            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT * FROM Type_Materiel";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    CBAddMat_TMateriel.Items.Add(dr["Nom"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FillComboClient()
        {

            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT Client FROM Client";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    CBAddMat_Client.Items.Add(dr["Client"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FillComboSite()
        {

            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT * FROM Site";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    CBAddMat_Site.Items.Add(dr["Nom"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Strcom = " INSERT INTO dbo.Materiel(Nom,NoSerie,Date_Installation,description,NomType,Client,Site) VALUES(@NMat,@NumSerie,@Date,@Desc,@TypeMat,@Client,@Site);";
            SqlConnection con = new SqlConnection(conn);
            SqlCommand com = new SqlCommand(Strcom, con);
            SqlDataReader myReader;
            //Assigner le texte d'un élément du formulaire 
            com.Parameters.AddWithValue("@NMat", TBAddMat_Materiel.Text);
            com.Parameters.AddWithValue("@NumSerie", TBAddMat_NumSerie.Text);
            com.Parameters.AddWithValue("@Client", CBAddMat_Client.Text);
            com.Parameters.AddWithValue("@TypeMat", CBAddMat_TMateriel.Text);
            com.Parameters.AddWithValue("@Site", CBAddMat_Site.Text);
            com.Parameters.AddWithValue("@Desc", RTBAddMateriel_Desc.Text);
            com.Parameters.AddWithValue("@Date", DTPAddMateriel.Text);

            try
            {
                con.Open();
                myReader = com.ExecuteReader();
                MessageBox.Show("Enregistré dans Matériel");

                while (myReader.Read())
                {
                    
                    myReader.Close();
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
