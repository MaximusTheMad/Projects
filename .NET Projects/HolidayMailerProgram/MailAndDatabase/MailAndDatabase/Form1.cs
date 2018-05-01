using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net.Mail;
using System.Data;
using System.Collections.Generic;
/*
Programmer Name: Maxwell Winston
Program Details: Allows a user to send holiday emails to other people pulled from an e-mail database based on a set filter by the user.
Also allows user to query and add to the database as they please

Extra Credit Attempted: Custom Database querying and Custom e-mail filtering implemented and fully working


*/
namespace MailAndDatabase
{
    public partial class MainForm : Form
    {
        private SQLiteCommand com;
        public SQLiteConnection sqlite_conn;
        private SetReturnAddressForm setAddressForm;
        private AddToDatabaseForm addToDatabase;
        private DatabaseQueryForm databaseQuerier;
        private CustomMessageFilterForm customFilterForm;
        private String returnAddress;
        private int SMTPPort;
        private String SMTPServer;
        private String username;
        private String password;
        private String readerCommand;
        private List<Attachment> attachmentList;
        public MainForm()
        {
            InitializeComponent();
            sqlite_conn = new SQLiteConnection("Data Source=HolidayMailDatabase.db;Version=3;New=False;Compress=True;");
            sqlite_conn.Open();
            com = sqlite_conn.CreateCommand();
            //No setting multiple people to one email address
            com.CommandText = "CREATE TABLE IF NOT EXISTS HolidayMailingList (LastName varchar(100), FirstName varchar(100), EmailAddress varchar(500) UNIQUE NOT NULL, Category varchar(100), PreviousSender int)";
            com.ExecuteNonQuery();
            SendButton.Enabled = false;

            attachmentList = new List<Attachment>();
            
        }


        private void setReturnAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setAddressForm = new SetReturnAddressForm(this);
            setAddressForm.Show();
            MessageFilterBox.Enabled = true;
            label3.Visible = false;
            button1.Visible = false;
            this.Hide();
        }

        private void MessageFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SendButton.Enabled = false;
            if (MessageFilterBox.SelectedItem.Equals("Custom (WILL OPEN CUSTOM FILTER FORM)"))
            {
                customFilterForm = new CustomMessageFilterForm(this);
                customFilterForm.Show();
                this.Hide();
            }
            else if (MessageFilterBox.SelectedItem.Equals("Everyone"))
            {
                this.setFilterCommand("SELECT EmailAddress FROM HolidayMailingList");
            }
            else
            {
                this.setFilterCommand("SELECT EmailAddress FROM HolidayMailingList WHERE Category=\"" + MessageFilterBox.SelectedItem + "\"");
            }
            MessageContentsBox.Enabled = true;
            subjectBox.Enabled = true;
        }
        public void setReturnDetails(String rA, int sP, String sS, String user, String pass)
        {
            returnAddress = rA;
            SMTPPort = sP;
            SMTPServer = sS;
            username = user;
            password = pass;
        }

        public void setFilterCommand(String command)
        {
            readerCommand = command;
        }
        private void addToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addToDatabase = new AddToDatabaseForm(this);
            addToDatabase.Show();
            this.Hide();
        }

        private void clearDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to do this?", "WARNING", MessageBoxButtons.YesNo);
            if (dr.Equals(DialogResult.Yes))
            {
                com.CommandText = "DROP TABLE HolidayMailingList";
                com.ExecuteNonQuery();
                com.CommandText = "CREATE TABLE IF NOT EXISTS HolidayMailingList (LastName varchar(100), FirstName varchar(100), EmailAddress varchar(500) UNIQUE NOT NULL, Category varchar(100), PreviousSender int)";
                com.ExecuteNonQuery();
                MessageBox.Show("Database cleared");
            }
        }

        private void queryDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseQuerier = new DatabaseQueryForm(this);
            databaseQuerier.Show();
            this.Hide();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
           SendButton.Enabled = false;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServ = new SmtpClient(SMTPServer);
                mail.Subject = subjectBox.Text;
                mail.Body = MessageContentsBox.Text;
                mail.From = new MailAddress(returnAddress);
                SmtpServ.Port = SMTPPort;
                SmtpServ.Credentials = new System.Net.NetworkCredential(username, password);
                SmtpServ.EnableSsl = true;
                com.CommandText = readerCommand;
                using (SQLiteDataReader rdr = com.ExecuteReader())
                {
                    while(rdr.Read())
                    {
                        mail.To.Add(rdr["EmailAddress"].ToString());
                    }
                }
                if(mail.To.Count==0)
                {
                    MessageBox.Show("There are no items in the database that fit the criteria you have selected for the filter");
                }
                
                else
                {
                    if (attachmentList.Count != 0)
                    {
                        foreach (Attachment a in attachmentList)
                        {
                            mail.Attachments.Add(a);
                        }
                    }
                    SmtpServ.Send(mail);
                    MessageBox.Show("E-mails sent\nIf you wish to send attachments again, you must readd them");
                    mail.Attachments.Clear();
                }
                
            }

            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong\n" + ex.ToString());
            }
            SendButton.Enabled = true;

            
        }

        private void MessageContentsBox_TextChanged(object sender, EventArgs e)
        {
            SendButton.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setReturnAddressToolStripMenuItem_Click(sender, e);
        }

        private void ProgramDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show(("Programmer: Maxwell Winston" + Environment.NewLine + "Current Version: 1.0.0.0" + Environment.NewLine + "Program Use: Allows a user to send out e-mails to other users pulled from an e-mail database based on criteria set by the user" + Environment.NewLine+".NET Framework: 4.6"), "Program Details",
            MessageBoxButtons.OK);
        }

        private void AttachFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                attachmentList.Add(new Attachment(openFileDialog1.FileName));
                MessageBox.Show("File Attachment Added");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr= MessageBox.Show("Are you sure you want to exit?", "Exiting Program", MessageBoxButtons.YesNo);
            if(dr.Equals(DialogResult.Yes))
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
