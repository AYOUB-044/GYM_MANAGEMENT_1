using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_MANAGEMENT
{
    public partial class Employee_form : Form
    {
        public Employee_form()
        {
            InitializeComponent();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            Program.id_emp = 0;


            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void Employee_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.employee);

        }

        private void button_member_Click(object sender, EventArgs e)
        {

            Member_form m = new Member_form();
            m.Show();
            this.Hide();

        }

        private void button_staff__Click(object sender, EventArgs e)
        {
            Staff_form s = new Staff_form();
            s.Show();
            this.Hide();
        }

        private void button_equipment_Click(object sender, EventArgs e)
        {

            Equipment_form eq = new Equipment_form();
            eq.Show();
            this.Hide();
        }
        GYM_MANAGEMEN_dbEntities gdb = new GYM_MANAGEMEN_dbEntities();
        employee emp = new employee();
        private void button_add_Click(object sender, EventArgs e)
        {


            string x;
            if (radiom.Checked)
            {
                x = "male";
            }
            else
            { x = "female";
            }
            if (TextBox_name.Text == "" || TextBox_pass.Text == "" || TextBox_user.Text == "" || datetime_join.Value.Date == null || radiom.Checked == false && radiof.Checked == false)
            {
                MessageBox.Show("Please Enter Name or User_N or Pssword or datejoin or gendre", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                emp.emp_username = TextBox_user.Text;
                emp.name = TextBox_name.Text;
                emp.password = TextBox_pass.Text;
                emp.gender = x;
                emp.email = TextBox_email.Text;
                emp.mobile = TextBox_mobile.Text;
                emp.address = TextBox_adress.Text;
                emp.date = datetime_join.Value.Date;
                gdb.employees.Add(emp);
                gdb.SaveChanges();
            }

                // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.employee' table. You can move, or remove it, as needed.
                this.employeeTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.employee);
        }

        private void button_update_Click(object sender, EventArgs e)
        {


            string x;

            if (radiom.Checked)
            {
                x = "male";
            }
            else
            {
                x = "female";
            }

            if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_pass.Text == "" || TextBox_user.Text == "" || datetime_join.Value.Date == null || radiom.Checked == false && radiof.Checked == false)
            {
                MessageBox.Show("Please Enter id or Name or User_N or Pssword or datejoin or gendre", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.id_emp == Convert.ToInt32(TextBox_id.Text))
            {
                MessageBox.Show("you can't Update this employe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id;
                id = Convert.ToInt32(TextBox_id.Text);
                employee emp = (from em in gdb.employees where em.emp_id == id select em).First();

                emp.emp_username = TextBox_user.Text;
                emp.name = TextBox_name.Text;
                emp.password = TextBox_pass.Text;
                emp.gender = x;
                emp.email = TextBox_email.Text;
                emp.mobile = TextBox_mobile.Text;
                emp.address = TextBox_adress.Text;
                emp.date = datetime_join.Value.Date;

                gdb.SaveChanges();

                // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.employee' table. You can move, or remove it, as needed.
                this.employeeTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.employee);
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {


            if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_pass.Text == "" || TextBox_user.Text == "" || datetime_join.Value.Date == null || radiom.Checked == false && radiof.Checked == false)
            {
                MessageBox.Show("Please Enter id or Name or User_N or Pssword or datejoin or gendre", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.id_emp == Convert.ToInt32(TextBox_id.Text))
            {
                MessageBox.Show("you can't Delete this employe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id;
                id = Convert.ToInt32(TextBox_id.Text);

                employee emp = (from em in gdb.employees where em.emp_id == id select em).First();
                gdb.employees.Remove(emp);
                gdb.SaveChanges();


                //clear
                TextBox_id.Text = "";
                TextBox_name.Text = "";
                TextBox_user.Text = "";
                TextBox_pass.Text = "";
                radiof.Checked = false;
                radiom.Checked = false;
                TextBox_email.Text = "";
                TextBox_mobile.Text = "";
                datetime_join.Text = "";
                TextBox_adress.Text = "";

                // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.employee' table. You can move, or remove it, as needed.
                this.employeeTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.employee);

            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            string gendre;

            try
            {

                gendre = DataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (gendre == "female")
                {
                    radiof.Checked = true;
                }
                else
                {
                    radiom.Checked = true;
                }

                TextBox_id.Text = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                TextBox_user.Text = DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                TextBox_name.Text = DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                TextBox_pass.Text = DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                TextBox_email.Text = DataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                TextBox_mobile.Text = DataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                TextBox_adress.Text = DataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                datetime_join.Text = DataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();

            }
            catch (Exception ex)
            {
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {

            //clear
            TextBox_id.Text = "";
            TextBox_name.Text = "";
            TextBox_user.Text = "";
            TextBox_pass.Text = "";
            radiof.Checked = false;
            radiom.Checked = false;
            TextBox_email.Text = "";
            TextBox_mobile.Text = "";
            datetime_join.Text = "";
            TextBox_adress.Text = "";
        }
    }
}
