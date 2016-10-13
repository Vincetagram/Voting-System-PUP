using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Frm_addcandidate : Form
    {
        public Frm_addcandidate()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_addcandidate_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.VotingSystemConnectionString);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.VotingSystemConnectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (cb_position.Text.ToUpper() == "PRESIDENT")
            {
                String query = "INSERT INTO president (pID,pName,pParty,image) VALUES(@id,@username,@password, @studno)";
            }
            else if (cb_position.Text.ToUpper() == "VICE-PRESIDENT")
            {

            }
            else
            {
                MessageBox.Show("PLEASE SELECT POSITION.");
            }
        }
    }
}
