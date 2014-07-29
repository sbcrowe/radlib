namespace BatchImageProcessor
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandDimensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractROIValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertToJpegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.convertToTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertToPngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertToBmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRadLibToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.FileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFileToolStripMenuItem,
            this.AddFolderToolStripMenuItem,
            this.toolStripSeparator3,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConvertToBmpToolStripMenuItem,
            this.ConvertToJpegToolStripMenuItem,
            this.ConvertToPngToolStripMenuItem,
            this.convertToTextToolStripMenuItem,
            this.toolStripSeparator2,
            this.expandDimensionsToolStripMenuItem,
            this.extractROIValuesToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // expandDimensionsToolStripMenuItem
            // 
            this.expandDimensionsToolStripMenuItem.Name = "expandDimensionsToolStripMenuItem";
            this.expandDimensionsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.expandDimensionsToolStripMenuItem.Text = "Expand Dimensions";
            // 
            // extractROIValuesToolStripMenuItem
            // 
            this.extractROIValuesToolStripMenuItem.Name = "extractROIValuesToolStripMenuItem";
            this.extractROIValuesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.extractROIValuesToolStripMenuItem.Text = "Extract ROI values";
            // 
            // ConvertToJpegToolStripMenuItem
            // 
            this.ConvertToJpegToolStripMenuItem.Name = "ConvertToJpegToolStripMenuItem";
            this.ConvertToJpegToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ConvertToJpegToolStripMenuItem.Text = "Convert to JPEG";
            this.ConvertToJpegToolStripMenuItem.Click += new System.EventHandler(this.ConvertToJpegToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
            // 
            // convertToTextToolStripMenuItem
            // 
            this.convertToTextToolStripMenuItem.Name = "convertToTextToolStripMenuItem";
            this.convertToTextToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.convertToTextToolStripMenuItem.Text = "Convert to text";
            // 
            // ConvertToPngToolStripMenuItem
            // 
            this.ConvertToPngToolStripMenuItem.Name = "ConvertToPngToolStripMenuItem";
            this.ConvertToPngToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ConvertToPngToolStripMenuItem.Text = "Convert to PNG";
            this.ConvertToPngToolStripMenuItem.Click += new System.EventHandler(this.ConvertToPngToolStripMenuItem_Click);
            // 
            // ConvertToBmpToolStripMenuItem
            // 
            this.ConvertToBmpToolStripMenuItem.Name = "ConvertToBmpToolStripMenuItem";
            this.ConvertToBmpToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ConvertToBmpToolStripMenuItem.Text = "Convert to BMP";
            this.ConvertToBmpToolStripMenuItem.Click += new System.EventHandler(this.ConvertToBmpToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutRadLibToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.homePageToolStripMenuItem.Text = "Home Page";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            // 
            // aboutRadLibToolStripMenuItem
            // 
            this.aboutRadLibToolStripMenuItem.Name = "aboutRadLibToolStripMenuItem";
            this.aboutRadLibToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutRadLibToolStripMenuItem.Text = "About RadLib";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 515);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileNameColumn,
            this.FileSizeColumn,
            this.FilePathColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(316, 3);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(465, 509);
            this.dataGridView.TabIndex = 0;
            // 
            // FileNameColumn
            // 
            this.FileNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FileNameColumn.HeaderText = "File name";
            this.FileNameColumn.Name = "FileNameColumn";
            this.FileNameColumn.ReadOnly = true;
            this.FileNameColumn.Width = 77;
            // 
            // FileSizeColumn
            // 
            this.FileSizeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FileSizeColumn.HeaderText = "File size";
            this.FileSizeColumn.Name = "FileSizeColumn";
            this.FileSizeColumn.ReadOnly = true;
            this.FileSizeColumn.Width = 69;
            // 
            // FilePathColumn
            // 
            this.FilePathColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FilePathColumn.HeaderText = "File path";
            this.FilePathColumn.Name = "FilePathColumn";
            this.FilePathColumn.ReadOnly = true;
            // 
            // AddFileToolStripMenuItem
            // 
            this.AddFileToolStripMenuItem.Name = "AddFileToolStripMenuItem";
            this.AddFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AddFileToolStripMenuItem.Text = "Add File";
            this.AddFileToolStripMenuItem.Click += new System.EventHandler(this.AddFileToolStripMenuItem_Click);
            // 
            // AddFolderToolStripMenuItem
            // 
            this.AddFolderToolStripMenuItem.Name = "AddFolderToolStripMenuItem";
            this.AddFolderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AddFolderToolStripMenuItem.Text = "Add Folder";
            this.AddFolderToolStripMenuItem.Click += new System.EventHandler(this.AddFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Batch Image Processor";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConvertToBmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConvertToJpegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConvertToPngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem expandDimensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractROIValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutRadLibToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePathColumn;
        private System.Windows.Forms.ToolStripMenuItem AddFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

