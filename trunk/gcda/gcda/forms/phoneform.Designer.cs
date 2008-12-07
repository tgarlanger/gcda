namespace gcda.forms
{
    partial class phoneform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(phoneform));
            this.PhoneGroupBox = new System.Windows.Forms.GroupBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTypeComboBox = new System.Windows.Forms.ComboBox();
            this.PrimaryPhoneCheckBox = new System.Windows.Forms.CheckBox();
            this.PhoneGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhoneGroupBox
            // 
            this.PhoneGroupBox.Controls.Add(this.PrimaryPhoneCheckBox);
            this.PhoneGroupBox.Controls.Add(this.PhoneTypeComboBox);
            this.PhoneGroupBox.Controls.Add(this.PhoneNumberTextBox);
            this.PhoneGroupBox.Controls.Add(this.label2);
            this.PhoneGroupBox.Controls.Add(this.label1);
            this.PhoneGroupBox.Location = new System.Drawing.Point(12, 12);
            this.PhoneGroupBox.Name = "PhoneGroupBox";
            this.PhoneGroupBox.Size = new System.Drawing.Size(260, 92);
            this.PhoneGroupBox.TabIndex = 0;
            this.PhoneGroupBox.TabStop = false;
            this.PhoneGroupBox.Text = "Phone Number Info";
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(12, 110);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(197, 110);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "Ok";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Type:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(93, 19);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(161, 20);
            this.PhoneNumberTextBox.TabIndex = 2;
            // 
            // PhoneTypeComboBox
            // 
            this.PhoneTypeComboBox.FormattingEnabled = true;
            this.PhoneTypeComboBox.Items.AddRange(new object[] {
            "Home",
            "Work",
            "Mobile",
            "Home Fax",
            "Work Fax",
            "Pager",
            "Other"});
            this.PhoneTypeComboBox.Location = new System.Drawing.Point(93, 42);
            this.PhoneTypeComboBox.Name = "PhoneTypeComboBox";
            this.PhoneTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.PhoneTypeComboBox.TabIndex = 3;
            // 
            // PrimaryPhoneCheckBox
            // 
            this.PrimaryPhoneCheckBox.AutoSize = true;
            this.PrimaryPhoneCheckBox.Location = new System.Drawing.Point(93, 69);
            this.PrimaryPhoneCheckBox.Name = "PrimaryPhoneCheckBox";
            this.PrimaryPhoneCheckBox.Size = new System.Drawing.Size(100, 17);
            this.PrimaryPhoneCheckBox.TabIndex = 4;
            this.PrimaryPhoneCheckBox.Text = "Primary Phone?";
            this.PrimaryPhoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // phoneform
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(284, 145);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PhoneGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "phoneform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Phone Number";
            this.PhoneGroupBox.ResumeLayout(false);
            this.PhoneGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PhoneGroupBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PhoneTypeComboBox;
        private System.Windows.Forms.CheckBox PrimaryPhoneCheckBox;
    }
}