using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Google.GData.Client;
using Google.GData.Contacts;
using Google.GData.Extensions;

namespace gcda
{
    public partial class gcda : Form
    {
        private LoginBox login;

        public ContactsService CService;

        public ContactsFeed CFeed;

        public gcda()
        {
            InitializeComponent();

            CService = new ContactsService("gcda");
            CFeed = null;
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
            while (login.ShowDialog() != DialogResult.OK)
            {
                if (MessageBox.Show("You Must Log In", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
            }

            ContactsQuery query = new ContactsQuery(ContactsQuery.CreateContactsUri("default"));

            CService.setUserCredentials(login.UserName, login.Password);

            MainStatusLabel.Text = "Ready";
            UserNameStatusLabel.Text = "Logged in as " + login.UserName;

            CFeed = CService.Query(query);

            foreach (ContactEntry entry in CFeed.Entries)
            {
                if (entry.Title.Text.Length > 0)
                {
                    ContactListBox.Items.Add(entry.Title.Text);
                }
                //Console.WriteLine(entry.Title.Text);
                /*
                foreach (EMail email in entry.Emails)
                {
                }
                 */ 
            }
        }

        private void ContactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmailListBox.Items.Clear();
            IMListBox.Items.Clear();
            OrganizationListBox.Items.Clear();
            PhoneNumberListBox.Items.Clear();
            AddressesListBox.Items.Clear();

            int si = ContactListBox.SelectedIndex;
            NameTextBox.Text = CFeed.Entries[si].Title.Text;

            ContactEntry entry = (ContactEntry)CFeed.Entries[si];

            string address;

            foreach (EMail email in entry.Emails)
            {
                address = email.Address + " - ";

                if (email.Home)
                {
                    address += "Home";
                }
                else if (email.Work)
                {
                    address += "Work";
                }
                else if (email.Other)
                {
                    address += "Other";
                }
                EmailListBox.Items.Add(address);
            }
        }
    }
}
