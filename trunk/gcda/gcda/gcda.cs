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
using gcda.forms;

namespace gcda
{
    public enum eTYPE
    {
        HOME = 0, WORK, OTHER
    }

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

            LoadEmailAddresses(entry);
            LoadPhoneNumbers(entry);
            LoadIMClients(entry);
        }


//LOAD LIST BOXES
        #region LOAD_LIST_BOXES

        /// <summary>
        /// Retreive and load the contact's email addresses into the Email list
        /// </summary>
        /// <param name="entry">Contact to load emails for</param>
        private void LoadEmailAddresses(ContactEntry entry)
        {
            string address;

            EmailListBox.Items.Clear();

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

        /// <summary>
        /// Retreive and load the contact's phone numbers into the phone number list
        /// </summary>
        /// <param name="entry">Contact to load phone numbers for</param>
        private void LoadPhoneNumbers(ContactEntry entry)
        {
            string phonenumber;

            PhoneNumberListBox.Items.Clear();

            foreach (PhoneNumber phone in entry.Phonenumbers)
            {
                phonenumber = phone.Value + " - " + phone.Label;

                /*
                if (phone.Home)
                {
                    phonenumber += "Home";
                }
                else if (phone.Work)
                {
                    phonenumber += "Work";
                }
                else if (phone.Other)
                {
                    phonenumber += "Other";
                }
                 * */

                PhoneNumberListBox.Items.Add(phonenumber);
            }
        }

        /// <summary>
        /// Retreive and load the contact's IM Clients into the IM Client list
        /// </summary>
        /// <param name="entry">Contact to load IM Clients for</param>
        private void LoadIMClients(ContactEntry entry)
        {
            string imclient;

            IMListBox.Items.Clear();

            foreach (IMAddress im in entry.IMs)
            {
                imclient = im.Address + " - " + im.Protocol;

                IMListBox.Items.Add(imclient);
            }
        }

        /// <summary>
        /// Retreive and load the contact's Postal Addresses into the Addresse
        /// </summary>
        /// <param name="entry">Contact to load IM Clients for</param>
        private void LoadAddresses(ContactEntry entry)
        {
            string address;

            AddressesListBox.Items.Clear();

            foreach (PostalAddress pa in entry.PostalAddresses)
            {

            }
        }

        #endregion LOAD_LIST_BOXES


//EMAIL LIST BOX
        #region EMAIL_LIST_BOX

        private void EmailListBox_DoubleClick(object sender, EventArgs e)
        {
            if (EmailListBox.SelectedIndex != -1)
            {
                ContactEntry entry = (ContactEntry)CFeed.Entries[ContactListBox.SelectedIndex];

                EditEmailAddress(entry);
            }
        }

        private void EmailListBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Point pt = new Point(e.X, e.Y);
            int index = EmailListBox.IndexFromPoint(pt);
            lb.SelectedIndex = index;
        }

        private void EmailListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmailListBox.SelectedIndex == -1)
            {
                RightClickMenuStrip.Enabled = false;
            }
            else
            {
                RightClickMenuStrip.Enabled = true;
            }
        }

        #endregion EMAIL_LIST_BOX


//RIGHT CLICK MENU
        #region RIGHT_CLICK_MENU

        private void RightClickMenuStrip_Opened(object sender, EventArgs e)
        {
        }

        private void copyTextRightClickMenuItem_Click(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)RightClickMenuStrip.SourceControl;

            Clipboard.SetText(lb.SelectedItem.ToString());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)RightClickMenuStrip.SourceControl;

            lb.Items.RemoveAt(lb.SelectedIndex);
        }

        private void editRightClickMenuItem_Click(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)RightClickMenuStrip.SourceControl;

            switch (RightClickMenuStrip.SourceControl.Name)
            {
                case "EmailListBox":
                    break;
            }
        }

        #endregion RIGHT_CLICK_MENU

//EDIT FORM HELPERS
        #region EDIT_FORM_HELPERS

        private void EditEmailAddress(ContactEntry entry)
        {
            EmailForm ef = new EmailForm();

            ef.EmailAddress = entry.Emails[EmailListBox.SelectedIndex].Address;

            if (entry.Emails[EmailListBox.SelectedIndex].Home)
            {
                ef.EmailType = (int)eTYPE.HOME;
            }
            else if (entry.Emails[EmailListBox.SelectedIndex].Work)
            {
                ef.EmailType = (int)eTYPE.WORK;
            }
            else if (entry.Emails[EmailListBox.SelectedIndex].Other)
            {
                ef.EmailType = (int)eTYPE.OTHER;
            }

            switch (ef.ShowDialog(this))
            {
                case DialogResult.OK:
                    entry.Emails[EmailListBox.SelectedIndex].Address = ef.EmailAddress;

                    switch (ef.EmailType)
                    {
                        case (int)eTYPE.HOME:
                            entry.Emails[EmailListBox.SelectedIndex].Rel = ContactsRelationships.IsHome;
                            break;
                        case (int)eTYPE.WORK:
                            entry.Emails[EmailListBox.SelectedIndex].Rel = ContactsRelationships.IsWork;
                            break;
                        case (int)eTYPE.OTHER:
                            entry.Emails[EmailListBox.SelectedIndex].Rel = ContactsRelationships.IsOther;
                            break;
                    }
                    break;
                case DialogResult.Cancel:
                default:
                    break;
            }
        }

        #endregion EDIT_FORM_HELPERS
    }
}
