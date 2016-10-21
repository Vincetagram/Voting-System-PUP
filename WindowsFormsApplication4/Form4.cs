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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cDataset.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter4.Fill(this.cDataset.candidate);
            // TODO: This line of code loads data into the 'vpdataset.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter3.Fill(this.vpdataset.candidate);
            // TODO: This line of code loads data into the 'pdataset.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter2.Fill(this.pdataset.candidate);
            // TODO: This line of code loads data into the 'votingSystemv2DataSet5.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter1.Fill(this.votingSystemv2DataSet5.candidate);
            // TODO: This line of code loads data into the 'votingSystemv2DataSet8.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter.Fill(this.votingSystemv2DataSet8.candidate);
            dgv_vresult.Sort(vtally,ListSortDirection.Descending);
            dgv_result.Sort(cptally, ListSortDirection.Descending);
            dgv_cresult.Sort(ccresult,ListSortDirection.Descending);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.candidateTableAdapter2.Fill(this.pdataset.candidate);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillVPToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.candidateTableAdapter2.FillVP(this.pdataset.candidate);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
