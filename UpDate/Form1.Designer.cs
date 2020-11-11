namespace UpDate
{
    partial class MainForm
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
            this.tabNav = new System.Windows.Forms.TabControl();
            this.changeDatesTab = new System.Windows.Forms.TabPage();
            this.folderSelectTextBox = new System.Windows.Forms.TextBox();
            this.folderSelectButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.openTitleDateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datesToChangeList = new System.Windows.Forms.CheckedListBox();
            this.imagesDataGrid = new System.Windows.Forms.DataGridView();
            this.DisplayImageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayImageExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayImageSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.selectedAmountLabel = new System.Windows.Forms.Label();
            this.manageDuplicatesTab = new System.Windows.Forms.TabPage();
            this.tabNav.SuspendLayout();
            this.changeDatesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNav
            // 
            this.tabNav.Controls.Add(this.changeDatesTab);
            this.tabNav.Controls.Add(this.manageDuplicatesTab);
            this.tabNav.Location = new System.Drawing.Point(13, 13);
            this.tabNav.Name = "tabNav";
            this.tabNav.SelectedIndex = 0;
            this.tabNav.Size = new System.Drawing.Size(1105, 522);
            this.tabNav.TabIndex = 2;
            // 
            // changeDatesTab
            // 
            this.changeDatesTab.Controls.Add(this.folderSelectTextBox);
            this.changeDatesTab.Controls.Add(this.folderSelectButton);
            this.changeDatesTab.Controls.Add(this.splitContainer1);
            this.changeDatesTab.Location = new System.Drawing.Point(4, 22);
            this.changeDatesTab.Name = "changeDatesTab";
            this.changeDatesTab.Padding = new System.Windows.Forms.Padding(3);
            this.changeDatesTab.Size = new System.Drawing.Size(1097, 496);
            this.changeDatesTab.TabIndex = 0;
            this.changeDatesTab.Text = "Manage dates";
            this.changeDatesTab.UseVisualStyleBackColor = true;
            // 
            // folderSelectTextBox
            // 
            this.folderSelectTextBox.Location = new System.Drawing.Point(6, 6);
            this.folderSelectTextBox.Name = "folderSelectTextBox";
            this.folderSelectTextBox.ReadOnly = true;
            this.folderSelectTextBox.Size = new System.Drawing.Size(708, 20);
            this.folderSelectTextBox.TabIndex = 1;
            // 
            // folderSelectButton
            // 
            this.folderSelectButton.Location = new System.Drawing.Point(720, 4);
            this.folderSelectButton.Name = "folderSelectButton";
            this.folderSelectButton.Size = new System.Drawing.Size(75, 23);
            this.folderSelectButton.TabIndex = 0;
            this.folderSelectButton.Text = "Select folder";
            this.folderSelectButton.UseVisualStyleBackColor = true;
            this.folderSelectButton.Click += new System.EventHandler(this.folderSelectButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(7, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imagesDataGrid);
            this.splitContainer1.Panel2.Controls.Add(this.totalAmountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.selectedAmountLabel);
            this.splitContainer1.Size = new System.Drawing.Size(1090, 463);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.goButton);
            this.groupBox2.Controls.Add(this.openTitleDateButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(14, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date to use";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(10, 29);
            this.maskedTextBox1.Mask = "0000-00-00 00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(236, 20);
            this.maskedTextBox1.TabIndex = 11;
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.Transparent;
            this.goButton.FlatAppearance.BorderSize = 0;
            this.goButton.Location = new System.Drawing.Point(10, 134);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(154, 23);
            this.goButton.TabIndex = 9;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // openTitleDateButton
            // 
            this.openTitleDateButton.Location = new System.Drawing.Point(12, 89);
            this.openTitleDateButton.Name = "openTitleDateButton";
            this.openTitleDateButton.Size = new System.Drawing.Size(152, 23);
            this.openTitleDateButton.TabIndex = 7;
            this.openTitleDateButton.Text = "Configure";
            this.openTitleDateButton.UseVisualStyleBackColor = true;
            this.openTitleDateButton.Click += new System.EventHandler(this.openTitleDateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date from imagename";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datesToChangeList);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dates to change";
            // 
            // datesToChangeList
            // 
            this.datesToChangeList.CheckOnClick = true;
            this.datesToChangeList.FormattingEnabled = true;
            this.datesToChangeList.Items.AddRange(new object[] {
            "Date created",
            "Date modified",
            "Date taken"});
            this.datesToChangeList.Location = new System.Drawing.Point(18, 28);
            this.datesToChangeList.Name = "datesToChangeList";
            this.datesToChangeList.Size = new System.Drawing.Size(95, 49);
            this.datesToChangeList.TabIndex = 1;
            // 
            // imagesDataGrid
            // 
            this.imagesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imagesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DisplayImageName,
            this.Date,
            this.DisplayImageExtension,
            this.DisplayImageSize});
            this.imagesDataGrid.Location = new System.Drawing.Point(37, 25);
            this.imagesDataGrid.Name = "imagesDataGrid";
            this.imagesDataGrid.RowHeadersVisible = false;
            this.imagesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.imagesDataGrid.Size = new System.Drawing.Size(715, 429);
            this.imagesDataGrid.TabIndex = 3;
            // 
            // DisplayImageName
            // 
            this.DisplayImageName.DataPropertyName = "Name";
            this.DisplayImageName.HeaderText = "Name";
            this.DisplayImageName.Name = "DisplayImageName";
            this.DisplayImageName.ReadOnly = true;
            this.DisplayImageName.Width = 300;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // DisplayImageExtension
            // 
            this.DisplayImageExtension.DataPropertyName = "Extension";
            this.DisplayImageExtension.HeaderText = "Extension";
            this.DisplayImageExtension.Name = "DisplayImageExtension";
            this.DisplayImageExtension.ReadOnly = true;
            // 
            // DisplayImageSize
            // 
            this.DisplayImageSize.DataPropertyName = "Size";
            this.DisplayImageSize.HeaderText = "Size";
            this.DisplayImageSize.Name = "DisplayImageSize";
            this.DisplayImageSize.ReadOnly = true;
            this.DisplayImageSize.Width = 80;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Location = new System.Drawing.Point(34, 8);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(35, 13);
            this.totalAmountLabel.TabIndex = 2;
            this.totalAmountLabel.Text = "label4";
            this.totalAmountLabel.Visible = false;
            // 
            // selectedAmountLabel
            // 
            this.selectedAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedAmountLabel.AutoSize = true;
            this.selectedAmountLabel.Location = new System.Drawing.Point(717, 8);
            this.selectedAmountLabel.Name = "selectedAmountLabel";
            this.selectedAmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectedAmountLabel.Size = new System.Drawing.Size(35, 13);
            this.selectedAmountLabel.TabIndex = 1;
            this.selectedAmountLabel.Text = "label4";
            this.selectedAmountLabel.Visible = false;
            // 
            // manageDuplicatesTab
            // 
            this.manageDuplicatesTab.Location = new System.Drawing.Point(4, 22);
            this.manageDuplicatesTab.Name = "manageDuplicatesTab";
            this.manageDuplicatesTab.Padding = new System.Windows.Forms.Padding(3);
            this.manageDuplicatesTab.Size = new System.Drawing.Size(1097, 496);
            this.manageDuplicatesTab.TabIndex = 1;
            this.manageDuplicatesTab.Text = "Manage duplicates";
            this.manageDuplicatesTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 534);
            this.Controls.Add(this.tabNav);
            this.Name = "MainForm";
            this.Text = "RoobSoft";
            this.tabNav.ResumeLayout(false);
            this.changeDatesTab.ResumeLayout(false);
            this.changeDatesTab.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabNav;
        private System.Windows.Forms.TabPage changeDatesTab;
        private System.Windows.Forms.TabPage manageDuplicatesTab;
        private System.Windows.Forms.TextBox folderSelectTextBox;
        private System.Windows.Forms.Button folderSelectButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox datesToChangeList;
        private System.Windows.Forms.Button openTitleDateButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Label selectedAmountLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ImageSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageSize;
        private System.Windows.Forms.DataGridView imagesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayImageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayImageExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayImageSize;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

