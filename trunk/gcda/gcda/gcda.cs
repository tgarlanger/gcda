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

            try
            {
                ContactEntry entry = (ContactEntry)CFeed.Entries[si];

                LoadEmailAddresses(entry);
                LoadPhoneNumbers(entry);
                LoadIMClients(entry);
                LoadAddresses(entry);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.ToString());
            }
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
                if (email.Primary)
                {
                    address = "* ";
                }
                else
                {
                    address = "";
                }

                address += email.Address + " - ";

                switch (email.Rel)
                {
                    case ContactsRelationships.IsHome:
                        address += "Home";
                        break;
                    case ContactsRelationships.IsWork:
                        address += "Work";
                        break;
                    case ContactsRelationships.IsOther:
                    default:
                        address += "Other";
                        break;
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
                phonenumber = phone.Value + " - ";

                switch (phone.Rel)
                {
                    case ContactsRelationships.IsHome:
                        phonenumber += "Home";
                        break;
                    case ContactsRelationships.IsHomeFax:
                        phonenumber += "Home Fax";
                        break;
                    case ContactsRelationships.IsWork:
                        phonenumber += "Work";
                        break;
                    case ContactsRelationships.IsWorkFax:
                        phonenumber += "Work Fax";
                        break;
                    case ContactsRelationships.IsMobile:
                        phonenumber += "Mobile";
                        break;
                    case ContactsRelationships.IsPager:
                        phonenumber += "Pager";
                        break;
                    case ContactsRelationships.IsOther:
                    default:
                        phonenumber += "Other";
                        break;
                }

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
            char delim = '#';
            string[] client_split = new string[2];

            IMListBox.Items.Clear();

            foreach (IMAddress im in entry.IMs)
            {
                client_split = im.Protocol.Split(delim);

                imclient = im.Address + " - " + client_split[1];

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

            //MessageBox.Show(entry.PostalAddresses.Count.ToString());

            foreach (PostalAddress pa in entry.PostalAddresses)
            {
                address = pa.Value;
                AddressesListBox.Items.Add(pa.Value);
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
                    ContactEntry entry = (ContactEntry)CFeed.Entries[ContactListBox.SelectedIndex];

                    EditEmailAddress(entry);
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

            switch (entry.Emails[EmailListBox.SelectedIndex].Rel)
            {
                case ContactsRelationships.IsHome:
                    ef.EmailType = 0;
                    break;
                case ContactsRelationships.IsWork:
                    ef.EmailType = 1;
                    break;
                case ContactsRelationships.IsOther:
                default:
                    ef.EmailType = 2;
                    break;
            }

            ef.PrimaryEmail = entry.Emails[EmailListBox.SelectedIndex].Primary;

            switch (ef.ShowDialog(this))
            {
                case DialogResult.OK:
                    entry.Emails[EmailListBox.SelectedIndex].Address = ef.EmailAddress;

                    switch (ef.EmailType)
                    {
                        case 0:
                            entry.Emails[EmailListBox.SelectedIndex].Rel = ContactsRelationships.IsHome;
                            break;
                        case 1:
                            entry.Emails[EmailListBox.SelectedIndex].Rel = ContactsRelationships.IsWork;
                            break;
                        case 2:
                        default:
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void gcda_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    
    }
}
