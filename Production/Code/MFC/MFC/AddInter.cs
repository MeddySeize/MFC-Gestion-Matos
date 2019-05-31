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
        }
        string conn = ("Data Source=DESKTOP-877GOHO\\SQLEXPRESS;Initial Catalog = MFC; Integrated Security = True");

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
            com.Parameters.AddWithValue("@Client", TBAddInter_Client.Text);
            com.Parameters.AddWithValue("@Matériel", TBAddInter_Mat.Text);
            com.Parameters.AddWithValue("@TypeMat", TBAddInter_TMat.Text);
            com.Parameters.AddWithValue("@Site", TBAddInter_Site.Text);
      
            try
            {
                con.Open();
                myReader = com.ExecuteReader();
                MessageBox.Show("saved");
                
                while (myReader.Read())
                {
                    SqlDataAdapter daptInter = new SqlDataAdapter("SELECT * FROM Intervention", con);
                    DataTable dtablInt = new DataTable();
                    daptInter.Fill(dtablInt);
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
