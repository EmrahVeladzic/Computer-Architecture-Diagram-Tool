namespace Computer_Architecture_Diagram_Tool
{
    partial class Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFlagSave = new System.Windows.Forms.Button();
            this.txtFlagName = new System.Windows.Forms.TextBox();
            this.txtFlagVal = new System.Windows.Forms.TextBox();
            this.dgvFlags = new System.Windows.Forms.DataGridView();
            this.Flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelFlag = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddrSave = new System.Windows.Forms.Button();
            this.txtAddrDesc = new System.Windows.Forms.TextBox();
            this.txtAddrAdd = new System.Windows.Forms.TextBox();
            this.dgvAdresses = new System.Windows.Forms.DataGridView();
            this.Register = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelReg = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlags)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdresses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(18, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 571);
            this.panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1116, 509);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 38);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnFlagSave);
            this.groupBox3.Controls.Add(this.txtFlagName);
            this.groupBox3.Controls.Add(this.txtFlagVal);
            this.groupBox3.Controls.Add(this.dgvFlags);
            this.groupBox3.Location = new System.Drawing.Point(4, 257);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1302, 243);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Flags:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(680, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(680, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Value (Integer):";
            // 
            // btnFlagSave
            // 
            this.btnFlagSave.Location = new System.Drawing.Point(1180, 191);
            this.btnFlagSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFlagSave.Name = "btnFlagSave";
            this.btnFlagSave.Size = new System.Drawing.Size(112, 35);
            this.btnFlagSave.TabIndex = 4;
            this.btnFlagSave.Text = "Save";
            this.btnFlagSave.UseVisualStyleBackColor = true;
            this.btnFlagSave.Click += new System.EventHandler(this.btnFlagSave_Click);
            // 
            // txtFlagName
            // 
            this.txtFlagName.Location = new System.Drawing.Point(681, 114);
            this.txtFlagName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFlagName.Name = "txtFlagName";
            this.txtFlagName.Size = new System.Drawing.Size(610, 26);
            this.txtFlagName.TabIndex = 2;
            // 
            // txtFlagVal
            // 
            this.txtFlagVal.Location = new System.Drawing.Point(680, 54);
            this.txtFlagVal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFlagVal.Name = "txtFlagVal";
            this.txtFlagVal.Size = new System.Drawing.Size(610, 26);
            this.txtFlagVal.TabIndex = 1;
            // 
            // dgvFlags
            // 
            this.dgvFlags.AllowUserToAddRows = false;
            this.dgvFlags.AllowUserToDeleteRows = false;
            this.dgvFlags.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFlags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Flag,
            this.DelFlag});
            this.dgvFlags.Location = new System.Drawing.Point(9, 29);
            this.dgvFlags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFlags.Name = "dgvFlags";
            this.dgvFlags.ReadOnly = true;
            this.dgvFlags.RowHeadersWidth = 62;
            this.dgvFlags.Size = new System.Drawing.Size(662, 197);
            this.dgvFlags.TabIndex = 0;
            this.dgvFlags.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlags_CellContentClick);
            // 
            // Flag
            // 
            this.Flag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Flag.DataPropertyName = "Name";
            this.Flag.HeaderText = "Flag";
            this.Flag.MinimumWidth = 8;
            this.Flag.Name = "Flag";
            this.Flag.ReadOnly = true;
            // 
            // DelFlag
            // 
            this.DelFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DelFlag.HeaderText = "Delete";
            this.DelFlag.MinimumWidth = 8;
            this.DelFlag.Name = "DelFlag";
            this.DelFlag.ReadOnly = true;
            this.DelFlag.Text = "[Delete this Flag]";
            this.DelFlag.UseColumnTextForButtonValue = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAddrSave);
            this.groupBox2.Controls.Add(this.txtAddrDesc);
            this.groupBox2.Controls.Add(this.txtAddrAdd);
            this.groupBox2.Controls.Add(this.dgvAdresses);
            this.groupBox2.Location = new System.Drawing.Point(4, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1302, 243);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Addresses:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address:";
            // 
            // btnAddrSave
            // 
            this.btnAddrSave.Location = new System.Drawing.Point(1179, 191);
            this.btnAddrSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddrSave.Name = "btnAddrSave";
            this.btnAddrSave.Size = new System.Drawing.Size(112, 35);
            this.btnAddrSave.TabIndex = 4;
            this.btnAddrSave.Text = "Save";
            this.btnAddrSave.UseVisualStyleBackColor = true;
            this.btnAddrSave.Click += new System.EventHandler(this.btnAddrSave_Click);
            // 
            // txtAddrDesc
            // 
            this.txtAddrDesc.Location = new System.Drawing.Point(681, 114);
            this.txtAddrDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddrDesc.Name = "txtAddrDesc";
            this.txtAddrDesc.Size = new System.Drawing.Size(610, 26);
            this.txtAddrDesc.TabIndex = 2;
            // 
            // txtAddrAdd
            // 
            this.txtAddrAdd.Location = new System.Drawing.Point(680, 54);
            this.txtAddrAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddrAdd.Name = "txtAddrAdd";
            this.txtAddrAdd.Size = new System.Drawing.Size(610, 26);
            this.txtAddrAdd.TabIndex = 1;
           
            // 
            // dgvAdresses
            // 
            this.dgvAdresses.AllowUserToAddRows = false;
            this.dgvAdresses.AllowUserToDeleteRows = false;
            this.dgvAdresses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAdresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Register,
            this.DelReg});
            this.dgvAdresses.Location = new System.Drawing.Point(9, 29);
            this.dgvAdresses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAdresses.Name = "dgvAdresses";
            this.dgvAdresses.ReadOnly = true;
            this.dgvAdresses.RowHeadersWidth = 62;
            this.dgvAdresses.Size = new System.Drawing.Size(662, 197);
            this.dgvAdresses.TabIndex = 0;
            this.dgvAdresses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddresses_CellContentClick);
            // 
            // Register
            // 
            this.Register.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Register.DataPropertyName = "Description";
            this.Register.HeaderText = "Address";
            this.Register.MinimumWidth = 8;
            this.Register.Name = "Register";
            this.Register.ReadOnly = true;
            // 
            // DelReg
            // 
            this.DelReg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DelReg.HeaderText = "Delete";
            this.DelReg.MinimumWidth = 8;
            this.DelReg.Name = "DelReg";
            this.DelReg.ReadOnly = true;
            this.DelReg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DelReg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DelReg.Text = "[Delete this Address]";
            this.DelReg.UseColumnTextForButtonValue = true;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1347, 606);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlags)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdresses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFlagSave;
        private System.Windows.Forms.TextBox txtFlagName;
        private System.Windows.Forms.TextBox txtFlagVal;
        private System.Windows.Forms.DataGridView dgvFlags;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddrSave;
        private System.Windows.Forms.TextBox txtAddrDesc;
        private System.Windows.Forms.TextBox txtAddrAdd;
        private System.Windows.Forms.DataGridView dgvAdresses;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flag;
        private System.Windows.Forms.DataGridViewButtonColumn DelFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Register;
        private System.Windows.Forms.DataGridViewButtonColumn DelReg;
    }
}