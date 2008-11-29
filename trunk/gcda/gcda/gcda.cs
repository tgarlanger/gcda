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
    public partial class gcda : Form
    {
        private LoginBox login;
        public gcda()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gcdaAboutBox ab = new gcdaAboutBox();

            ab.ShowDialog(this);
        }

        private void gcda_Load(object sender, EventArgs e)
        {
            login = new LoginBox();
        }

        private void gcda_Shown(object sender, EventArgs e)
        {
            login.ShowDialog();
        }
    }
}
