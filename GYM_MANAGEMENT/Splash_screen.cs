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
    public partial class Splash_screen : Form
    {
        public Splash_screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //641
            panel3.Width += 3;
            if(panel3.Width >= 641)
            {
                timer1.Stop();
                Login l = new Login();
                this.Hide();
                l.Show();
            }
        }
    }
}
