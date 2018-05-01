using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailAndDatabase
{
    public partial class DatabaseQueryForm : Form
    {
        private MainForm DatabaseConnector;
        private String command;
        private String tempHolder;
        public DatabaseQueryForm(MainForm main)
        {
            InitializeComponent();
            DatabaseConnector = main;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void Everyone_Click(object sender, EventArgs e)
        {
            SearchFilterBox.Enabled = false;
            SubmitButton.Enabled = false;
            command = "SELECT * FROM HolidayMailingList";
            SubmitButton.Enabled = true;
            tempHolder = "";
        }

        

        private void ByLastName_Click(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
            SearchFilterBox.Enabled = true;
            SearchFilterBox.Text = "";
            tempHolder = "SELECT * FROM HolidayMailingList WHERE LastName ";
        }

        private void LastInitial_Click(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
            SearchFilterBox.Enabled = true;
            SearchFilterBox.Text = "";
            tempHolder = "SELECT * FROM HolidayMailingList WHERE LastName LIKE ";
        }
        private void FirstName_Click(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
            SearchFilterBox.Enabled = true;
            SearchFilterBox.Text = "";
            tempHolder = "SELECT * FROM HolidayMailingList WHERE FirstName ";
        }

        private void FirstInitial_Click(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
            SearchFilterBox.Enabled = true;
            SearchFilterBox.Text = "";
            tempHolder = "SELECT * FROM HolidayMailingList WHERE FirstName LIKE ";

        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            SearchBy.Enabled = false;
            if(SearchFilterBox.Enabled)
            {
                setupCustomCommand();
            }
            SQLiteDataAdapter list = new SQLiteDataAdapter(command, DatabaseConnector.sqlite_conn);
            using (DataTable dt = new DataTable())
            {
                list.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            SearchBy.Enabled = true;
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

        private void DatabaseQueryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseConnector.Show();
        }

        private void Category_Click(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
            SearchFilterBox.Enabled = true;
            SearchFilterBox.Text = "";
            tempHolder = "SELECT * FROM HolidayMailingList WHERE Category ";
        }

        private void EmailDomain_Click(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
            SearchFilterBox.Enabled = true;
            SearchFilterBox.Text = "";
            tempHolder = "SELECT * FROM HolidayMailingList WHERE EmailAddress LIKE ";
        }

        private void NoPreviousSenders_Click(object sender, EventArgs e)
        {
            SearchFilterBox.Enabled = false;
            command = "SELECT * FROM HolidayMailingList WHERE PreviousSender=0";
            SubmitButton.Enabled = true;
        }

        private void PreviousSenders_Click(object sender, EventArgs e)
        {
            SearchFilterBox.Enabled = false;
            command = "SELECT * FROM HolidayMailingList WHERE PreviousSender=1";
            SubmitButton.Enabled = true;
        }
    }
}
