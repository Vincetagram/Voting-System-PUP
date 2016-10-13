namespace WindowsFormsApplication4
{
    partial class Frm_addcandidate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_partylist = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.cb_position = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(74, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(59, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Party List:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_name
            // 
            this.tb_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_name.Location = new System.Drawing.Point(118, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(237, 20);
            this.tb_name.TabIndex = 2;
            // 
            // tb_partylist
            // 
            this.tb_partylist.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_partylist.Location = new System.Drawing.Point(118, 43);
            this.tb_partylist.Name = "tb_partylist";
            this.tb_partylist.Size = new System.Drawing.Size(237, 20);
            this.tb_partylist.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(118, 109);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(121, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(245, 109);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(110, 23);
            this.btn_return.TabIndex = 6;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_position
            // 
            this.cb_position.FormattingEnabled = true;
            this.cb_position.Items.AddRange(new object[] {
            "President",
            "Vice-President",
            "Secretary",
            "Treasurer",
            "Misc."});
            this.cb_position.Location = new System.Drawing.Point(118, 73);
            this.cb_position.Name = "cb_position";
            this.cb_position.Size = new System.Drawing.Size(121, 21);
            this.cb_position.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(65, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Position:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Frm_addcandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(458, 156);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_position);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_partylist);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_addcandidate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Candidate";
            this.Load += new System.EventHandler(this.Frm_addcandidate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_partylist;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.ComboBox cb_position;
        private System.Windows.Forms.Label label3;
    }
}