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
        /// <summary>
        /// Access to the User's User Name
        /// </summary>
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

        /// <summary>
        /// Access to the User's Password
        /// </summary>
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

        /// <summary>
        /// Default Constructor
        /// </summary>
        public LoginBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the Ok Button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Called when the Cancel Button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
