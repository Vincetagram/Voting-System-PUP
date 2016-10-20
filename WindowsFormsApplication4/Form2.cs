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
    public partial class Frm_voteview : Form
    {
        string userid;
        public Frm_voteview()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.VotingSystemv2ConnectionString);
            con.Open();
        }
        public Frm_voteview(string userid)
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.VotingSystemv2ConnectionString);
            con.Open();
            this.userid = userid;
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.VotingSystemv2ConnectionString);
        
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           new Frm_Login().Show();
           this.Hide();
        }

        private void button8_Click(object sender, FormClosingEventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


 

        private void Frm_voteview_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Frm_voteview_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            con.Open();
            if (MessageBox.Show("Submit Votes?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Voting Successful", "Application Closed!", MessageBoxButtons.OK);
                
                using (SqlCommand command = new SqlCommand("UPDATE candidate SET cTally = cTally + 1 where cName like @cname or cName like @vName", con))
                {
                    
                    command.Parameters.AddWithValue("@cname", cb_president.Text);
                    command.Parameters.AddWithValue("@vName", cb_vpresident.Text);
                    command.ExecuteNonQuery();
                    
                }
                foreach (object item in lb_councilor.SelectedItems)
                {
                    using (SqlCommand command = new SqlCommand("UPDATE candidate SET cTally = cTally + 1 where cName like @coname", con))
                    {

                        command.Parameters.AddWithValue("@coname", (item as DataRowView)["cName"].ToString());
                        
                        Console.WriteLine((item as DataRowView)["cName"].ToString());
                        command.ExecuteNonQuery();
                       
                    }
                    using (SqlCommand command = new SqlCommand("UPDATE voters SET isVoted = 1 where userName like @uname", con))
                    {

                        command.Parameters.AddWithValue("@uname", userid );

                        command.ExecuteNonQuery();

                    }
                }
                this.Close();
                new Frm_Login().Show();

            }
            else
            {
                this.Activate();
            }   
        }

        private void Frm_voteview_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.VotingSystemv2ConnectionString);
            con.Open();
  
            // TODO: This line of code loads data into the 'votingSystemv2DataSet7.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter2.Fill(this.votingSystemv2DataSet7.candidate);
            // TODO: This line of code loads data into the 'votingSystemv2DataSet5.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter1.Fill(this.votingSystemv2DataSet5.candidate);
            // TODO: This line of code loads data into the 'votingSystemv2DataSet4.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter.Fill(this.votingSystemv2DataSet4.candidate);
           
        }

        private void dgv_councilor_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void dgv_councilor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
              
        }

        private void Frm_voteview_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.VotingSystemv2ConnectionString);
            // TODO: This line of code loads data into the 'votingSystemv2DataSet7.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter2.Fill(this.votingSystemv2DataSet7.candidate);
            // TODO: This line of code loads data into the 'votingSystemv2DataSet5.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter1.Fill(this.votingSystemv2DataSet5.candidate);
            // TODO: This line of code loads data into the 'votingSystemv2DataSet4.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter.Fill(this.votingSystemv2DataSet4.candidate);
            con.Close();
        }
    }
}
