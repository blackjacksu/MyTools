using CsvToSqliteConverter.Model;
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
    public enum Difference
    {
        NoDifference = 0,
        DescriptionNotMatch,
        ServerityNotMatch,
        ErrorCodeNotMatch,
        UidNotInDb, 
        UidNotInSql,

    }

    public partial class Form1 : Form
    {
        int counter = 0;
        string line;

        OpenFileDialog FileToOpen = new OpenFileDialog();
        SaveFileDialog FileToSave = new SaveFileDialog();

        int SqlRowCount = 0;
        int CsvLineCount = 0;
        

        List<AlertMsg> AlertDescription_Csv = new List<AlertMsg>();

        List<VariedAlertUid> VariationList = new List<VariedAlertUid>();
 

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
                    CsvLineCount = GetCsvLineCount(file);
                    LineCountText.Text = CsvLineCount.ToString();

                    QueryFromCsv(file);
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
                    //string text = File.ReadAllText(file);
                    //size = text.Length;
                    SqlRowCount = GetSqlRowCount(file);
                    RowCountText.Text = SqlRowCount.ToString();
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
            return ret;
        }

        private void UpdateSqlSelfTestable(bool isSelfTestable)
        {

        }

        private AlertMsg ParseTxtToAlertMsg(string targetString)
        {
            AlertMsg ret = new AlertMsg();
            try
            {
                char[] charsToTrim = { '\"'};
                string[] words = targetString.Split(',');
                

                ret.Name = words[0];
                ret.Severity = Convert.ToInt16(words[1] == "Critical" ? 2 : words[1] == "Major" ? 1 : 0);
                ret.Category = words[2];
                ret.ErrorCode = words[3].Trim(charsToTrim);
                ret.Uid = words[4];
                ret.Description_EN = words[5].Trim(charsToTrim);
                ret.Description_ZH = words[6].Trim(charsToTrim);
                ret.IsSelfTestable = words[7] == "1" ? true : false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            
            return ret;
        }

        private void CompareDifference_Click(object sender, EventArgs e)
        {
            List<AlertMsg> AlertDifference = new List<AlertMsg>();
            AlertMsg csvAlert = new AlertMsg();
            VariedAlertUid alertId = new VariedAlertUid();

            foreach( AlertMsg alert in AlertDescription_Csv)
            {
                csvAlert = GetAlertDescription(alert.Uid);

                if (csvAlert == null)
                {
                    // Uid not in sql
                    VariationList.Add(new VariedAlertUid (alert.Category, alert.Uid, Difference.UidNotInSql));
                }
                else
                {
                    if (csvAlert.Description_EN != alert.Description_EN)// || csvAlert.Description_ZH != alert.Description_ZH)
                    {
                        // Description not match

                        VariationList.Add(new VariedAlertUid(alert.Category, alert.Uid, Difference.DescriptionNotMatch));
                    }
                    if (csvAlert.ErrorCode != alert.ErrorCode)
                    {
                        // Error Code not match

                        VariationList.Add(new VariedAlertUid(alert.Category, alert.Uid, Difference.ErrorCodeNotMatch));
                    }
                }

            }

            ShowDifference();
        }

        private string QueryFromCsv(string fileName)
        {
            string result = "";
            AlertMsg alert = new AlertMsg();
            System.IO.StreamReader csvFile = new System.IO.StreamReader(fileName);

            while ((line = csvFile.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                try
                {
                    alert = ParseTxtToAlertMsg(line);
                    if (!AlertDescription_Csv.Contains(alert))
                    {
                        AlertDescription_Csv.Add(alert);
                    }
                }
                catch (Exception ex)
                {

                }
            }

            csvFile.Close();

            return result;
        }

        private void ShowDifference()
        {
            //Show the difference data to grid and result list box according to UID
            var totalCount = VariationList.Count();
            var descriptionNotMatchCount = VariationList.Where(x => x.Diff == Difference.DescriptionNotMatch).Count();
            var errorcodeNotMatchCount = VariationList.Where(x => x.Diff == Difference.ErrorCodeNotMatch).Count();
            var serverityNotMatchCount = VariationList.Where(x => x.Diff == Difference.ServerityNotMatch).Count();
            var notFoundInSql = VariationList.Where(x => x.Diff == Difference.UidNotInSql).Count();
            var notFoundInDb = VariationList.Where(x => x.Diff == Difference.UidNotInDb).Count();

            foreach ( VariedAlertUid variation in VariationList)
            {
                int index = VariationList.IndexOf(variation);
                DifferenceDetailGrid.Rows.Add();
                DifferenceDetailGrid.Rows[index].HeaderCell.Value = index;
                DifferenceDetailGrid.Rows[index].Cells[0].Value = variation.Category;
                DifferenceDetailGrid.Rows[index].Cells[1].Value = variation.Uid;
                DifferenceDetailGrid.Rows[index].Cells[2].Value = variation.Diff;
            }

            Results.Items.Add(string.Format("Total: {0} ", totalCount));
            Results.Items.Add(string.Format("DescriptionNotMatch: {0}, ServerityNotMatch: {1}, ErrorCodeNotMatch: {2}, NotInSql: {3}, NotInDb: {4}", descriptionNotMatchCount, serverityNotMatchCount, errorcodeNotMatchCount, notFoundInSql, notFoundInDb));
            
        }

        private int GetCsvLineCount(string fileName)
        {
            int LineCount = 0;
            if (!File.Exists(fileName))
            {
                //CatLog.Warn("sqlite file missing, path: " + EngModeConstants.LocalDbPath);
                return -1;
            }


            System.IO.StreamReader csvFile =
                new System.IO.StreamReader(fileName);

            while ((line = csvFile.ReadLine()) != null)
            {
                System.Console.WriteLine(line);

                UpdateSqlSelfTestable(GetIsSelfTestable(line));

                LineCount++;
            }

            return LineCount;

        }

        private int GetSqlRowCount(string fileName)
        {
            int RowCount = 0;
            if (!File.Exists(fileName))
            {
                //CatLog.Warn("sqlite file missing, path: " + EngModeConstants.LocalDbPath);
                return -1;
            }

            using (SQLiteConnection sqliteConn = new SQLiteConnection("Data source=" + fileName))
            {
                sqliteConn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqliteConn);
                cmd.CommandText = "SELECT Count(*) FROM vmalertinfo";
                cmd.CommandType = CommandType.Text;

                RowCount = Convert.ToInt32(cmd.ExecuteScalar());
            }


            return RowCount;
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
                            ret.Uid = sqlite_datareader["UID"].ToString();
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

        private void ClearData_Click(object sender, EventArgs e)
        {
            SqlRowCount = 0;
            CsvLineCount = 0;

            LineCountText.Text = "";
            RowCountText.Text = "";

            DifferenceDetailGrid.Rows.Clear();
            DifferenceDetailGrid.Refresh();

            Results.Text = "";

            filePathCsv.Text = "";
            filePath_Db.Text = "";

            AlertDescription_Csv.Clear();

            VariationList.Clear();
        }
    }
}
