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
    public partial class Frm_Register : Form
    {
        public Frm_Register()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.VotingSystemConnectionString);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.VotingSystemConnectionString);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.VotingSystemConnectionString);
            

            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) from voters where uname like @username", con))
            {
                con.Open();
                command.Parameters.AddWithValue("@username", tb_user.Text);
                int userCount = (int)command.ExecuteScalar();
                if (userCount > 0)
                {
                    MessageBox.Show("USER ALREADY EXISTS!");
                }
                else
                {
                    String query = "INSERT INTO voters (userid,uname,upass,ustudno) VALUES(@id,@username,@password, @studno)";
                    SqlCommand command1 = new SqlCommand(query, con);
                    command1.Parameters.Add("@id", 1);
                    command1.Parameters.Add("@username", tb_user.Text);
                    command1.Parameters.Add("@password", tb_pass.Text);
                    command1.Parameters.Add("@studno", tb_studno.Text);
                    command1.ExecuteNonQuery();
                    
                    MessageBox.Show("Succesfully Registered.");
                }
                
            }
            con.Close();

        }

        private void tb_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
