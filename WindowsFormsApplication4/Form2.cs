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
    public partial class Frm_voteview : Form
    {
        public Frm_voteview()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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
            if (MessageBox.Show("Submit Votes?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Voting Successful", "Application Closed!", MessageBoxButtons.OK);
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
            // TODO: This line of code loads data into the 'votingSystemv2DataSet7.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter2.Fill(this.votingSystemv2DataSet7.candidate);
            // TODO: This line of code loads data into the 'votingSystemv2DataSet5.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter1.Fill(this.votingSystemv2DataSet5.candidate);
            // TODO: This line of code loads data into the 'votingSystemv2DataSet4.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter.Fill(this.votingSystemv2DataSet4.candidate);

        }


    }
}
