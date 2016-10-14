namespace WindowsFormsApplication4
{
    partial class Frm_voteview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_voteview));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_president = new System.Windows.Forms.Button();
            this.btn_vp = new System.Windows.Forms.Button();
            this.btn_councilors = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lb_councilor = new System.Windows.Forms.ListBox();
            this.ta_president = new WindowsFormsApplication4.VotingSystemv2DataSet3TableAdapters.candidateTableAdapter();
            this.votingSystemv2DataSet4 = new WindowsFormsApplication4.VotingSystemv2DataSet4();
            this.vpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidateTableAdapter = new WindowsFormsApplication4.VotingSystemv2DataSet4TableAdapters.candidateTableAdapter();
            this.votingSystemv2DataSet5 = new WindowsFormsApplication4.VotingSystemv2DataSet5();
            this.pBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidateTableAdapter1 = new WindowsFormsApplication4.VotingSystemv2DataSet5TableAdapters.candidateTableAdapter();
            this.votingSystemv2DataSet7 = new WindowsFormsApplication4.VotingSystemv2DataSet7();
            this.cBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidateTableAdapter2 = new WindowsFormsApplication4.VotingSystemv2DataSet7TableAdapters.candidateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemv2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemv2DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemv2DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(384, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vote for Position:";
            // 
            // btn_president
            // 
            this.btn_president.Location = new System.Drawing.Point(52, 261);
            this.btn_president.Name = "btn_president";
            this.btn_president.Size = new System.Drawing.Size(90, 23);
            this.btn_president.TabIndex = 1;
            this.btn_president.TabStop = false;
            this.btn_president.Text = "President";
            this.btn_president.UseVisualStyleBackColor = true;
            this.btn_president.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_vp
            // 
            this.btn_vp.Location = new System.Drawing.Point(458, 261);
            this.btn_vp.Name = "btn_vp";
            this.btn_vp.Size = new System.Drawing.Size(90, 23);
            this.btn_vp.TabIndex = 2;
            this.btn_vp.TabStop = false;
            this.btn_vp.Text = "Vice President";
            this.btn_vp.UseVisualStyleBackColor = true;
            this.btn_vp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_councilors
            // 
            this.btn_councilors.Location = new System.Drawing.Point(52, 290);
            this.btn_councilors.Name = "btn_councilors";
            this.btn_councilors.Size = new System.Drawing.Size(90, 23);
            this.btn_councilors.TabIndex = 4;
            this.btn_councilors.Text = "Councilors";
            this.btn_councilors.UseVisualStyleBackColor = true;
            this.btn_councilors.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(883, 241);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_submit
            // 
            this.btn_submit.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_submit.Location = new System.Drawing.Point(402, 423);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(112, 23);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Submit and Exit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pBindingSource;
            this.comboBox1.DisplayMember = "cName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.vpBindingSource;
            this.comboBox2.DisplayMember = "cName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(555, 262);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(266, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // lb_councilor
            // 
            this.lb_councilor.DataSource = this.cBindingSource;
            this.lb_councilor.DisplayMember = "cName";
            this.lb_councilor.FormattingEnabled = true;
            this.lb_councilor.Location = new System.Drawing.Point(148, 290);
            this.lb_councilor.MultiColumn = true;
            this.lb_councilor.Name = "lb_councilor";
            this.lb_councilor.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_councilor.Size = new System.Drawing.Size(673, 121);
            this.lb_councilor.TabIndex = 21;
            // 
            // ta_president
            // 
            this.ta_president.ClearBeforeFill = true;
            // 
            // votingSystemv2DataSet4
            // 
            this.votingSystemv2DataSet4.DataSetName = "VotingSystemv2DataSet4";
            this.votingSystemv2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vpBindingSource
            // 
            this.vpBindingSource.DataMember = "candidate";
            this.vpBindingSource.DataSource = this.votingSystemv2DataSet4;
            this.vpBindingSource.Filter = "cPosition = \'VICE-PRESIDENT\'";
            // 
            // candidateTableAdapter
            // 
            this.candidateTableAdapter.ClearBeforeFill = true;
            // 
            // votingSystemv2DataSet5
            // 
            this.votingSystemv2DataSet5.DataSetName = "VotingSystemv2DataSet5";
            this.votingSystemv2DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pBindingSource
            // 
            this.pBindingSource.DataMember = "candidate";
            this.pBindingSource.DataSource = this.votingSystemv2DataSet5;
            this.pBindingSource.Filter = "cPosition = \'PRESIDENT\'";
            // 
            // candidateTableAdapter1
            // 
            this.candidateTableAdapter1.ClearBeforeFill = true;
            // 
            // votingSystemv2DataSet7
            // 
            this.votingSystemv2DataSet7.DataSetName = "VotingSystemv2DataSet7";
            this.votingSystemv2DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cBindingSource
            // 
            this.cBindingSource.DataMember = "candidate";
            this.cBindingSource.DataSource = this.votingSystemv2DataSet7;
            this.cBindingSource.Filter = "cPosition = \'COUNCILOR\'";
            // 
            // candidateTableAdapter2
            // 
            this.candidateTableAdapter2.ClearBeforeFill = true;
            // 
            // Frm_voteview
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(883, 454);
            this.Controls.Add(this.lb_councilor);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_councilors);
            this.Controls.Add(this.btn_vp);
            this.Controls.Add(this.btn_president);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_voteview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voting";
            this.Load += new System.EventHandler(this.Frm_voteview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemv2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemv2DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemv2DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_president;
        private System.Windows.Forms.Button btn_vp;
        private System.Windows.Forms.Button btn_councilors;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox lb_councilor;
        private VotingSystemv2DataSet3TableAdapters.candidateTableAdapter ta_president;
        private VotingSystemv2DataSet4 votingSystemv2DataSet4;
        private System.Windows.Forms.BindingSource vpBindingSource;
        private VotingSystemv2DataSet4TableAdapters.candidateTableAdapter candidateTableAdapter;
        private VotingSystemv2DataSet5 votingSystemv2DataSet5;
        private System.Windows.Forms.BindingSource pBindingSource;
        private VotingSystemv2DataSet5TableAdapters.candidateTableAdapter candidateTableAdapter1;
        private VotingSystemv2DataSet7 votingSystemv2DataSet7;
        private System.Windows.Forms.BindingSource cBindingSource;
        private VotingSystemv2DataSet7TableAdapters.candidateTableAdapter candidateTableAdapter2;
    }
}