namespace BatchImageProcessor.UI
{
    partial class RoiForm
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
            this.FormTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormTableLayout.SuspendLayout();
            this.ButtonFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTableLayout
            // 
            this.FormTableLayout.ColumnCount = 1;
            this.FormTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FormTableLayout.Controls.Add(this.ButtonFlowLayoutPanel, 0, 1);
            this.FormTableLayout.Controls.Add(this.DataGridView, 0, 0);
            this.FormTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTableLayout.Location = new System.Drawing.Point(0, 0);
            this.FormTableLayout.Name = "FormTableLayout";
            this.FormTableLayout.RowCount = 2;
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FormTableLayout.Size = new System.Drawing.Size(384, 261);
            this.FormTableLayout.TabIndex = 5;
            // 
            // ButtonFlowLayoutPanel
            // 
            this.ButtonFlowLayoutPanel.Controls.Add(this.CancelButton);
            this.ButtonFlowLayoutPanel.Controls.Add(this.OkButton);
            this.ButtonFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ButtonFlowLayoutPanel.Location = new System.Drawing.Point(3, 224);
            this.ButtonFlowLayoutPanel.Name = "ButtonFlowLayoutPanel";
            this.ButtonFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(2);
            this.ButtonFlowLayoutPanel.Size = new System.Drawing.Size(378, 34);
            this.ButtonFlowLayoutPanel.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(296, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(215, 5);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.X1Column,
            this.Y1Column,
            this.X2Column,
            this.Y2Column});
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(3, 3);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(378, 215);
            this.DataGridView.TabIndex = 1;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // X1Column
            // 
            this.X1Column.HeaderText = "X1";
            this.X1Column.Name = "X1Column";
            // 
            // Y1Column
            // 
            this.Y1Column.HeaderText = "Y1";
            this.Y1Column.Name = "Y1Column";
            // 
            // X2Column
            // 
            this.X2Column.HeaderText = "X2";
            this.X2Column.Name = "X2Column";
            // 
            // Y2Column
            // 
            this.Y2Column.HeaderText = "Y2";
            this.Y2Column.Name = "Y2Column";
            // 
            // RoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.FormTableLayout);
            this.Name = "RoiForm";
            this.Text = "Regions of Interest";
            this.FormTableLayout.ResumeLayout(false);
            this.ButtonFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FormTableLayout;
        private System.Windows.Forms.FlowLayoutPanel ButtonFlowLayoutPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y2Column;
    }
}