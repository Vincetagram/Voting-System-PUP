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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.presidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votingSystemDataSet = new WindowsFormsApplication4.VotingSystemDataSet();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.vicepresidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votingSystemDataSet1 = new WindowsFormsApplication4.VotingSystemDataSet1();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.presidentTableAdapter = new WindowsFormsApplication4.VotingSystemDataSetTableAdapters.presidentTableAdapter();
            this.vicepresidentTableAdapter = new WindowsFormsApplication4.VotingSystemDataSet1TableAdapters.vicepresidentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vicepresidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemDataSet1)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "President";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Vice President";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(740, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Councilors";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1088, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(533, 715);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(112, 23);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Submit and Exit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button8_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Maroon;
            this.listBox1.DataSource = this.presidentBindingSource;
            this.listBox1.DisplayMember = "pName";
            this.listBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 300);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 368);
            this.listBox1.TabIndex = 15;
            this.listBox1.ValueMember = "pName";
            // 
            // presidentBindingSource
            // 
            this.presidentBindingSource.DataMember = "president";
            this.presidentBindingSource.DataSource = this.votingSystemDataSet;
            // 
            // votingSystemDataSet
            // 
            this.votingSystemDataSet.DataSetName = "VotingSystemDataSet";
            this.votingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox2.BackColor = System.Drawing.Color.Maroon;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.DataSource = this.vicepresidentBindingSource;
            this.listBox2.DisplayMember = "pName";
            this.listBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(237, 300);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(175, 353);
            this.listBox2.TabIndex = 16;
            this.listBox2.ValueMember = "pName";
            // 
            // vicepresidentBindingSource
            // 
            this.vicepresidentBindingSource.DataMember = "vicepresident";
            this.vicepresidentBindingSource.DataSource = this.votingSystemDataSet1;
            // 
            // votingSystemDataSet1
            // 
            this.votingSystemDataSet1.DataSetName = "VotingSystemDataSet1";
            this.votingSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.Maroon;
            this.listBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(459, 300);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(608, 368);
            this.listBox3.TabIndex = 17;
            // 
            // presidentTableAdapter
            // 
            this.presidentTableAdapter.ClearBeforeFill = true;
            // 
            // vicepresidentTableAdapter
            // 
            this.vicepresidentTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_voteview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1088, 750);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_voteview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vicepresidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private VotingSystemDataSet votingSystemDataSet;
        private System.Windows.Forms.BindingSource presidentBindingSource;
        private VotingSystemDataSetTableAdapters.presidentTableAdapter presidentTableAdapter;
        private VotingSystemDataSet1 votingSystemDataSet1;
        private System.Windows.Forms.BindingSource vicepresidentBindingSource;
        private VotingSystemDataSet1TableAdapters.vicepresidentTableAdapter vicepresidentTableAdapter;
    }
}