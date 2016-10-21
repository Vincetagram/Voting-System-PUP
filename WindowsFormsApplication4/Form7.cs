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
    public partial class Frm_adminselect : Form
    {
        public Frm_adminselect()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.VotingSystemv2ConnectionString);
        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALL CANDIDATES DELETED.");
            deletetable("candidate");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Frm_addcandidate().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALL VOTERS DELETED.");
            deletetable("voters");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new Frm_Login().Show();
        }
        private void deletetable(string tablename)
        {
            con.Open();
            string sqltrunc = "TRUNCATE TABLE " + tablename;
            SqlCommand cmd = new SqlCommand(sqltrunc,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
