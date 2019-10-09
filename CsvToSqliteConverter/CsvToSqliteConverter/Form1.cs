using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void BrowsYourDB_Click(object sender, EventArgs e)
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
    }
}
