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

namespace GYM_MANAGEMENT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection();

        SqlCommand comm = new SqlCommand();

        private void Button_login_Click(object sender, EventArgs e)
        {

            try
            {

                if (TextBox_username.Text == "" || TextBox_password.Text == "")
                {
                    MessageBox.Show("Please Enter Username and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    // connect

                    cn.Open();
                    comm.CommandText = "select * from Employee";
                    comm.Connection = cn;
                    SqlDataReader dr;
                    DataTable dt = new DataTable();
                    dr = comm.ExecuteReader();
                    dt.Load(dr);
                    cn.Close();
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (TextBox_username.Text == dt.Rows[i][1].ToString() && TextBox_password.Text == dt.Rows[i][3].ToString())
                            {
                                Program.id_emp = Convert.ToInt32(dt.Rows[i][0]);

                                Home h = new Home();
                                this.Hide();
                                h.ShowDialog();
                                
                                //this.Close();

                            }

                        }

                    }

                }
            }
            catch (Exception ex)
            {
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Data Source=MOB\SQLEXPRESS;Initial Catalog=GYM_MANAGEMEN_db;Integrated Security=True";

        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
