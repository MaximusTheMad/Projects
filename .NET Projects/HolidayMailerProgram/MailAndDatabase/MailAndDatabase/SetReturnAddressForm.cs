/*
Programmer Name: Maxwell Winston
Program Details: Allows a user to send holiday emails to other people pulled from an e-mail database based on a set filter by the user.
Also allows user to query and add to the database as they please

Extra Credit Attempted: Custom Database querying and Custom e-mail filtering implemented and fully working
*/
using System;
using System.Linq;
using System.Windows.Forms;

namespace MailAndDatabase
{
    public partial class SetReturnAddressForm : Form
    {
        private MainForm mainForm = null;
        private int SMTPport;
        private String SMTPserver;
        private String emailAddress;
        private String username;
        private String password;

        public SetReturnAddressForm(MainForm fromForm)
        {
            SMTPport = -1;
            SMTPserver = "";
            emailAddress = "";
            username = "";
            password = "";
            mainForm = fromForm;
            InitializeComponent();
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            username = usernameBox.Text;
            password = passwordBox.Text;
            MessageBox.Show("Username and Password Set","Username and Password Confirmation",MessageBoxButtons.OK);
        }

        private void SubmitSMTP_Click(object sender, EventArgs e)
        {
            int temp = -1;
            if (Int32.TryParse(CustomSMTPBox.Text, out temp))
            {
                SMTPport = temp;
            }
            else
            {
                CustomSMTPBox.Text = "Numbers Only Please";
             }
           
        }

        private void SubmitEmail_Click(object sender, EventArgs e)
        {
            if(!addressText.Text.Contains("@"))
            {
                addressText.Text = "Invalid e-mail detected: No @ found";
            }
            else if(!addressText.Text.Contains("."))
            {
                addressText.Text = "Invalid e-mail detected: No dots(.) found";
            }
            else if(addressText.Text.IndexOf('@')==0)
            {
                addressText.Text = "Invalid e-mail detected: You need to have something before the @";
            }
            else
            {
                emailAddress = addressText.Text;
                EmailServerList.Enabled = true;
            }
        }

        private void EmailServerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SMTPport = -1;
            SMTPserver = "";
            if(EmailServerList.SelectedItem.Equals( "Custom (You'll need to add your STMP Port)"))
            {
                CustomSMTPBox.Enabled = true;
                CustomServer.Enabled = true;
                SubmitSMTPButton.Enabled = true;
                SubmitServerButton.Enabled = true;
                usernameBox.Enabled = true;
                passwordBox.Enabled = true;
                SubmitButton.Enabled = true;
            }
            else
            {
                setupSMTP();
                setServer();
                usernameBox.Enabled = true;
                passwordBox.Enabled = true;
                SubmitButton.Enabled = true;
            }
        }

        private void setupSMTP()
        {
       //Help from http://stackoverflow.com/questions/3907299/if-statements-matching-multiple-values
            if (new[] { 0, 1, 2, 7, 9, 12, 17, 20, 21, 23 }.Contains(EmailServerList.SelectedIndex))
            {
                SMTPport = 587;
            }
            else if (new[] {3,10,11,13,22,25,26,27,28,29,30}.Contains(EmailServerList.SelectedIndex))
            {
                SMTPport = 465;
            }
            else if(new[] {4,5,6,14,15,16,18,19,24}.Contains(EmailServerList.SelectedIndex))
            {
                SMTPport = 25;
            }

            

            
        }

        private void setServer()
        {
            if(!(EmailServerList.SelectedIndex==8))
            {
                String item = EmailServerList.SelectedItem.ToString();
                SMTPserver = item.Substring(item.IndexOf('{') + 1, item.IndexOf('}') - item.IndexOf('{')-1);

            }
        }

        private void SubmitServerButton_Click(object sender, EventArgs e)
        {
            SMTPserver = CustomServer.Text;
        }

        private void addressText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter||e.KeyCode==Keys.Return)
            {
                SubmitEmail_Click(sender, e);
            }
        }

        private void CustomSMTPBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                SubmitSMTP_Click(sender, e);
            }
        }

        private void CustomServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                SubmitServerButton_Click(sender, e);
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                SubmitButton_Click(sender, e);
            }
        }

        private void SetReturnAddressForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (emailAddress.Equals("") || SMTPport==-1 || SMTPserver.Equals("") || username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Insufficient information entered, you may not leave this form until it is fully filled out", "Uh Oh", MessageBoxButtons.OK);
                e.Cancel = true;
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure about the information you entered?", "Closing Form", MessageBoxButtons.YesNo);
                if (check.Equals(DialogResult.Yes))
                {
                    e.Cancel = false;
                    mainForm.Show();
                    mainForm.setReturnDetails(emailAddress, SMTPport, SMTPserver, username, password);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
