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
    public partial class Equipment_form : Form
    {
        public Equipment_form()
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

        private void button_staff__Click(object sender, EventArgs e)
        {
            Staff_form s = new Staff_form();
            s.Show();
            this.Hide();
        }

        private void button_employee_Click(object sender, EventArgs e)
        {

            Employee_form emmp = new Employee_form();
            emmp.Show();
            this.Hide();
        }

        private void Equipment_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.vendor' table. You can move, or remove it, as needed.
            this.vendorTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.vendor);
            // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.equipment);

        }
        GYM_MANAGEMEN_dbEntities gdb = new GYM_MANAGEMEN_dbEntities();
        vendor v = new vendor();
        private void button_addv_Click(object sender, EventArgs e)
        {

            if (TextBox_namev.Text == "" || TextBox_lnamev.Text == "")
            {
                MessageBox.Show("Please Enter  Name or Last Name ", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                v.f_name = TextBox_namev.Text;
                v.l_name = TextBox_lnamev.Text;
                v.mobile = TextBox_mobile.Text;
                v.email = TextBox_email.Text;
                v.adress = TextBox_adress.Text;
                v.company = TextBox_c.Text;
                gdb.vendors.Add(v);
                gdb.SaveChanges();

                // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.vendor' table. You can move, or remove it, as needed.
                this.vendorTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.vendor);
            }
        }

        private void button_upv_Click(object sender, EventArgs e)
        {

            if (TextBox_idv.Text == "" || TextBox_namev.Text == "" || TextBox_lnamev.Text == "")
            {
                MessageBox.Show("Please Enter Id or Name or Last Name ", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idv;
                idv = Convert.ToInt32(TextBox_idv.Text);

                vendor v = (from vv in gdb.vendors where vv.v_id == idv select vv).First();

                v.f_name = TextBox_namev.Text;
                v.l_name = TextBox_lnamev.Text;
                v.mobile = TextBox_mobile.Text;
                v.email = TextBox_email.Text;
                v.adress = TextBox_adress.Text;
                v.company = TextBox_c.Text;

                gdb.SaveChanges();
                // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.vendor' table. You can move, or remove it, as needed.
                this.vendorTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.vendor);

            }
        }

        private void button_deletev_Click(object sender, EventArgs e)
        {

            int idv;
            idv = Convert.ToInt32(TextBox_idv.Text);

            if (TextBox_idv.Text == "")
            {
                MessageBox.Show("you can't delete this vendor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                vendor v = (from vv in gdb.vendors where vv.v_id == idv select vv).First();
                gdb.vendors.Remove(v);
                gdb.SaveChanges();

                // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.vendor' table. You can move, or remove it, as needed.
                this.vendorTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.vendor);

                //clear
                TextBox_idv.Text = "";
                TextBox_namev.Text = "";
                TextBox_lnamev.Text = "";
                TextBox_mobile.Text = "";
                TextBox_email.Text = "";
                TextBox_adress.Text = "";
                TextBox_c.Text = "";



            }
        }

        private void button_clearv_Click(object sender, EventArgs e)
        {
            //clear
            TextBox_idv.Text = "";
            TextBox_namev.Text = "";
            TextBox_lnamev.Text = "";
            TextBox_mobile.Text = "";
            TextBox_email.Text = "";
            TextBox_adress.Text = "";
            TextBox_c.Text = "";

        }
        int indice = 0;
        List<vendor> v1 = new List<vendor>();
        void select()
        {

            v1 = gdb.vendors.ToList();
            TextBox_idv.Text = v1[indice].v_id.ToString();
            TextBox_namev.Text = v1[indice].f_name.ToString();
            TextBox_lnamev.Text = v1[indice].l_name.ToString();
            TextBox_mobile.Text = v1[indice].mobile.ToString();
            TextBox_email.Text = v1[indice].email.ToString();
            TextBox_adress.Text = v1[indice].adress.ToString();
            TextBox_c.Text = v1[indice].company.ToString();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (indice < v1.Count - 1)
                {
                    indice++;

                }
                select();

            }
            catch (Exception ex)
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                if (indice > 0)
                {
                    indice--;
                }
                select();

            }
            catch (Exception ex)
            {
            }
        }

        // ___________________eq_______________________________________

        GYM_MANAGEMEN_dbEntities gdb1 = new GYM_MANAGEMEN_dbEntities();
        equipment eq = new equipment();
        private void button_add_Click(object sender, EventArgs e)
        {

            if (TextBox_name.Text == "" || TextBox_desc.Text == "" || TextBox_used.Text == "" || TextBox_cos.Text == "")
            {
                MessageBox.Show("Please Enter Name or Des or Used or Cos ", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                eq.name = TextBox_name.Text;
                eq.description = TextBox_desc.Text;
                eq.used = TextBox_used.Text;
                eq.cost = TextBox_cos.Text;
                eq.emp_id = Program.id_emp;
                eq.v_id = Convert.ToInt32(comboBox1.SelectedValue);

                gdb1.equipments.Add(eq);
                gdb1.SaveChanges();

                // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.equipment' table. You can move, or remove it, as needed.
                this.equipmentTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.equipment);

            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                TextBox_id.Text = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                TextBox_name.Text = DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                TextBox_desc.Text = DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                TextBox_used.Text = DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                TextBox_cos.Text = DataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                TextBox_empid.Text = DataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                comboBox1.SelectedValue = DataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            catch (Exception ex)
            {
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {

            if (TextBox_name.Text == "" || TextBox_desc.Text == "" || TextBox_used.Text == "" || TextBox_cos.Text == "")
            {
                MessageBox.Show("Please Enter Name or Des or Used or Cos ", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    int id_e;
                    id_e = Convert.ToInt32(TextBox_id.Text);

                    equipment eq = (from eqq in gdb1.equipments where eqq.v_id == id_e select eqq).First();


                    eq.name = TextBox_name.Text;
                    eq.description = TextBox_desc.Text;
                    eq.used = TextBox_used.Text;
                    eq.cost = TextBox_cos.Text;
                    eq.emp_id = Program.id_emp;
                    eq.v_id = Convert.ToInt32(comboBox1.SelectedValue);


                    gdb1.SaveChanges();
                    // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.equipment' table. You can move, or remove it, as needed.
                    this.equipmentTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.equipment);

                }
                catch (Exception ex)
                {
                }

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

            if (TextBox_name.Text == "" || TextBox_desc.Text == "" || TextBox_used.Text == "" || TextBox_cos.Text == "")
            {
                MessageBox.Show("Please Enter Name or Des or Used or Cos ", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int id_e;
                id_e = Convert.ToInt32(TextBox_id.Text);
                equipment eq = (from eqq in gdb1.equipments where eqq.eqp_id == id_e select eqq).First();

                gdb1.equipments.Remove(eq);
                gdb1.SaveChanges();


                gdb1.SaveChanges();
                // TODO: This line of code loads data into the 'gYM_MANAGEMEN_dbDataSet.equipment' table. You can move, or remove it, as needed.
                this.equipmentTableAdapter.Fill(this.gYM_MANAGEMEN_dbDataSet.equipment);

                TextBox_id.Text = "";
                TextBox_name.Text = "";
                TextBox_desc.Text = "";
                TextBox_used.Text = "";
                TextBox_cos.Text = "";
                TextBox_empid.Text = "";
                //comboBox1.Text ="";

            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = "";
            TextBox_name.Text = "";
            TextBox_desc.Text = "";
            TextBox_used.Text = "";
            TextBox_cos.Text = "";
            TextBox_empid.Text = "";
            //comboBox1.Text ="";
        }

        private void TextBox_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_used_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
