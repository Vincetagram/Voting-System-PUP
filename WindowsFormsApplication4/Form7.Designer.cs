namespace WindowsFormsApplication4
{
    partial class Frm_admin
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
            this.btn_delcandidates = new System.Windows.Forms.Button();
            this.btn_addcandidates = new System.Windows.Forms.Button();
            this.btn_deletevoter = new System.Windows.Forms.Button();
            this.btn_signout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_delcandidates
            // 
            this.btn_delcandidates.Location = new System.Drawing.Point(157, 110);
            this.btn_delcandidates.Name = "btn_delcandidates";
            this.btn_delcandidates.Size = new System.Drawing.Size(150, 34);
            this.btn_delcandidates.TabIndex = 15;
            this.btn_delcandidates.Text = "Delete Candidate Database";
            this.btn_delcandidates.UseVisualStyleBackColor = true;
            this.btn_delcandidates.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_addcandidates
            // 
            this.btn_addcandidates.Location = new System.Drawing.Point(157, 49);
            this.btn_addcandidates.Name = "btn_addcandidates";
            this.btn_addcandidates.Size = new System.Drawing.Size(150, 34);
            this.btn_addcandidates.TabIndex = 14;
            this.btn_addcandidates.Text = "Add Candidates";
            this.btn_addcandidates.UseVisualStyleBackColor = true;
            this.btn_addcandidates.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_deletevoter
            // 
            this.btn_deletevoter.Location = new System.Drawing.Point(157, 169);
            this.btn_deletevoter.Name = "btn_deletevoter";
            this.btn_deletevoter.Size = new System.Drawing.Size(150, 34);
            this.btn_deletevoter.TabIndex = 16;
            this.btn_deletevoter.Text = "Delete Voter Database";
            this.btn_deletevoter.UseVisualStyleBackColor = true;
            this.btn_deletevoter.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_signout
            // 
            this.btn_signout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_signout.Location = new System.Drawing.Point(194, 230);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(75, 23);
            this.btn_signout.TabIndex = 17;
            this.btn_signout.Text = "Sign out";
            this.btn_signout.UseVisualStyleBackColor = true;
            this.btn_signout.Click += new System.EventHandler(this.button4_Click);
            // 
            // Frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.CancelButton = this.btn_signout;
            this.ClientSize = new System.Drawing.Size(473, 289);
            this.Controls.Add(this.btn_signout);
            this.Controls.Add(this.btn_deletevoter);
            this.Controls.Add(this.btn_delcandidates);
            this.Controls.Add(this.btn_addcandidates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_delcandidates;
        private System.Windows.Forms.Button btn_addcandidates;
        private System.Windows.Forms.Button btn_deletevoter;
        private System.Windows.Forms.Button btn_signout;

    }
}