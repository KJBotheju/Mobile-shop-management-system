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

namespace Mobile_shop_management_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("select * from tblLogin where userName = @userName and password = @password", con);
                    cmd.Parameters.AddWithValue("@userName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login successfully");
                        Mobile m = new Mobile();
                        m.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("User name or password is invalid");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            signUp s = new signUp();
            s.Show();
            this.Hide();
        }
    }
}
