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
    public partial class Member_form : Form
    {
        public Member_form()
        {
            InitializeComponent();
        }
        GYM_MANAGEMEN_dbEntities gdb = new GYM_MANAGEMEN_dbEntities();
        member m = new member();
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

        private void button_employee_Click(object sender, EventArgs e)
        {


            Employee_form emmp = new Employee_form();
            emmp.Show();
            this.Hide();
        }

        private void Member_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.members);

        }

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
            if (TextBox_name.Text == "" || TextBox_lname.Text == "" || datetime_join.Value.Date == null || radiom.Checked == false && radiof.Checked == false)
            {
                MessageBox.Show("Please Enter name or lname or datejoin or gendre", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                m.f_name = TextBox_name.Text;
                m.l_name = TextBox_lname.Text;
                m.gender = x;
                m.date_birth = guna2DateTimePicker1.Value.Date;
                m.mobile = TextBox_mobile.Text;
                m.email = TextBox_email.Text;
                m.join_date = datetime_join.Value.Date;
                m.gym_time = TextBox_gymytime.Text;
                m.address = TextBox_adress.Text;
                m.emp_id = Program.id_emp;
                gdb.members.Add(m);
                gdb.SaveChanges();
            }
                // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.members' table. You can move, or remove it, as needed.
              this.membersTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.members);
        }

        private void DataGridView_member_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string gendre;

            try
            {

                gendre = DataGridView_member.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (gendre == "female")
                {
                    radiof.Checked = true;
                }
                else
                {
                    radiom.Checked = true;
                }

                TextBox_id.Text = DataGridView_member.Rows[e.RowIndex].Cells[0].Value.ToString();
                TextBox_name.Text = DataGridView_member.Rows[e.RowIndex].Cells[1].Value.ToString();
                TextBox_lname.Text = DataGridView_member.Rows[e.RowIndex].Cells[2].Value.ToString();
                guna2DateTimePicker1.Text = DataGridView_member.Rows[e.RowIndex].Cells[4].Value.ToString();
                TextBox_mobile.Text = DataGridView_member.Rows[e.RowIndex].Cells[5].Value.ToString();
                TextBox_email.Text = DataGridView_member.Rows[e.RowIndex].Cells[6].Value.ToString();
                datetime_join.Text = DataGridView_member.Rows[e.RowIndex].Cells[7].Value.ToString();
                TextBox_gymytime.Text = DataGridView_member.Rows[e.RowIndex].Cells[8].Value.ToString();
                TextBox_adress.Text = DataGridView_member.Rows[e.RowIndex].Cells[9].Value.ToString();
                TextBox_empid.Text = DataGridView_member.Rows[e.RowIndex].Cells[10].Value.ToString();
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

                member m = (from mm in gdb.members where mm.m_id == id select mm).First();

                m.f_name = TextBox_name.Text;
                m.l_name = TextBox_lname.Text;
                m.gender = x;
                m.date_birth = guna2DateTimePicker1.Value.Date;
                m.mobile = TextBox_mobile.Text;
                m.email = TextBox_email.Text;
                m.join_date = datetime_join.Value.Date;
                m.gym_time = TextBox_gymytime.Text;
                m.address = TextBox_adress.Text;
                m.emp_id = Program.id_emp;

                gdb.SaveChanges();
                // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.members' table. You can move, or remove it, as needed.
                this.membersTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.members);
            

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
                member m = (from mm in gdb.members where mm.m_id == id select mm).First();
                gdb.members.Remove(m);
                gdb.SaveChanges();

                this.membersTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.members);
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
                TextBox_gymytime.Text = "";
                TextBox_adress.Text = "";
                TextBox_empid.Text = "";
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
            TextBox_gymytime.Text = "";
            TextBox_adress.Text = "";
            TextBox_empid.Text = "";
        }
    }
}
