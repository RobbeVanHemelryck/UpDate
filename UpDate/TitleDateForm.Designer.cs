namespace UpDate
{
    partial class TitleDateForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scenario1Actions = new System.Windows.Forms.DataGridView();
            this.OldValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scenario1Conditions = new System.Windows.Forms.DataGridView();
            this.Condition = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseSensitive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.formats = new System.Windows.Forms.DataGridView();
            this.Format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scenario1Actions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scenario1Conditions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.scenario1Actions);
            this.groupBox1.Controls.Add(this.scenario1Conditions);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 327);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scenario 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Actions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Conditions";
            // 
            // scenario1Actions
            // 
            this.scenario1Actions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scenario1Actions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OldValue,
            this.NewValue});
            this.scenario1Actions.Location = new System.Drawing.Point(37, 206);
            this.scenario1Actions.Name = "scenario1Actions";
            this.scenario1Actions.Size = new System.Drawing.Size(517, 105);
            this.scenario1Actions.TabIndex = 0;
            // 
            // OldValue
            // 
            this.OldValue.HeaderText = "Value to replace";
            this.OldValue.Name = "OldValue";
            this.OldValue.Width = 200;
            // 
            // NewValue
            // 
            this.NewValue.HeaderText = "New value";
            this.NewValue.Name = "NewValue";
            this.NewValue.Width = 200;
            // 
            // scenario1Conditions
            // 
            this.scenario1Conditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scenario1Conditions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Condition,
            this.Value,
            this.CaseSensitive});
            this.scenario1Conditions.Location = new System.Drawing.Point(37, 49);
            this.scenario1Conditions.Name = "scenario1Conditions";
            this.scenario1Conditions.Size = new System.Drawing.Size(517, 105);
            this.scenario1Conditions.TabIndex = 0;
            // 
            // Condition
            // 
            this.Condition.HeaderText = "Expression";
            this.Condition.Items.AddRange(new object[] {
            "starts with",
            "end with",
            "contains"});
            this.Condition.Name = "Condition";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 200;
            // 
            // CaseSensitive
            // 
            this.CaseSensitive.HeaderText = "Case sensitive";
            this.CaseSensitive.Name = "CaseSensitive";
            // 
            // formats
            // 
            this.formats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Format});
            this.formats.Location = new System.Drawing.Point(17, 37);
            this.formats.Name = "formats";
            this.formats.Size = new System.Drawing.Size(244, 148);
            this.formats.TabIndex = 3;
            // 
            // Format
            // 
            this.Format.HeaderText = "Format";
            this.Format.Name = "Format";
            this.Format.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Define date formats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "How to extract date from filename";
            // 
            // TitleDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 707);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formats);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TitleDateForm";
            this.Text = "Configure how to extact dates from imagenames";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scenario1Actions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scenario1Conditions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView formats;
        private System.Windows.Forms.DataGridView scenario1Conditions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Format;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView scenario1Actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn OldValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewValue;
        private System.Windows.Forms.DataGridViewComboBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CaseSensitive;
    }
}