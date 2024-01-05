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
            this.btnRegSave = new System.Windows.Forms.Button();
            this.txtRegDesc = new System.Windows.Forms.TextBox();
            this.txtRegAdd = new System.Windows.Forms.TextBox();
            this.dgvRegisters = new System.Windows.Forms.DataGridView();
            this.Register = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelReg = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlags)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisters)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 371);
            this.panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(744, 331);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 25);
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
            this.groupBox3.Location = new System.Drawing.Point(3, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(868, 158);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Flags:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Value (Integer):";
            // 
            // btnFlagSave
            // 
            this.btnFlagSave.Location = new System.Drawing.Point(787, 124);
            this.btnFlagSave.Name = "btnFlagSave";
            this.btnFlagSave.Size = new System.Drawing.Size(75, 23);
            this.btnFlagSave.TabIndex = 4;
            this.btnFlagSave.Text = "Save";
            this.btnFlagSave.UseVisualStyleBackColor = true;
            this.btnFlagSave.Click += new System.EventHandler(this.btnFlagSave_Click);
            // 
            // txtFlagName
            // 
            this.txtFlagName.Location = new System.Drawing.Point(454, 74);
            this.txtFlagName.Name = "txtFlagName";
            this.txtFlagName.Size = new System.Drawing.Size(408, 20);
            this.txtFlagName.TabIndex = 2;
            // 
            // txtFlagVal
            // 
            this.txtFlagVal.Location = new System.Drawing.Point(453, 35);
            this.txtFlagVal.Name = "txtFlagVal";
            this.txtFlagVal.Size = new System.Drawing.Size(408, 20);
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
            this.dgvFlags.Location = new System.Drawing.Point(6, 19);
            this.dgvFlags.Name = "dgvFlags";
            this.dgvFlags.ReadOnly = true;
            this.dgvFlags.Size = new System.Drawing.Size(441, 128);
            this.dgvFlags.TabIndex = 0;
            this.dgvFlags.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlags_CellContentClick);
            // 
            // Flag
            // 
            this.Flag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Flag.DataPropertyName = "Name";
            this.Flag.HeaderText = "Flag";
            this.Flag.Name = "Flag";
            this.Flag.ReadOnly = true;
            // 
            // DelFlag
            // 
            this.DelFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DelFlag.HeaderText = "Delete";
            this.DelFlag.Name = "DelFlag";
            this.DelFlag.ReadOnly = true;
            this.DelFlag.Text = "[Delete this Flag]";
            this.DelFlag.UseColumnTextForButtonValue = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnRegSave);
            this.groupBox2.Controls.Add(this.txtRegDesc);
            this.groupBox2.Controls.Add(this.txtRegAdd);
            this.groupBox2.Controls.Add(this.dgvRegisters);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 158);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address:";
            // 
            // btnRegSave
            // 
            this.btnRegSave.Location = new System.Drawing.Point(786, 124);
            this.btnRegSave.Name = "btnRegSave";
            this.btnRegSave.Size = new System.Drawing.Size(75, 23);
            this.btnRegSave.TabIndex = 4;
            this.btnRegSave.Text = "Save";
            this.btnRegSave.UseVisualStyleBackColor = true;
            this.btnRegSave.Click += new System.EventHandler(this.btnRegSave_Click);
            // 
            // txtRegDesc
            // 
            this.txtRegDesc.Location = new System.Drawing.Point(454, 74);
            this.txtRegDesc.Name = "txtRegDesc";
            this.txtRegDesc.Size = new System.Drawing.Size(408, 20);
            this.txtRegDesc.TabIndex = 2;
            // 
            // txtRegAdd
            // 
            this.txtRegAdd.Location = new System.Drawing.Point(453, 35);
            this.txtRegAdd.Name = "txtRegAdd";
            this.txtRegAdd.Size = new System.Drawing.Size(408, 20);
            this.txtRegAdd.TabIndex = 1;
            // 
            // dgvRegisters
            // 
            this.dgvRegisters.AllowUserToAddRows = false;
            this.dgvRegisters.AllowUserToDeleteRows = false;
            this.dgvRegisters.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRegisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Register,
            this.DelReg});
            this.dgvRegisters.Location = new System.Drawing.Point(6, 19);
            this.dgvRegisters.Name = "dgvRegisters";
            this.dgvRegisters.ReadOnly = true;
            this.dgvRegisters.Size = new System.Drawing.Size(441, 128);
            this.dgvRegisters.TabIndex = 0;
            this.dgvRegisters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegisters_CellContentClick);
            // 
            // Register
            // 
            this.Register.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Register.DataPropertyName = "Description";
            this.Register.HeaderText = "Register";
            this.Register.Name = "Register";
            this.Register.ReadOnly = true;
            // 
            // DelReg
            // 
            this.DelReg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DelReg.HeaderText = "Delete";
            this.DelReg.Name = "DelReg";
            this.DelReg.ReadOnly = true;
            this.DelReg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DelReg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DelReg.Text = "[Delete this Register]";
            this.DelReg.UseColumnTextForButtonValue = true;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(898, 394);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisters)).EndInit();
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
        private System.Windows.Forms.Button btnRegSave;
        private System.Windows.Forms.TextBox txtRegDesc;
        private System.Windows.Forms.TextBox txtRegAdd;
        private System.Windows.Forms.DataGridView dgvRegisters;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flag;
        private System.Windows.Forms.DataGridViewButtonColumn DelFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Register;
        private System.Windows.Forms.DataGridViewButtonColumn DelReg;
    }
}