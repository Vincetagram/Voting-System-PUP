namespace WindowsFormsApplication4
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_results = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_admin = new System.Windows.Forms.Button();
           ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(205, 171);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(232, 20);
            this.tb_user.TabIndex = 0;
            this.tb_user.TextChanged += new System.EventHandler(this.tb_user_TextChanged);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(205, 202);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(232, 20);
            this.tb_pass.TabIndex = 1;
            this.tb_pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(205, 235);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(115, 23);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(141, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(146, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // btn_results
            // 
            this.btn_results.Location = new System.Drawing.Point(540, 235);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(75, 23);
            this.btn_results.TabIndex = 5;
            this.btn_results.Text = "Results";
            this.btn_results.UseVisualStyleBackColor = true;
            this.btn_results.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(326, 235);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(111, 23);
            this.btn_register.TabIndex = 3;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_admin.Location = new System.Drawing.Point(540, 200);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(75, 23);
            this.btn_admin.TabIndex = 4;
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // votersTableAdapter1
            // 
           // 
            // Frm_Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(643, 270);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(659, 308);
            this.MinimumSize = new System.Drawing.Size(659, 308);
            this.Name = "Frm_Login";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_results;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_admin;
    }
}

