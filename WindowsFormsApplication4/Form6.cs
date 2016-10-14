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
            SqlConnection con = new SqlConnection(Properties.Settings.Default.VotingSystemv2ConnectionString);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.VotingSystemv2ConnectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                            }
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) from candidate where studNo like @studentno", con))
            {
                command.Parameters.AddWithValue("@studentno", tb_studno.Text.ToUpper());
                int userCount = (int)command.ExecuteScalar();
                if (userCount > 0)
                {
                    MessageBox.Show("USER ALREADY EXISTS!");
                }
                else
                {
                    String query = "INSERT INTO candidate (studNo, cName, cParty,cPosition) VALUES(@studno,@candidatename,@partylist, @position)";
                    SqlCommand command1 = new SqlCommand(query, con);
                    command1.Parameters.Add("@studno", tb_studno.Text.ToUpper());
                    command1.Parameters.Add("@candidatename", tb_name.Text.ToUpper());
                    command1.Parameters.Add("@partylist", tb_partylist.Text.ToUpper());
                    command1.Parameters.Add("@position", cb_position.Text.ToUpper());
                    command1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Succesfully Registered.");
                    this.Close();
                }
            }
        }
    }
}
