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
            this.ClearData = new System.Windows.Forms.Button();
            this.CompareDifference = new System.Windows.Forms.Button();
            this.filePathCsv = new System.Windows.Forms.TextBox();
            this.BrowseYourCsv = new System.Windows.Forms.Button();
            this.CsvFileNameLabel = new System.Windows.Forms.Label();
            this.DbFileNameLabel = new System.Windows.Forms.Label();
            this.filePath_Db = new System.Windows.Forms.TextBox();
            this.BrowsYourDB = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DifferenceDetailGrid = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LineCountText = new System.Windows.Forms.TextBox();
            this.RowCountText = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.ListBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DifferenceDetailGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Write
            // 
            this.Write.Location = new System.Drawing.Point(51, 423);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(111, 48);
            this.Write.TabIndex = 0;
            this.Write.Text = "Convert";
            this.Write.UseVisualStyleBackColor = true;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // ClearData
            // 
            this.ClearData.Location = new System.Drawing.Point(317, 423);
            this.ClearData.Name = "ClearData";
            this.ClearData.Size = new System.Drawing.Size(98, 48);
            this.ClearData.TabIndex = 1;
            this.ClearData.Text = "Clear&Reset";
            this.ClearData.UseVisualStyleBackColor = true;
            this.ClearData.Click += new System.EventHandler(this.ClearData_Click);
            // 
            // CompareDifference
            // 
            this.CompareDifference.Location = new System.Drawing.Point(189, 423);
            this.CompareDifference.Name = "CompareDifference";
            this.CompareDifference.Size = new System.Drawing.Size(107, 48);
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
            // DifferenceDetailGrid
            // 
            this.DifferenceDetailGrid.AllowUserToOrderColumns = true;
            this.DifferenceDetailGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DifferenceDetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DifferenceDetailGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Column1,
            this.Column2,
            this.Column3});
            this.DifferenceDetailGrid.Location = new System.Drawing.Point(677, 67);
            this.DifferenceDetailGrid.Name = "DifferenceDetailGrid";
            this.DifferenceDetailGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DifferenceDetailGrid.RowTemplate.Height = 31;
            this.DifferenceDetailGrid.Size = new System.Drawing.Size(704, 283);
            this.DifferenceDetailGrid.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lines:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lines:";
            // 
            // LineCountText
            // 
            this.LineCountText.Location = new System.Drawing.Point(502, 67);
            this.LineCountText.Name = "LineCountText";
            this.LineCountText.Size = new System.Drawing.Size(123, 29);
            this.LineCountText.TabIndex = 12;
            // 
            // RowCountText
            // 
            this.RowCountText.Location = new System.Drawing.Point(502, 211);
            this.RowCountText.Name = "RowCountText";
            this.RowCountText.Size = new System.Drawing.Size(131, 29);
            this.RowCountText.TabIndex = 13;
            // 
            // Results
            // 
            this.Results.FormattingEnabled = true;
            this.Results.ItemHeight = 18;
            this.Results.Location = new System.Drawing.Point(598, 374);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(783, 202);
            this.Results.TabIndex = 14;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Not Found In";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Diffence Col";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "UID";
            this.Column1.Name = "Column1";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 588);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.RowCountText);
            this.Controls.Add(this.LineCountText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DifferenceDetailGrid);
            this.Controls.Add(this.BrowsYourDB);
            this.Controls.Add(this.filePath_Db);
            this.Controls.Add(this.DbFileNameLabel);
            this.Controls.Add(this.CsvFileNameLabel);
            this.Controls.Add(this.BrowseYourCsv);
            this.Controls.Add(this.filePathCsv);
            this.Controls.Add(this.CompareDifference);
            this.Controls.Add(this.ClearData);
            this.Controls.Add(this.Write);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DifferenceDetailGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.Button ClearData;
        private System.Windows.Forms.Button CompareDifference;
        private System.Windows.Forms.TextBox filePathCsv;
        private System.Windows.Forms.Button BrowseYourCsv;
        private System.Windows.Forms.Label CsvFileNameLabel;
        private System.Windows.Forms.Label DbFileNameLabel;
        private System.Windows.Forms.TextBox filePath_Db;
        private System.Windows.Forms.Button BrowsYourDB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView DifferenceDetailGrid;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LineCountText;
        private System.Windows.Forms.TextBox RowCountText;
        private System.Windows.Forms.ListBox Results;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

