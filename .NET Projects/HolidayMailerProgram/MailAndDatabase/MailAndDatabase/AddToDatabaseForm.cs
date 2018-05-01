/*
Programmer Name: Maxwell Winston
Program Details: Allows a user to send holiday emails to other people pulled from an e-mail database based on a set filter by the user.
Also allows user to query and add to the database as they please

Extra Credit Attempted: Custom Database querying and Custom e-mail filtering implemented and fully working
*/

using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MailAndDatabase
{


    public partial class AddToDatabaseForm : Form
    {
        private SQLiteCommand com;
        private MainForm sqlConnectionContainer;
        private String category;
        private String email;
        private bool previousSender;
        public AddToDatabaseForm(MainForm main)
        {
            InitializeComponent();
            sqlConnectionContainer = main;
            category = "";
            email = "";
            previousSender = false;
            com = sqlConnectionContainer.sqlite_conn.CreateCommand();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(category.Equals("")||email.Equals(""))
            {
                MessageBox.Show("Before submitting you need to make sure that at least category and email address are filled out\n(name is not required, but makes later operations easier)","Uh Oh", MessageBoxButtons.OK);
            }
            else
            {
                //Help for this from http://stackoverflow.com/questions/843780/store-boolean-value-in-sqlite
                int flag = (previousSender) ? 1 : 0;
                
                com.CommandText = "INSERT OR IGNORE INTO HolidayMailingList (LastName,FirstName,EmailAddress,Category,PreviousSender) VALUES(\"" + lastNameBox.Text + "\", \"" + firstNameBox.Text + "\", \"" + email + "\", \"" + category + "\", " +flag  + ")";
                com.ExecuteNonQuery();
                MessageBox.Show("Attempting to Add to Database");
                this.Close();
                sqlConnectionContainer.Show();
            }
        }

        private void customCategory_TextChanged(object sender, EventArgs e)
        {
            category = customCategoryBox.Text;
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = "";
            customCategoryBox.Enabled = false;
            if(categoryBox.SelectedItem.Equals("Custom"))
            {
                customCategoryBox.Enabled = true;
            }
            else
            {
                category = categoryBox.SelectedItem.ToString();
            }
        }

        private void previousSenderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(previousSenderBox.SelectedItem.Equals("Yes"))
            {
                previousSender = true;
            }
            else
            {
                previousSender = false;
            }
        }

        private void emailBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                SubmitEmailButton_Click(sender, e);
            }
        }

        private void SubmitEmailButton_Click(object sender, EventArgs e)
        {
            if (!emailBox.Text.Contains("@"))
            {
                emailBox.Text = "Invalid e-mail detected: No @ found";
            }
            else if (!emailBox.Text.Contains("."))
            {
                emailBox.Text = "Invalid e-mail detected: No dots(.) found";
            }
            else if (emailBox.Text.IndexOf('@') == 0)
            {
                emailBox.Text = "Invalid e-mail detected: You need to have something before the @";
            }
            else
            {

                email = emailBox.Text;
                MessageBox.Show("E-mail set");
            }
        }

        private void AddToDatabaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnectionContainer.Show();
        }
    }
}
