using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Mobile_shop_management_system
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {


        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter a user name");

            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter a password");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-UL8UPEK\\SQLEXPRESS;Initial Catalog=LoginForm;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[tblLogin]
           ([userName]
           ,[password])
     VALUES
           ('" + txtUserName.Text + "','" + txtPassword.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Sign Up successfully");
                    Login l = new Login();
                    l.Show();
                    this.Hide();
                    //SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //DataTable dt = new DataTable();

                    //da.Fill(dt);

                    //cmd.ExecuteNonQuery();

                    /*if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Sign Up successfully");
                        Login l = new Login();
                        l.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Please enter valid user name and password");
                    }*/

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }
            }
        }
    }
}
