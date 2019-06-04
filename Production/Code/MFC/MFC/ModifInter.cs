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
    public partial class ModifInterWind : Form
    {
        public ModifInterWind()
        {
            InitializeComponent();
        }
        string conn = ("Data Source= .\\SQLEXPRESS;Initial Catalog = MFC; Integrated Security = True");

        int idinter;
        public ModifInterWind(int id_intervention)
        {
            idinter = id_intervention;
            InitializeComponent();
            SqlConnection con = new SqlConnection(conn);
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT * FROM Intervention WHERE ID_Intervention = @ID_Intervention";
            con.Open();
            com.Parameters.Add("@ID_Intervention", SqlDbType.Int).Value = id_intervention;
            SqlDataReader dataReader = com.ExecuteReader();
            if (dataReader.Read())
            {
                CBModifInter_Client.Text = dataReader["Client"].ToString();
                CBModifInter_Matériel.Text = dataReader["Materiel"].ToString();
                CBModifInter_TMateriel.Text = dataReader["Type_Materiel"].ToString();
                CBModifInter_Site.Text = dataReader["Site"].ToString();
                DTPModifInter_Date.Text = dataReader["Date_Planifiee"].ToString();

            }
            con.Close();
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
                    CBModifInter_Client.Items.Add(dr["Client"].ToString());
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
                    CBModifInter_Site.Items.Add(dr["Nom"].ToString());
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
                    CBModifInter_Matériel.Items.Add(dr["Nom"].ToString());
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
                    CBModifInter_TMateriel.Items.Add(dr["Nom"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BModifInter_OK_Click(object sender, EventArgs e)
        {
            String Strcom = "UPDATE dbo.Intervention SET Date_planifiee = @Date, Date_realisation = NULL, Commentaire = NULL, Client = @Client, Materiel = @Matériel, Type_Materiel = @TypeMat, Site = @Site, Statut = 'En Cours'  WHERE ID_Intervention = @ID_Intervention";
            SqlConnection con = new SqlConnection(conn);
            SqlCommand com = new SqlCommand(Strcom, con);
            SqlDataReader myReader;
            com.Parameters.Add("@ID_Intervention", SqlDbType.Int).Value = idinter;
            com.Parameters.AddWithValue("@Date", DTPModifInter_Date.Text);
            com.Parameters.AddWithValue("@Client", CBModifInter_Client.Text);
            com.Parameters.AddWithValue("@Matériel", CBModifInter_Matériel.Text);
            com.Parameters.AddWithValue("@TypeMat", CBModifInter_TMateriel.Text);
            com.Parameters.AddWithValue("@Site", CBModifInter_Site.Text);


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

        private void ModifInterWind_Load(object sender, EventArgs e)
        {
            //entraine des erreur. Ne reprends pas la ligne selectionnée mais permet de choisir parmi les client. Sans ce code, 
            //Il reprends la ligne sélectionnée mais ne permet pas de choisir de client.
            // TODO: This line of code loads data into the 'dsetInter.Intervention' table. You can move, or remove it, as needed.
            this.interventionTableAdapter.Fill(this.dsetInter.Intervention);
            // TODO: This line of code loads data into the 'dsetTmat.Type_Materiel' table. You can move, or remove it, as needed.
            this.type_MaterielTableAdapter.Fill(this.dsetTmat.Type_Materiel);
            // TODO: This line of code loads data into the 'dsetMat.Materiel' table. You can move, or remove it, as needed.
            this.materielTableAdapter.Fill(this.dsetMat.Materiel);
            // TODO: This line of code loads data into the 'dsetSite.Site' table. You can move, or remove it, as needed.
            this.siteTableAdapter.Fill(this.dsetSite.Site);
            // TODO: This line of code loads data into the 'dsetClient.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.dsetClient.Client);

        }

        private void BModifInter_Annul_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

