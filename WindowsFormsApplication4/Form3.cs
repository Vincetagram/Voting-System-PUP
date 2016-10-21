using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Frm_Admin : Form
    {
        public Frm_Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tb_pass.Text == "k9n6pgm2v1") && (tb_user.Text == "ADMIN"))
            {
                MessageBox.Show("LOGIN SUCCESSFULLY.");
                new Frm_adminselect().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("INVALID USERNAME/PASSWORD.");
            }
        }
    }
}
