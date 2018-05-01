using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystemWatcher
{
    public partial class FileSystemWatcherForm : Form
    {

        private Thread ConvertTextThread = null;
        private delegate void SetTextCallback(string text);
        private System.IO.FileSystemWatcher watchdog = new System.IO.FileSystemWatcher();

        public SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        private Stack<string> insertcommandStack;
        private DatabaseQuery form2;
        public FileSystemWatcherForm()
        {
            InitializeComponent();

            watchdog.Changed += new FileSystemEventHandler(OnChanged);
            watchdog.Created += new FileSystemEventHandler(OnChanged);
            watchdog.Deleted += new FileSystemEventHandler(OnChanged);
            watchdog.Renamed += new RenamedEventHandler(OnRenamed);
            insertcommandStack = new Stack<string>();
            watchdog.IncludeSubdirectories = true;
            watchdog.Filter = "*.*";
            CenterToScreen();
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=False;Compress=True;");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS test (DateLogged varchar(100), TimeOfChange varchar(40), Name varchar(100), Extension varchar(50), PATH varchar(100), ChangeType varchar(200))";
            sqlite_cmd.ExecuteNonQuery();
            form2 = new DatabaseQuery(this);
            
        }

        

        
        private void ProgramDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show(("Programmer: Maxwell Winston" + Environment.NewLine + "Current Version: 0.0.1.0"+Environment.NewLine+"Program Use: Monitors changes to specified files and directories and saves it to a database.  Also allows the user to query the database for entries based on a specified file extension"+Environment.NewLine),"Program Details",
            MessageBoxButtons.OK);
        }

   


        private void EnterFilter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                watchdog.Filter = FilterSetter.Text;
                DisplayLog.Text += "Filter for FileSystemWatcher set to " + FilterSetter.Text+Environment.NewLine;
            }
        }

        private void EnterPath(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!File.Exists(DirectoryPath.Text) && !Directory.Exists(DirectoryPath.Text))
                {
                    DisplayLog.Text = "Directory or File does not exist, please try again" + Environment.NewLine;
                }
                else
                {
                    watchdog.Path = DirectoryPath.Text;
                    DisplayLog.Text += "File Watcher path set to: " + DirectoryPath.Text + Environment.NewLine;
                }
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
           if(watchdog.Path=="")
            {
                DisplayLog.Text = "Please set a path before using.";
            }
           else
            {
                watchdog.EnableRaisingEvents = true;
                StartButton.Enabled = false;
                DirectoryPath.Enabled = false;
                FilterSetter.Enabled = false;
                SubmitFilter.Enabled = false;
                SubmitPath.Enabled = false;
            }
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            watchdog.EnableRaisingEvents = false;
            DirectoryPath.Enabled = true;
            FilterSetter.Enabled = true;
            StartButton.Enabled = true;
            SubmitFilter.Enabled = true;
            SubmitPath.Enabled = true;
            DisplayLog.Text = "FileSystemWatcher Stopped"+Environment.NewLine;
            DialogResult dr=MessageBox.Show("Would you like to save to a database?", "Save?", MessageBoxButtons.YesNo);
            if(dr==DialogResult.Yes)
            {
                DisplayLog.Text += "Saving to Database";
                while (insertcommandStack.Count > 0)
                {
                    sqlite_cmd.CommandText = insertcommandStack.Pop();
                    sqlite_cmd.ExecuteNonQuery();
                }
            }
        }


        //FILESYSTEMWATCHER EVENTS
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            this.ConvertTextThread = new Thread(() => this.SafeOnChanged(e));
            this.ConvertTextThread.Start();
        }


        private void SafeOnChanged(FileSystemEventArgs e)
        {
            string tempText = e.Name + "  " + e.FullPath + "  " + e.FullPath + "  " + e.ChangeType + " " + DateTime.Now.ToString() + Environment.NewLine;
            string curdate = "\"" + DateTime.Now.ToString("MM-dd-yyyy") + "\"";
            string curtime = "\"" + DateTime.Now.ToString("HH:mm") + "\"";
            string fileName = "\"" + e.Name.ToString() + "\"";
            string fileExtension = "\"" + Path.GetExtension(e.FullPath) + "\"";
            string filePath = "\"" + e.FullPath.ToString() + "\"";
            string changetype = "\"" + e.ChangeType.ToString() + "\"";
            string type = e.GetType().ToString();

            insertcommandStack.Push("INSERT INTO test(DateLogged, TimeOfChange, Name, Extension, PATH, ChangeType) VALUES(" + curdate + ", " + curtime + ", " + fileName + ", " + fileExtension + ", " + filePath + ", " + changetype + ")");
            SetText(tempText);
        }
        private void OnRenamed(object source, RenamedEventArgs e)
        {
            this.ConvertTextThread = new Thread(() => this.SafeOnRenamed(e));
            this.ConvertTextThread.Start();
        }

        private void SafeOnRenamed(RenamedEventArgs e)
        {
            string tempText = e.OldName + ": " + e.OldFullPath + "renamed to" + e.FullPath + "  | " + DateTime.Now.ToString() + Environment.NewLine;
            string curdate = "\"" + DateTime.Now.ToString("MM-dd-yyyy") + "\"";
            string curtime = "\"" + DateTime.Now.ToString("HH:mm") + "\"";
            string fileName = "\"" + e.Name.ToString() + "\"";
            string fileExtension = "\"" + Path.GetExtension(e.FullPath).ToString() + "\"";
            string filePath = "\"" + e.OldFullPath + "\"";
            string descriptionOfChange = "\"" + e.ChangeType + "\"";
            insertcommandStack.Push("INSERT INTO test(DateLogged,TimeOfChange, Name, Extension, PATH, ChangeType) VALUES(" + curdate + ", " + curtime + ", " + fileName + ", " + fileExtension + ", " + filePath + ", " + descriptionOfChange + ")");

            SetText(tempText);
        }




        private void SetText(string text)
        {
            if(this.DisplayLog.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.BeginInvoke(d, new object[] { text });
            }
            else
            {
                this.DisplayLog.Text += text;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr= MessageBox.Show("Do you really want to close the program?" + Environment.NewLine + "If you have not already saved your data to the database, I would say no :-)","Closing Event",MessageBoxButtons.YesNo);

            if(dr==DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                sqlite_conn.Close();
                e.Cancel = false;
                
            }

        }

        private void form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form2.Hide();
        }

        private void ToolStripExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatabaseSave_Click(object sender, EventArgs e)
        {
            watchdog.EnableRaisingEvents = false;
            DirectoryPath.Enabled = true;
            FilterSetter.Enabled = true;
            StartButton.Enabled = true;
            SubmitFilter.Enabled = true;
            SubmitPath.Enabled = true;

            DisplayLog.Text = "FileSystemWatcher Stopped, Saving to Database"+Environment.NewLine;
            while (insertcommandStack.Count>0)
            {
                sqlite_cmd.CommandText = insertcommandStack.Pop();
                sqlite_cmd.ExecuteNonQuery();
            }
            
        }

        private void QueryDatabaseButton_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void SubmitPath_Click(object sender, EventArgs e)
        {
            if (!File.Exists(DirectoryPath.Text) && !Directory.Exists(DirectoryPath.Text))
            {
                DisplayLog.Text = "Directory or File does not exist, please try again" + Environment.NewLine;
            }
            else
            {
                watchdog.Path = DirectoryPath.Text;
                DisplayLog.Text += "File Watcher path set to: " + DirectoryPath.Text + Environment.NewLine;
            }
        }

        private void SubmitFilter_Click(object sender, EventArgs e)
        {
            watchdog.Filter = FilterSetter.Text;
            DisplayLog.Text += "Filter for FileSystemWatcher set to " + FilterSetter.Text + Environment.NewLine;
        }

        private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayLog.Text = "Deleting Data from Table"+Environment.NewLine;
            sqlite_cmd.CommandText = "DROP TABLE test";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "CREATE TABLE test (DateLogged varchar(100), TimeOfChange varchar(40), Name varchar(100), Extension varchar(50), PATH varchar(100), ChangeType varchar(200))";
            sqlite_cmd.ExecuteNonQuery();
        }

    }
}
