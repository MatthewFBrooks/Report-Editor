using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Report_Editor
{
    public partial class MainWindow : Form
    {

        //private string ConnStr = "";
        //private int NoUserPassError = 1;
        private List<Report> Reports;

        private int SelectedID = 0;
        private bool InhibitChangeWarning = false;
        private int ID;
        private string Timespan;
        private List<String> AcceptedTimespans = new List<string> { "Daily", "Weekly", "Monthly", "Quarterly", "Yearly" };
        private DateTime Date;
        private string Content;

        private  OleDbConnection Connection;

        private string ConnectionString
        {
            get
            {
                return "Provider=Microsoft.Jet.OLEDB.4.0;Data source=.\\Progress Reports.mdb";
            }
        }

        //public void GetUserPass()
        //{
        //    LoginPrompt login = new LoginPrompt();
        //    var prompt = login.ShowDialog();
        //    if (prompt == DialogResult.Cancel)
        //    {
        //        //Need to forcibly quit here, otherwise C# keeps running loops waiting for everything to return,
        //        //and I refuse to alter every single method to check if this one form politelty asks to quit.
        //        Environment.Exit(NoUserPassError);
        //        return;
        //    }
        //    else
        //    {
        //        userID = login.UserID;
        //        password = login.Password;
        //    }
        //}

        public MainWindow()
        {
            InitializeComponent();
            //this.Icon = ((System.Drawing.Icon)global::Report_Editor.Properties.Resources.Icon);
            SearchIntervalBox.SelectedIndex = 0;
            getReports();

        }

        private void getReports()
        {
            Reports = new List<Report>();
            Connection = new OleDbConnection();
            string GetCommand = "SELECT * FROM Reports";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = Connection;

            if (IntervalButton.Checked)
            {
                //MessageBox.Show(SearchIntervalBox.SelectedItem.ToString());
                if (SearchIntervalBox.SelectedItem.ToString() != "All")
                {
                    //MessageBox.Show(SearchIntervalBox.SelectedItem.ToString());
                    GetCommand += " WHERE Timespan = '" + SearchIntervalBox.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                //GetCommand += " WHERE Report LIKE '%Etiam%'"; 
                GetCommand += " WHERE LCase( Report ) LIKE @searchText";
                cmd.Parameters.Add(new OleDbParameter("@searchText", "%" + SearchTextBox.Text.ToLower() + "%"));
            }
            cmd.CommandText = GetCommand;

            //MessageBox.Show(GetCommand);
            //MessageBox.Show(cmd.Parameters);
            bool retry = false;
            do
            {
                retry = false;
                Connection.ConnectionString = ConnectionString;
                //MessageBox.Show(ConnectionString);
                try
                {
                    Connection.Open();

                    OleDbDataReader ReportsReader = cmd.ExecuteReader();
                    while (ReportsReader.Read())
                    {
                        Reports.Add(new Report((int)ReportsReader.GetValue(0), (string)ReportsReader.GetValue(1), (DateTime)ReportsReader.GetValue(2), (string)ReportsReader.GetValue(3)));
                    }
                    Connection.Close();
                }
                catch (OleDbException e)
                {
                    Connection.Close();
                    retry = HandleOleDbException(e);
                }
            } while (retry);

            ReportsGridView.Rows.Clear();
            foreach (Report report in Reports)
            {
                ReportsGridView.Rows.Add(report.ID, report.Date, report.Timespan, report.Content);
            }
        }

        private bool HandleOleDbException(OleDbException e)
        {
            if (e.Message.Contains("The server was not found or was not accessible."))
            {
                MessageBox.Show("The server could not be found, or could not be connected to.\n" +
                                "Please ensure that you have internet access.");
                this.Close();
            }
            else if (e.Message.Contains("Login failed for user"))
            {
                MessageBox.Show("Login failed.\n" +
                                "Please double-check username and password.");
                //GetUserPass();
                return true;
            }
            else
            {
                MessageBox.Show(e.GetType().ToString() + "\n" + e.Message);
            }
            return false;
        }

        private void NewReportButton_Click(object sender, EventArgs e)
        {
            ClearEditor();
            ContentBox.Enabled = true;
            ReportIntervalBox.Enabled = true;
            IntervalWarning.Visible = true;
            WarningLabel.Visible = true;
            EditButton.Enabled = false;
            CancelButton.Enabled = true;
            DeleteButton.Enabled = false;
            SaveButton.Enabled = false;
            ID = 0;
            //Reports.Add(new Report(0, "", DateTime.Now, ""));
            //refreshReports();
            //ReportsList.SelectedIndex = ReportsList.Items.Count - 1;
            //ReportsList_SelectedIndexChanged(sender, e);
        }

        private void ClearEditor()
        {
            ID = 0;
            Timespan = "";
            ReportIntervalBox.SelectedIndex = -1;
            Content = "";
            ContentBox.Text = "";
            Date = DateTime.Now;
            DateBox.Text = Date.ToString();
            IntervalWarning.Visible = false;
            WarningLabel.Visible = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Confirm("Delete report dated: " + DateBox.Text + "?", "Delete repoort", "Keep report") == false)
            {
                return;
            }
            if (ReportsGridView.SelectedRows[0].Index == -1)
            {
                return;
            }

            ClearEditor();

            DeleteReport(Reports[ReportsGridView.SelectedRows[0].Index].ID);
            //Reports.RemoveAt(ReportsList.SelectedIndex);
            //refreshReports();
            WarningLabel.Visible = false;
            getReports();
        }

        private void SaveButton_Click(object sender, EventArgs button_args)
        {
            if (Confirm("Save report?", "Save report", "Don't save report") == false)
            {
                //Do nothing, so they may continue editing.
                return;
            }

            if (ID == -1)
            {
                return;
            }
            if (ReportIntervalBox.SelectedItem == null)
            {
                IntervalWarning.Visible = true;
                ReportIntervalBox.BackColor = System.Drawing.Color.Red;
                return;
            }
            ReportIntervalBox.BackColor = Control.DefaultBackColor;
            IntervalWarning.Visible = false;
            Content = ContentBox.Text;
            //int index = ReportsList.SelectedIndex;
            //Reports[index].Content = Content;
            //refreshReports();
            //ReportsList.SelectedIndex = index;
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection;

            if (ID == 0)
            {
                command.CommandText = "INSERT INTO Reports (Timespan, ReportDate, Report) VALUES (@Timespan, @Date, @Report);";
                command.Parameters.Add("@Timespan", OleDbType.VarChar, 11).Value = Timespan;
                command.Parameters.Add("@Date", OleDbType.Date).Value = Date;
                command.Parameters.Add("@Report", OleDbType.VarChar, -1).Value = Content;
            }
            else
            {
                command.CommandText = "UPDATE Reports " +
                                      "SET Timespan = @Timespan, Report = @Report " +
                                      "WHERE ID = @ID;";
                command.Parameters.Add("@Timespan", OleDbType.VarChar, 11).Value = Timespan;
                command.Parameters.Add("@Report", OleDbType.VarChar, -1).Value = Content;
                command.Parameters.Add("@ID", OleDbType.Integer).Value = ID;
            }
            //MessageBox.Show(command.CommandText);
            //MessageBox.Show(command.Parameters[0].Value + ", " + command.Parameters[1].Value + ", " + command.Parameters[2].Value);

            bool retry = false;
            do
            {
                retry = false;
                Connection.ConnectionString = ConnectionString;
                try
                {
                    Connection.Open();
                    command.ExecuteNonQuery();
                    Connection.Close();
                }
                catch (OleDbException e)
                {
                    Connection.Close();
                    retry = HandleOleDbException(e);
                }
            } while (retry);

            WarningLabel.Visible = false;
            EditButton.Enabled = false;
            CancelButton.Enabled = false;
            ContentBox.Enabled = false;
            ReportIntervalBox.Enabled = false;

            getReports();

            //Change report ID to be the one generated from the database.
            //    command = new OleDbCommand();
            //    command.CommandText = "SELECT TOP 1 ID FROM Reports ORDER BY ID DESC";
            //    command.Connection = conn;
            //    conn.Open();
            //    OleDbDataReader ReportsReader = command.ExecuteReader();
            //    while (ReportsReader.Read())
            //    {
            //        Reports[index].ID = (int)ReportsReader.GetValue(0);
            //    }
            //    conn.Close();
        }

        private void DeleteReport(int deleteID)
        {
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection;
            command.CommandText = "DELETE FROM Reports WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", deleteID);
            bool retry = false;
            do
            {
                retry = false;
                Connection.ConnectionString = ConnectionString;
                try
                {
                    Connection.Open();
                    command.ExecuteNonQuery();
                    Connection.Close();
                }
                catch (OleDbException e)
                {
                    Connection.Close();
                    retry = HandleOleDbException(e);
                }
            } while (retry);
            WarningLabel.Visible = false;
        }

        private void ContentBox_TextChanged(object sender, EventArgs e)
        {
            WarningLabel.Visible = true;
            if (ReportIntervalBox.SelectedIndex != -1)
            {
                SaveButton.Enabled = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Part of my group project for CITC Capstone course.\n" +
                            "Program written by Matthew Brooks.");
        }

        private void openDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextButton_CheckedChanged(object sender, EventArgs e)
        {
            SearchIntervalBox.Enabled = false;
            SearchTextBox.Enabled = true;
        }

        private void IntervalButton_CheckedChanged(object sender, EventArgs e)
        {
            SearchIntervalBox.Enabled = true;
            SearchTextBox.Enabled = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            getReports();
        }

        private void ReportIntervalBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReportIntervalBox.SelectedItem != null)
            {
                ReportIntervalBox.BackColor = Control.DefaultBackColor;
                IntervalWarning.Visible = false;
                WarningLabel.Visible = true;
                Timespan = ReportIntervalBox.SelectedItem.ToString();
                SaveButton.Enabled = true;
            }
            else
            {
                Timespan = "";
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ContentBox.Enabled = true;
            ReportIntervalBox.Enabled = true;
            CancelButton.Enabled = true;
            EditButton.Enabled = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (Confirm("Discard changes?", "Discard changes", "Keep changes") == false)
            {
                //Do nothing, so they may continue editing.
                return;
            }
            ClearEditor();
            DateBox.Text = "";
            ContentBox.Enabled = false;
            ReportIntervalBox.Enabled = false;
            EditButton.Enabled = false;
            CancelButton.Enabled = false;
            SaveButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void ReportsGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (InhibitChangeWarning)
            {
                InhibitChangeWarning = false;
                return;
            }
            if (WarningLabel.Visible || IntervalWarning.Visible)
            {
                MessageBox.Show("Unsaved changes made to report. Please cancel them or save them before selecting a new report.");
                InhibitChangeWarning = true;
                foreach (DataGridViewRow row in ReportsGridView.Rows)
                {
                    if ((int)row.Cells[0].Value == SelectedID)
                    {
                        row.Selected = true;
                    }
                }
                return;
            }
            if (ReportsGridView.SelectedRows.Count == 0 || ReportsGridView.SelectedRows[0].Index == -1)
            {
                return;
            }
            //VisualStudio can't handle the fact that this var gets assigned in the foreach, and forces a redundant assignment.
            Report SelectedReport = new Report(0, "Daily", DateTime.Now, "");
            foreach (Report report in Reports)
            {
                if (report.ID == (int)ReportsGridView.SelectedRows[0].Cells[0].Value)
                {
                    SelectedReport = report;
                    break;
                }
            }
            SelectedID = (int)ReportsGridView.SelectedRows[0].Cells[0].Value;
            ID = SelectedReport.ID;
            Timespan = SelectedReport.Timespan;
            ReportIntervalBox.SelectedItem = Timespan;
            Date = SelectedReport.Date;
            DateBox.Text = Date.ToString();

            Content = SelectedReport.Content;
            ContentBox.Text = Content;
            WarningLabel.Visible = false;

            ContentBox.Enabled = false;
            ReportIntervalBox.Enabled = false;
            EditButton.Enabled = true;
            CancelButton.Enabled = false;
            DeleteButton.Enabled = true;
            SaveButton.Enabled = false;
        }

        private bool Confirm(string Message, string YesButton, string NoButton)
        {
            bool result = false;
            using (var dialog = new ConfirmationDialog(Message, YesButton, NoButton))
            {
                var DialogResult = dialog.ShowDialog();
                result = dialog.Result;
            }
            return result;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Give the splash screen some time to show up.
            //this.Hide();
        }
    }
}
