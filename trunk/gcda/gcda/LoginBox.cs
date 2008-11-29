using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gcda
{
    public partial class LoginBox : Form
    {
        public string UserName
        {
            get
            {
                return UserNameTextBox.Text;
            }
            set
            {
                UserNameTextBox.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return PasswordTextBox.Text;
            }
            set
            {
                PasswordTextBox.Text = value;
            }
        }

        public LoginBox()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text.Length <= 3)
            {
                MessageBox.Show("User Name Too Short", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PasswordTextBox.Text.Length < 1)
            {
                MessageBox.Show("Password Cannot Be Left Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
