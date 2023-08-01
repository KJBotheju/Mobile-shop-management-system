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

namespace Mobile_shop_management_system
{
    public partial class Mobile : Form
    {
        public Mobile()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UL8UPEK\\SQLEXPRESS;Initial Catalog=LoginForm;Integrated Security=True");

        private void Mobile_Load(object sender, EventArgs e)
        {
            addTable();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (idtb.Text == "" || brandtb.Text == "" || modeltb.Text == "" || pricetb.Text == "" || stocktb.Text == "" || ramcb.SelectedItem.ToString() == "" || romcb.SelectedItem.ToString() == "" || cameratb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    String sql = "insert into tblMobile values('" + idtb.Text + "','" + brandtb.Text + "','" + modeltb.Text + "','" + pricetb.Text + "','" + stocktb.Text + "','" + ramcb.SelectedItem.ToString() + "','" + romcb.SelectedItem.ToString() + "','" + cameratb.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("added successfully");

                    con.Close();
                    addTable();
                    idtb.Text = "";
                    brandtb.Text = "";
                    modeltb.Text = "";
                    pricetb.Text = "";
                    stocktb.Text = "";
                    ramcb.SelectedText = "";
                    romcb.SelectedText = "";
                    cameratb.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void addTable()
        {
            con.Open();
            string query = "select * from tblMobile";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            mobileGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            idtb.Text = "";
            brandtb.Text = "";
            modeltb.Text = "";
            pricetb.Text = "";
            stocktb.Text = "";
            ramcb.SelectedText = "";
            romcb.SelectedText = "";
            cameratb.Text = "";
        }

        private void mobileGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
