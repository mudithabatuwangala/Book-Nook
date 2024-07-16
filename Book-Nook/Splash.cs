using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Nook
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Enabled = true;
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {
                splashTimer.Enabled = false;
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
