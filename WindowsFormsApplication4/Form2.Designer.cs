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
            this.presidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vicepresidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.candidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votingSystemv2DataSet2 = new WindowsFormsApplication4.VotingSystemv2DataSet2();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.votingSystemv2DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votingSystemv2DataSet1 = new WindowsFormsApplication4.VotingSystemv2DataSet1();
            this.candidateTableAdapter = new WindowsFormsApplication4.VotingSystemv2DataSet2TableAdapters.candidateTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vicepresidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemv2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemv2DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemv2DataSet1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
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
            this.pictureBox1.Size = new System.Drawing.Size(841, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(402, 423);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(112, 23);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Submit and Exit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.candidateBindingSource;
            this.comboBox1.DisplayMember = "cName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // candidateBindingSource
            // 
            this.candidateBindingSource.DataMember = "candidate";
            this.candidateBindingSource.DataSource = this.votingSystemv2DataSet2;
            // 
            // votingSystemv2DataSet2
            // 
            this.votingSystemv2DataSet2.DataSetName = "VotingSystemv2DataSet2";
            this.votingSystemv2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(555, 262);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(266, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // votingSystemv2DataSet1BindingSource
            // 
            this.votingSystemv2DataSet1BindingSource.DataSource = this.votingSystemv2DataSet1;
            this.votingSystemv2DataSet1BindingSource.Position = 0;
            // 
            // votingSystemv2DataSet1
            // 
            this.votingSystemv2DataSet1.DataSetName = "VotingSystemv2DataSet1";
            this.votingSystemv2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidateTableAdapter
            // 
            this.candidateTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 219);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(841, 25);
            this.fillByToolStrip.TabIndex = 20;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // Frm_voteview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(841, 491);
            this.Controls.Add(this.fillByToolStrip);
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
            this.Text = "List View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vicepresidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemv2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemv2DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemv2DataSet1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
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
       private System.Windows.Forms.BindingSource presidentBindingSource;
        
        private System.Windows.Forms.BindingSource vicepresidentBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource votingSystemv2DataSet1BindingSource;
        private VotingSystemv2DataSet1 votingSystemv2DataSet1;
        private System.Windows.Forms.ComboBox comboBox2;
        private VotingSystemv2DataSet2 votingSystemv2DataSet2;
        private System.Windows.Forms.BindingSource candidateBindingSource;
        private VotingSystemv2DataSet2TableAdapters.candidateTableAdapter candidateTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}