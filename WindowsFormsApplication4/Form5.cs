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
            SqlConnection con = new SqlConnection(Properties.Settings.Default.VotingSystemv2ConnectionString);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.VotingSystemv2ConnectionString);
            

            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) from voters where userName like @username and studNo like @studentno", con))
            {
                con.Open();
                command.Parameters.AddWithValue("@username", tb_user.Text);
                command.Parameters.AddWithValue("@studentno", tb_studno.Text);
                
                int userCount = (int)command.ExecuteScalar();
                if (userCount > 0)
                {
                    MessageBox.Show("USER ALREADY EXISTS!");
                }
                else
                {
                    String query = "INSERT INTO voters (studNo,userName,userPass) VALUES( @studno,@username,@password)";
                    SqlCommand command1 = new SqlCommand(query, con);
                    command1.Parameters.Add("@username", tb_user.Text);
                    command1.Parameters.Add("@password", tb_pass.Text);
                    command1.Parameters.Add("@studno", tb_studno.Text);
                    command1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Succesfully Registered.");
                    this.Close();
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
