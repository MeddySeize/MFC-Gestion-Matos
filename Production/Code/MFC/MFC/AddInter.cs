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
    public partial class AddInterWind : Form
    {
        public AddInterWind()
        {
            InitializeComponent();
            FillComboClient();
            FillComboSite();
            FillComboMateriel();
            FillComboTMateriel();
        }
        

           
        string conn = ("Data Source=.\\SQLEXPRESS;Initial Catalog = MFC; Integrated Security = True");

        void FillComboClient()
        {
        
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT Client FROM Client";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da  = new SqlDataAdapter(com);
            da.Fill(dt);
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    CBAddInter_Client.Items.Add(dr["Client"].ToString());
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
                    CBAddInter_Site.Items.Add(dr["Nom"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FillComboMateriel()
        {

            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT * FROM Materiel";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    CBAddInter_Matériel.Items.Add(dr["Nom"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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
                    CBAddInter_TMateriel.Items.Add(dr["Nom"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BAddInter_Annul_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAddInter_OK_Click(object sender, EventArgs e)
        {
       
            String Strcom = " INSERT INTO dbo.Intervention(Date_planifiee, Date_realisation, Commentaire, Client, Materiel, Type_Materiel, Site, Statut) VALUES(@Date, NULL, NULL, @Client,@Matériel,@TypeMat,@Site,'En Cours');";
            SqlConnection con = new SqlConnection(conn);
            SqlCommand com = new SqlCommand(Strcom, con);
            SqlDataReader myReader;
            com.Parameters.AddWithValue("@Date", DTPAddInter.Text);
            com.Parameters.AddWithValue("@Client", CBAddInter_Client.Text);
            com.Parameters.AddWithValue("@Matériel", CBAddInter_Matériel.Text);
            com.Parameters.AddWithValue("@TypeMat", CBAddInter_TMateriel.Text);
            com.Parameters.AddWithValue("@Site",  CBAddInter_Site.Text);

            try
            {
                con.Open();
                myReader = com.ExecuteReader();
                MessageBox.Show("Enregistré dans les interventions");
                
                while (myReader.Read())
                {
                    this.Close();
                    myReader.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

   
    }
}
