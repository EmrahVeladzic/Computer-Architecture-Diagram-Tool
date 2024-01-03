namespace Computer_Architecture_Diagram_Tool
{
    partial class DDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DDisplay));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.diagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gettingStartedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Split = new System.Windows.Forms.SplitContainer();
            this.drawBox = new System.Windows.Forms.PictureBox();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbObject = new System.Windows.Forms.GroupBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.cmbObjCls = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.btnNewClass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCath = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTools = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Split)).BeginInit();
            this.Split.Panel1.SuspendLayout();
            this.Split.Panel2.SuspendLayout();
            this.Split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).BeginInit();
            this.gbAdmin.SuspendLayout();
            this.gbObject.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagramToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(751, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Main Menu";
            // 
            // diagramToolStripMenuItem
            // 
            this.diagramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDiagramToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exportAsHeaderToolStripMenuItem});
            this.diagramToolStripMenuItem.Name = "diagramToolStripMenuItem";
            this.diagramToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.diagramToolStripMenuItem.Text = "Diagram";
            // 
            // newDiagramToolStripMenuItem
            // 
            this.newDiagramToolStripMenuItem.Name = "newDiagramToolStripMenuItem";
            this.newDiagramToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.newDiagramToolStripMenuItem.Text = "New Diagram";
            this.newDiagramToolStripMenuItem.Click += new System.EventHandler(this.newDiagramToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exportAsHeaderToolStripMenuItem
            // 
            this.exportAsHeaderToolStripMenuItem.Name = "exportAsHeaderToolStripMenuItem";
            this.exportAsHeaderToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exportAsHeaderToolStripMenuItem.Text = "Export As Header";
            this.exportAsHeaderToolStripMenuItem.Click += new System.EventHandler(this.exportAsHeaderToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.gettingStartedToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gettingStartedToolStripMenuItem
            // 
            this.gettingStartedToolStripMenuItem.Name = "gettingStartedToolStripMenuItem";
            this.gettingStartedToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.gettingStartedToolStripMenuItem.Text = "Getting Started";
            this.gettingStartedToolStripMenuItem.Click += new System.EventHandler(this.gettingStartedToolStripMenuItem_Click);
            // 
            // Split
            // 
            this.Split.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Split.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.Split.IsSplitterFixed = true;
            this.Split.Location = new System.Drawing.Point(0, 24);
            this.Split.Name = "Split";
            // 
            // Split.Panel1
            // 
            this.Split.Panel1.Controls.Add(this.drawBox);
            // 
            // Split.Panel2
            // 
            this.Split.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Split.Panel2.Controls.Add(this.gbAdmin);
            this.Split.Panel2.Controls.Add(this.gbObject);
            this.Split.Panel2.Controls.Add(this.btnNewClass);
            this.Split.Panel2.Controls.Add(this.label2);
            this.Split.Panel2.Controls.Add(this.cmbCath);
            this.Split.Panel2.Controls.Add(this.label1);
            this.Split.Panel2.Controls.Add(this.cmbTools);
            this.Split.Size = new System.Drawing.Size(751, 421);
            this.Split.SplitterDistance = 499;
            this.Split.TabIndex = 1;
            // 
            // drawBox
            // 
            this.drawBox.BackColor = System.Drawing.Color.RosyBrown;
            this.drawBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawBox.Location = new System.Drawing.Point(0, 0);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(499, 421);
            this.drawBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drawBox.TabIndex = 0;
            this.drawBox.TabStop = false;
            this.drawBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawBox_MouseDown);
            this.drawBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawBox_MouseMove);
            this.drawBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawBox_MouseUp);
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.btnSave);
            this.gbAdmin.Controls.Add(this.btnDelete);
            this.gbAdmin.Location = new System.Drawing.Point(6, 325);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(239, 93);
            this.gbAdmin.TabIndex = 7;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Commit:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(227, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 61);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(227, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete Object";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbObject
            // 
            this.gbObject.Controls.Add(this.btnDetail);
            this.gbObject.Controls.Add(this.cmbObjCls);
            this.gbObject.Controls.Add(this.label4);
            this.gbObject.Controls.Add(this.label3);
            this.gbObject.Controls.Add(this.txName);
            this.gbObject.Location = new System.Drawing.Point(6, 117);
            this.gbObject.Name = "gbObject";
            this.gbObject.Size = new System.Drawing.Size(239, 202);
            this.gbObject.TabIndex = 6;
            this.gbObject.TabStop = false;
            this.gbObject.Text = "Object Info:";
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(6, 173);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(227, 23);
            this.btnDetail.TabIndex = 8;
            this.btnDetail.Text = "Edit Details:";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // cmbObjCls
            // 
            this.cmbObjCls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjCls.FormattingEnabled = true;
            this.cmbObjCls.Location = new System.Drawing.Point(6, 72);
            this.cmbObjCls.Name = "cmbObjCls";
            this.cmbObjCls.Size = new System.Drawing.Size(227, 21);
            this.cmbObjCls.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Object Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(6, 32);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(227, 20);
            this.txName.TabIndex = 0;
            // 
            // btnNewClass
            // 
            this.btnNewClass.Location = new System.Drawing.Point(46, 75);
            this.btnNewClass.Name = "btnNewClass";
            this.btnNewClass.Size = new System.Drawing.Size(163, 23);
            this.btnNewClass.TabIndex = 5;
            this.btnNewClass.Text = "Classes...";
            this.btnNewClass.UseVisualStyleBackColor = true;
            this.btnNewClass.Click += new System.EventHandler(this.btnNewClass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Object Class:";
            // 
            // cmbCath
            // 
            this.cmbCath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCath.FormattingEnabled = true;
            this.cmbCath.Location = new System.Drawing.Point(82, 31);
            this.cmbCath.Name = "cmbCath";
            this.cmbCath.Size = new System.Drawing.Size(163, 21);
            this.cmbCath.TabIndex = 3;
            this.cmbCath.SelectedIndexChanged += new System.EventHandler(this.cmbCath_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diagram Tool:";
            // 
            // cmbTools
            // 
            this.cmbTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTools.FormattingEnabled = true;
            this.cmbTools.Location = new System.Drawing.Point(82, 4);
            this.cmbTools.Name = "cmbTools";
            this.cmbTools.Size = new System.Drawing.Size(163, 21);
            this.cmbTools.TabIndex = 1;
            this.cmbTools.SelectedIndexChanged += new System.EventHandler(this.cmbTools_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblName.Location = new System.Drawing.Point(340, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Project:";
            // 
            // DDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 445);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.Split);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(500, 100);
            this.Name = "DDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Architecture Diagram Tool";
            this.Load += new System.EventHandler(this.DDisplay_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Split.Panel1.ResumeLayout(false);
            this.Split.Panel2.ResumeLayout(false);
            this.Split.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Split)).EndInit();
            this.Split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).EndInit();
            this.gbAdmin.ResumeLayout(false);
            this.gbObject.ResumeLayout(false);
            this.gbObject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gettingStartedToolStripMenuItem;
        private System.Windows.Forms.SplitContainer Split;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox drawBox;
        private System.Windows.Forms.ComboBox cmbTools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbCath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewClass;
        private System.Windows.Forms.GroupBox gbObject;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbObjCls;
        private System.Windows.Forms.ToolStripMenuItem diagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDiagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsHeaderToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDetail;
    }
}

