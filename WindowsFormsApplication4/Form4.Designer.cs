namespace WindowsFormsApplication4
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.votingSystemv2DataSet8 = new WindowsFormsApplication4.VotingSystemv2DataSet8();
            this.candidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidateTableAdapter = new WindowsFormsApplication4.VotingSystemv2DataSet8TableAdapters.candidateTableAdapter();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPartyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTallyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemv2DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(149, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Return to Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_result
            // 
            this.dgv_result.AllowUserToAddRows = false;
            this.dgv_result.AllowUserToDeleteRows = false;
            this.dgv_result.AutoGenerateColumns = false;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNameDataGridViewTextBoxColumn,
            this.cPartyDataGridViewTextBoxColumn,
            this.cPositionDataGridViewTextBoxColumn,
            this.cTallyDataGridViewTextBoxColumn});
            this.dgv_result.DataSource = this.candidateBindingSource;
            this.dgv_result.Location = new System.Drawing.Point(13, 34);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.ReadOnly = true;
            this.dgv_result.RowHeadersVisible = false;
            this.dgv_result.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_result.Size = new System.Drawing.Size(394, 150);
            this.dgv_result.TabIndex = 2;
            // 
            // votingSystemv2DataSet8
            // 
            this.votingSystemv2DataSet8.DataSetName = "VotingSystemv2DataSet8";
            this.votingSystemv2DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidateBindingSource
            // 
            this.candidateBindingSource.DataMember = "candidate";
            this.candidateBindingSource.DataSource = this.votingSystemv2DataSet8;
            // 
            // candidateTableAdapter
            // 
            this.candidateTableAdapter.ClearBeforeFill = true;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "cName";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPartyDataGridViewTextBoxColumn
            // 
            this.cPartyDataGridViewTextBoxColumn.DataPropertyName = "cParty";
            this.cPartyDataGridViewTextBoxColumn.HeaderText = "PartyList";
            this.cPartyDataGridViewTextBoxColumn.Name = "cPartyDataGridViewTextBoxColumn";
            this.cPartyDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPartyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cPositionDataGridViewTextBoxColumn
            // 
            this.cPositionDataGridViewTextBoxColumn.DataPropertyName = "cPosition";
            this.cPositionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.cPositionDataGridViewTextBoxColumn.Name = "cPositionDataGridViewTextBoxColumn";
            this.cPositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTallyDataGridViewTextBoxColumn
            // 
            this.cTallyDataGridViewTextBoxColumn.DataPropertyName = "cTally";
            this.cTallyDataGridViewTextBoxColumn.HeaderText = "Tally";
            this.cTallyDataGridViewTextBoxColumn.Name = "cTallyDataGridViewTextBoxColumn";
            this.cTallyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(419, 244);
            this.Controls.Add(this.dgv_result);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form4";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingSystemv2DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_result;
        private VotingSystemv2DataSet8 votingSystemv2DataSet8;
        private System.Windows.Forms.BindingSource candidateBindingSource;
        private VotingSystemv2DataSet8TableAdapters.candidateTableAdapter candidateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPartyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTallyDataGridViewTextBoxColumn;
    }
}