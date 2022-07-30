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
    public partial class Staff_form : Form
    {
        public Staff_form()
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

        private void button_member_Click(object sender, EventArgs e)
        {


            Member_form m = new Member_form();
            m.Show();
            this.Hide();
        }

        private void button_equipment_Click(object sender, EventArgs e)
        {

            Equipment_form eq = new Equipment_form();
            eq.Show();
            this.Hide();
        }

        private void button_employee_Click(object sender, EventArgs e)
        {

            Employee_form emmp = new Employee_form();
            emmp.Show();
            this.Hide();
        }


        GYM_MANAGEMEN_dbEntities gdb = new GYM_MANAGEMEN_dbEntities();
        staff s = new staff();
        private void Staff_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.staff);

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string x;
            if (radiom.Checked)
            {
                x = "male";
            }
            else
            { x = "female"; }
            if (TextBox_name.Text == "" || TextBox_lname.Text == "" || datetime_join.Value.Date == null || radiom.Checked == false && radiof.Checked == false)
            {
                MessageBox.Show("Please Enter name or lname or datejoin or gendre", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                s.f_name = TextBox_name.Text;
                s.l_name = TextBox_lname.Text;
                s.gender = x;
                s.date_birth = guna2DateTimePicker1.Value.Date;
                s.mobile = TextBox_mobile.Text;
                s.email = TextBox_email.Text;
                s.join_dat = datetime_join.Value.Date;
                s.adress = TextBox_adress.Text;
                s.job = combobox_job.Text;
                s.emp_id = Program.id_emp;
                gdb.staffs.Add(s);
                gdb.SaveChanges();

            }
            // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.staff);

        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string gendre;

            try
            {

                gendre = DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (gendre == "female")
                {
                    radiof.Checked = true;
                }
                else
                {
                    radiom.Checked = true;
                }

                TextBox_id.Text = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                TextBox_name.Text = DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                TextBox_lname.Text = DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                guna2DateTimePicker1.Text = DataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                TextBox_mobile.Text = DataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                TextBox_email.Text = DataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                datetime_join.Text = DataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                TextBox_adress.Text = DataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                combobox_job.Text = DataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                TextBox_empid.Text = DataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();

            }
            catch (Exception ex)
            {
            }
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

            if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_lname.Text == "" || datetime_join.Value.Date == null || radiom.Checked == false && radiof.Checked == false)
            {
                MessageBox.Show("Please Enter id and name and lname and datejoin and gendre", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id;
                id = Convert.ToInt32(TextBox_id.Text);

                staff s = (from st in gdb.staffs where st.stf_id == id select st).First();

                s.f_name = TextBox_name.Text;
                s.l_name = TextBox_lname.Text;
                s.gender = x;
                s.date_birth = guna2DateTimePicker1.Value.Date;
                s.mobile = TextBox_mobile.Text;
                s.email = TextBox_email.Text;
                s.join_dat = datetime_join.Value.Date;
                s.adress = TextBox_adress.Text;
                s.job = combobox_job.SelectedItem.ToString();
                s.emp_id = Program.id_emp;

                gdb.SaveChanges();
                // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.staff' table. You can move, or remove it, as needed.
                this.staffTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.staff);

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {


            if (TextBox_id.Text == "")
            {
                MessageBox.Show("Please Select id ", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id;
                id = Convert.ToInt32(TextBox_id.Text);
                staff s = (from st in gdb.staffs where st.stf_id == id select st).First();
                gdb.staffs.Remove(s);
                gdb.SaveChanges();


                //clear
                TextBox_id.Text = "";
                TextBox_name.Text = "";
                TextBox_lname.Text = "";
                radiof.Checked = false;
                radiom.Checked = false;
                guna2DateTimePicker1.Text = "";
                TextBox_mobile.Text = "";
                TextBox_email.Text = "";
                datetime_join.Text = "";
                TextBox_adress.Text = "";
                combobox_job.Text = "";
                TextBox_empid.Text = "";

                // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.staff' table. You can move, or remove it, as needed.
                this.staffTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.staff);

            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {

            TextBox_id.Text = "";
            TextBox_name.Text = "";
            TextBox_lname.Text = "";
            radiof.Checked = false;
            radiom.Checked = false;
            guna2DateTimePicker1.Text = "";
            TextBox_mobile.Text = "";
            TextBox_email.Text = "";
            datetime_join.Text = "";
            TextBox_adress.Text = "";
            combobox_job.Text = "";
            TextBox_empid.Text = "";
        }
    }
}
