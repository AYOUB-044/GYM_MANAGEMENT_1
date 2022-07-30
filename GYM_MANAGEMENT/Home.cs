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
    public partial class Home : Form
    {
        public Home()
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

        private void Home_Load(object sender, EventArgs e)
        {
            GYM_MANAGEMEN_dbEntities gdb = new GYM_MANAGEMEN_dbEntities();

            int id_emp2 = Program.id_emp;
            employee emp = (from pp in gdb.employees where pp.emp_id == id_emp2 select pp).First();
            label_user.Text = emp.name.ToString();
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

        private void button_equipment_Click(object sender, EventArgs e)
        {

            Equipment_form eq = new Equipment_form();
            eq.Show();
            this.Hide();
        }
    }
}
