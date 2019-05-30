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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }
        //On se connecte sur le serveur et on indique la BDD
        string conn = ("Data Source=SILVERDELL\\SQLEXPRESS;Initial Catalog = MFC; Integrated Security = True");

        private void LoginBut_Click(object sender, EventArgs e)
        {

            try
            {
                //COLLATE pour avoir une case sensitive sur le mdp
                String Strcom = "SELECT * FROM Admin WHERE Admin_user=@UserId and Admin_Mdp=@UserMdp COLLATE SQL_latin1_General_CP1_CS_AS";

                SqlConnection con = new SqlConnection(conn);
                SqlCommand com = new SqlCommand(Strcom, con);
                con.Open();

                com.Parameters.AddWithValue("@UserId", UText.Text);
                com.Parameters.AddWithValue("@UserMdp", Ptext.Text);


                SqlDataAdapter adp = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                con.Close();

                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                   MFCWind f1 = new MFCWind();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Identifiant/Mdp Incorrects");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
