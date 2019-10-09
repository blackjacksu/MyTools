namespace CsvToSqliteConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Write = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CompareDifference = new System.Windows.Forms.Button();
            this.filePathCsv = new System.Windows.Forms.TextBox();
            this.BrowseYourCsv = new System.Windows.Forms.Button();
            this.CsvFileNameLabel = new System.Windows.Forms.Label();
            this.DbFileNameLabel = new System.Windows.Forms.Label();
            this.filePath_Db = new System.Windows.Forms.TextBox();
            this.BrowsYourDB = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Write
            // 
            this.Write.Location = new System.Drawing.Point(51, 406);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(111, 65);
            this.Write.TabIndex = 0;
            this.Write.Text = "Convert";
            this.Write.UseVisualStyleBackColor = true;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CompareDifference
            // 
            this.CompareDifference.Location = new System.Drawing.Point(174, 406);
            this.CompareDifference.Name = "CompareDifference";
            this.CompareDifference.Size = new System.Drawing.Size(107, 65);
            this.CompareDifference.TabIndex = 2;
            this.CompareDifference.Text = "Compare";
            this.CompareDifference.UseVisualStyleBackColor = true;
            this.CompareDifference.Click += new System.EventHandler(this.CompareDifference_Click);
            // 
            // filePathCsv
            // 
            this.filePathCsv.Location = new System.Drawing.Point(51, 67);
            this.filePathCsv.Name = "filePathCsv";
            this.filePathCsv.Size = new System.Drawing.Size(352, 29);
            this.filePathCsv.TabIndex = 3;
            // 
            // BrowseYourCsv
            // 
            this.BrowseYourCsv.Location = new System.Drawing.Point(51, 102);
            this.BrowseYourCsv.Name = "BrowseYourCsv";
            this.BrowseYourCsv.Size = new System.Drawing.Size(119, 42);
            this.BrowseYourCsv.TabIndex = 4;
            this.BrowseYourCsv.Text = "Browse";
            this.BrowseYourCsv.UseVisualStyleBackColor = true;
            this.BrowseYourCsv.Click += new System.EventHandler(this.BrowseYourFile_Click);
            // 
            // CsvFileNameLabel
            // 
            this.CsvFileNameLabel.AutoSize = true;
            this.CsvFileNameLabel.Location = new System.Drawing.Point(59, 41);
            this.CsvFileNameLabel.Name = "CsvFileNameLabel";
            this.CsvFileNameLabel.Size = new System.Drawing.Size(90, 18);
            this.CsvFileNameLabel.TabIndex = 5;
            this.CsvFileNameLabel.Text = "Target CSV";
            // 
            // DbFileNameLabel
            // 
            this.DbFileNameLabel.AutoSize = true;
            this.DbFileNameLabel.Location = new System.Drawing.Point(59, 181);
            this.DbFileNameLabel.Name = "DbFileNameLabel";
            this.DbFileNameLabel.Size = new System.Drawing.Size(105, 18);
            this.DbFileNameLabel.TabIndex = 6;
            this.DbFileNameLabel.Text = "Target Sql Db";
            // 
            // filePath_Db
            // 
            this.filePath_Db.Location = new System.Drawing.Point(51, 219);
            this.filePath_Db.Name = "filePath_Db";
            this.filePath_Db.Size = new System.Drawing.Size(352, 29);
            this.filePath_Db.TabIndex = 7;
            // 
            // BrowsYourDB
            // 
            this.BrowsYourDB.Location = new System.Drawing.Point(51, 254);
            this.BrowsYourDB.Name = "BrowsYourDB";
            this.BrowsYourDB.Size = new System.Drawing.Size(111, 42);
            this.BrowsYourDB.TabIndex = 8;
            this.BrowsYourDB.Text = "Browse";
            this.BrowsYourDB.UseVisualStyleBackColor = true;
            this.BrowsYourDB.Click += new System.EventHandler(this.BrowseYourDB_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(659, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(543, 247);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "UID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Diffence Col";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Not Found In";
            this.Column3.Name = "Column3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 588);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BrowsYourDB);
            this.Controls.Add(this.filePath_Db);
            this.Controls.Add(this.DbFileNameLabel);
            this.Controls.Add(this.CsvFileNameLabel);
            this.Controls.Add(this.BrowseYourCsv);
            this.Controls.Add(this.filePathCsv);
            this.Controls.Add(this.CompareDifference);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Write);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CompareDifference;
        private System.Windows.Forms.TextBox filePathCsv;
        private System.Windows.Forms.Button BrowseYourCsv;
        private System.Windows.Forms.Label CsvFileNameLabel;
        private System.Windows.Forms.Label DbFileNameLabel;
        private System.Windows.Forms.TextBox filePath_Db;
        private System.Windows.Forms.Button BrowsYourDB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

