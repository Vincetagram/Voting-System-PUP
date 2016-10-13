using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient; 
namespace WindowsFormsApplication4
{
    public partial class Frm_Login : Form
    {
        SqlConnection con = new SqlConnection();
        public Frm_Login()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=Voting-System-PUP\WindowsFormsApplication4\Database\VotingSystem.mdf;Integrated Security=True;";
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
             con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=Voting-System-PUP\WindowsFormsApplication4\Database\VotingSystem.mdf;Integrated Security=True;";
            con.Open();
            string userid = tb_user.Text;
            string password = tb_pass.Text;
            SqlCommand cmd = new SqlCommand("select uname,upass from voters where userid='" + tb_user.Text + "'and password='" + tb_pass.Text + "'", con);  
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();  
            da.Fill(dt);
            if (dt.Rows.Count > 0)  
            {  
                new Form2().Show();
                this.Hide();
            }  
            else  
            {  
                MessageBox.Show("Invalid Login please check username and password");  
            }  
            con.Close(); 
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form5().Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new Frm_Admin().Show();
            this.Hide();
        }

        private void tb_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=Voting-System-PUP\WindowsFormsApplication4\Database\VotingSystem.mdf;Integrated Security=True;";
            con.Open();  
        }
    }
}
