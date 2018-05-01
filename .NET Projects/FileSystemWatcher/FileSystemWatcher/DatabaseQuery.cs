using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FileSystemWatcher
{
    public partial class DatabaseQuery : Form
    {
        private FileSystemWatcherForm main;
        private SQLiteCommand com;
        public DatabaseQuery(FileSystemWatcherForm mainform)
        {
            InitializeComponent();
            main = mainform;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
            this.Hide();
            e.Cancel = true;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string command;
            com = main.sqlite_conn.CreateCommand();
            if (ExtensionList.Text == "All")
            {
                command = "SELECT * FROM test";
            }
            else if(ExtensionList.Text=="Files")
            {
                command = "SELECT * FROM test WHERE Extension=''";
            }
            else
            {
                command = "SELECT * FROM test WHERE Extension=\"" + ExtensionList.Text+"\"";
            }
            ExtensionList.Enabled = false;
            SQLiteDataAdapter tester = new SQLiteDataAdapter(command, main.sqlite_conn);
            //Code From https://msdn.microsoft.com/en-us/library/fbk67b6z(v=vs.110).aspx
            using (DataTable dt = new DataTable())
            {
                tester.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            ExtensionList.Enabled = true;
           
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();
        }
    }
}
