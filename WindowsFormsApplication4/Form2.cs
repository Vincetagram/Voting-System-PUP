﻿using System;
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

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            new Frm_Login().Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votingSystemv2DataSet2.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter.Fill(this.votingSystemv2DataSet2.candidate);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.candidateTableAdapter.FillBy(this.votingSystemv2DataSet2.candidate);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
