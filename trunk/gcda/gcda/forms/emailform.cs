using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gcda.forms
{
    public partial class EmailForm : Form
    {
        public string EmailAddress
        {
            get
            {
                return EmailTextBox.Text;
            }
            set
            {
                EmailTextBox.Text = value;
            }
        }

        public int EmailType
        {
            get
            {
                return EmailTypeComboBox.SelectedIndex;
            }
            set
            {
                EmailTypeComboBox.SelectedIndex = value;
            }
        }

        public EmailForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if ( EmailTextBox.Text.Length < 6 )
            {
                MessageBox.Show("Email Address Field Cannot Be Left Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
