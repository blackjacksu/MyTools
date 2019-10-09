using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvToSqliteConverter
{
    public partial class Form1 : Form
    {
        int counter = 0;
        string line;

        OpenFileDialog FileToOpen = new OpenFileDialog();
        SaveFileDialog FileToSave = new SaveFileDialog();


        private class AlertMsg
        {
            public string Uid = "--";
            public int Severity = -1;
            public string Category = "--";
            public string ErrorCode = "--";
            public string Description_EN = "Unknown error";
            public string Description_ZH = "Unknown error";
            public bool IsSelfTestable = false;
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void Write_Click(object sender, EventArgs e)
        {
            // Read the file and display it line by line.  
            System.IO.StreamReader csvFile =
                new System.IO.StreamReader(@"D:\DailyMission\VmaAlertDescription\test.txt");

            System.IO.StreamReader dbFile =
new System.IO.StreamReader(@"D:\DailyMission\VmaAlertDescription\AlertDescriptionDb\AlertDescriptionTest.db");

            while ((line = csvFile.ReadLine()) != null)
            {
                System.Console.WriteLine(line);

                UpdateSqlSelfTestable(GetIsSelfTestable(line));

                counter++;
            }

            csvFile.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
        }

        private void BrowseYourFile_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = FileToOpen.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = FileToOpen.FileName;
                filePathCsv.Text = file;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }

            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use
        }

        private void BrowseYourDB_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = FileToOpen.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = FileToOpen.FileName;
                filePath_Db.Text = file;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.

        }


        private bool GetIsSelfTestable(string targetString)
        {
            bool ret = false;
            string[] words = targetString.Split(',');
            //Parse "Slot5", "010000000" out


            //Extract IsSelfTestable

            return ret;
        }

        private void UpdateSqlSelfTestable(bool isSelfTestable)
        {

        }

        private void CompareDifference_Click(object sender, EventArgs e)
        {

        }


        private AlertMsg GetAlertDescription(string uid)
        {
            AlertMsg ret = new AlertMsg();
            var fileName = filePath_Db.Text;
            if (!File.Exists(fileName))
            {
                //CatLog.Warn("sqlite file missing, path: " + EngModeConstants.LocalDbPath);
                return ret;
            }

            using (SQLiteConnection sqliteConn = new SQLiteConnection("Data source=" + fileName))
            {
                sqliteConn.Open();
                using (var sqliteCommand = sqliteConn.CreateCommand())
                {
                    sqliteCommand.CommandText = "SELECT * FROM vmalertinfo WHERE \"UID\" = '" + uid + "'";
                    try
                    {
                        using (SQLiteDataReader sqlite_datareader = sqliteCommand.ExecuteReader())
                        {
                            sqlite_datareader.Read();
                            ret.Severity = Convert.ToInt32(sqlite_datareader["Severity"]);
                            ret.Category = sqlite_datareader["Category"].ToString();
                            ret.ErrorCode = sqlite_datareader["Error Code"].ToString();
                            ret.Description_EN = sqlite_datareader["EN Description"].ToString();
                            ret.Description_ZH = sqlite_datareader["ZH-TW Description"].ToString();
                            ret.IsSelfTestable = sqlite_datareader["IsSelfTestable"].ToString() == "1" ? true : false;
                        }
                    }
                    catch (Exception)
                    {
                        //CatLog.WarnException(sqliteCommand.CommandText, ex);
                    }



                }
            }





            return ret;
        }
    }
}
