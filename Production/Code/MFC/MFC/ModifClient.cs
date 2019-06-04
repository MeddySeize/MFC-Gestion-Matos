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
    public partial class ModifClientWind : Form
    {
        public ModifClientWind()
        {
            InitializeComponent();
        }

        string conn = ("Data Source= .\\SQLEXPRESS;Initial Catalog = MFC; Integrated Security = True");

        int idclient;
        public ModifClientWind(int id_Client)
        {
            idclient = id_Client;
            InitializeComponent();
            SqlConnection con = new SqlConnection(conn);
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT * FROM Client WHERE ID_Client = @ID_Client";
            con.Open();
            com.Parameters.Add("@ID_Client", SqlDbType.Int).Value = id_Client;
            SqlDataReader dataReader = com.ExecuteReader();
            if (dataReader.Read())
            {
                TBModifClient_Cli.Text = dataReader["Client"].ToString();
                TBModifClient_Email.Text = dataReader["Email"].ToString();
                TBModifClient_Tel.Text = dataReader["Telephone"].ToString();
            }

        }
    

        private void BModifClient_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void BModifClient_OK_Click(object sender, EventArgs e)
        {
                String Strcom = "UPDATE dbo.Materiel SET Client = @Client, Email = @Email, Tel = @Tel  WHERE ID_Client = @ID_Client";
                SqlConnection con = new SqlConnection(conn);
                SqlCommand com = new SqlCommand(Strcom, con);
                SqlDataReader myReader;
                com.Parameters.Add("@ID_Client", SqlDbType.Int).Value = idclient;
                com.Parameters.AddWithValue("@Client", TBModifClient_Cli.Text);
                com.Parameters.AddWithValue("@Email", TBModifClient_Email.Text);
                com.Parameters.AddWithValue("@Tel", TBModifClient_Tel.Text);


                try
                {
                    con.Open();
                    myReader = com.ExecuteReader();
                    MessageBox.Show("Modifiés dans les clients");
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
    }
 }

