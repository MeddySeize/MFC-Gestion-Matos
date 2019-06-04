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
    public partial class AddClientWind : Form
    {
        public AddClientWind()
        {
            InitializeComponent();
        }
        string conn = ("Data Source=.\\SQLEXPRESS;Initial Catalog = MFC; Integrated Security = True");
        private void BAddClient_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAddClient_OK_Click(object sender, EventArgs e)
        {
            String Strcom = " INSERT INTO dbo.Client(Client, Telephone, Email) VALUES(@Client, @Tel, @Email);";
            SqlConnection con = new SqlConnection(conn);
            SqlCommand com = new SqlCommand(Strcom, con);
            SqlDataReader myReader;
            com.Parameters.AddWithValue("@Tel", TBAddClient_Tel.Text);
            com.Parameters.AddWithValue("@Client", TBAddClient_Cli.Text) ;
            com.Parameters.AddWithValue("@Email", TBAddClient_Email.Text);
            try
            {
                con.Open();
                myReader = com.ExecuteReader();
                MessageBox.Show("saved");

                while (myReader.Read())
                {
                    //J'essaye d'actualiser le Data Grid
                    SqlDataAdapter daptInter = new SqlDataAdapter("SELECT * FROM Client", con);
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
