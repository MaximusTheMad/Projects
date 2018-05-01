/*
Programmer Name: Maxwell Winston
Program Details: Allows a user to send holiday emails to other people pulled from an e-mail database based on a set filter by the user.
Also allows user to query and add to the database as they please

Extra Credit Attempted: Custom Database querying and Custom e-mail filtering implemented and fully working
*/
using System;
using System.Windows.Forms;

namespace MailAndDatabase
{
    public partial class CustomMessageFilterForm : Form
    {
        private String command;
        private String tempHolder;
        private MainForm mainForm;
        public CustomMessageFilterForm(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
            command = "";
        }



        private void ByLastName_Click(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
            SearchFilterBox.Enabled = true;
            SearchFilterBox.Text = "";
            tempHolder = "SELECT EmailAddress FROM HolidayMailingList WHERE LastName ";
        }

        private void LastInitial_Click(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
            SearchFilterBox.Enabled = true;
            SearchFilterBox.Text = "";
            tempHolder = "SELECT EmailAddress FROM HolidayMailingList WHERE LastName LIKE ";
        }
        private void FirstName_Click(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
            SearchFilterBox.Enabled = true;
            SearchFilterBox.Text = "";
            tempHolder = "SELECT EmailAddress FROM HolidayMailingList WHERE FirstName ";
        }

        private void FirstInitial_Click(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
            SearchFilterBox.Enabled = true;
            SearchFilterBox.Text = "";
            tempHolder = "SELECT EmailAddress FROM HolidayMailingList WHERE FirstName LIKE ";

        }

        private void Category_Click(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
            SearchFilterBox.Enabled = true;
            SearchFilterBox.Text = "";
            tempHolder = "SELECT EmailAddress FROM HolidayMailingList WHERE Category ";
        }

        private void EmailDomain_Click(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
            SearchFilterBox.Enabled = true;
            SearchFilterBox.Text = "";
            tempHolder = "SELECT EmailAddress FROM HolidayMailingList WHERE EmailAddress LIKE ";
        }

        private void NoPreviousSenders_Click(object sender, EventArgs e)
        {
            SearchFilterBox.Enabled = false;
            command = "SELECT EmailAddress FROM HolidayMailingList WHERE PreviousSender=0";
            SubmitButton.Enabled = true;
        }

        private void PreviousSenders_Click(object sender, EventArgs e)
        {
            SearchFilterBox.Enabled = false;
            command = "SELECT EmailAddress FROM HolidayMailingList WHERE PreviousSender=1";
            SubmitButton.Enabled = true;
        }

        private void setupCustomCommand()
        {
            if (FirstInitial.Checked)
            {
                command = tempHolder + "\"" + SearchFilterBox.Lines[0] + "%\"";
                for (int i = 1; i < SearchFilterBox.Lines.Length; i++)
                {
                    command += "OR FirstName LIKE \"" + SearchFilterBox.Lines[i] + "\"";
                }
            }
            if (LastInitial.Checked)
            {
                command = tempHolder + "\"" + SearchFilterBox.Lines[0] + "%\"";
                for (int i = 1; i < SearchFilterBox.Lines.Length; i++)
                {
                    command += "OR LastName LIKE \"" + SearchFilterBox.Lines[i] + "\"";
                }
            }

            else if (EmailDomain.Checked)
            {
                command = tempHolder + "\"%" + SearchFilterBox.Lines[0] + "\"";
                for (int i = 1; i < SearchFilterBox.Lines.Length; i++)
                {
                    command += "OR EmailAddress LIKE \"%" + SearchFilterBox.Lines[i] + "\"";
                }

            }
            else
            {
                command = tempHolder + "IN (\"" + SearchFilterBox.Lines[0] + "\"";
                for (int i = 1; i < SearchFilterBox.Lines.Length; i++)
                {
                    command += ", \"" + SearchFilterBox.Lines[i] + "\"";
                }
                command += ")";
            }

        }

        private void SearchFilterBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = true;
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (SearchFilterBox.Enabled)
            {
                setupCustomCommand();
            }
            mainForm.Show();
            mainForm.setFilterCommand(command);
            this.Close();
            
            
        }

        private void CustomMessageFilterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(command.Equals(""))
            {
                MessageBox.Show("You may not close this form until you have set a filter");
                e.Cancel = true;
            }
        }
    }
}
