using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dicom.Imaging;

namespace BatchImageProcessor
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// The class constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.ColumnStyles[0].Width = 0;
            RefreshAvailableButtons();
        }

        /// <summary>
        /// Process click of the add file item in the file menu.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void AddFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Multiselect = false,
                Filter = "DICOM Files (*.dcm;*.img)|*.dcm;*.img|All Files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.AddFile(openFileDialog.FileName);
            }
        }

        /// <summary>
        /// Process click of the add folder item in the file menu.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void AddFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFolderDialog = new FolderBrowserDialog
            {
                SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (openFolderDialog.ShowDialog().Equals(DialogResult.OK))
            {
                var filePaths = Directory.GetFiles(openFolderDialog.SelectedPath);
                foreach (var path in filePaths)
                {
                    if (path.EndsWith(".dcm") || path.EndsWith(".img")) this.AddFile(path);
                }
            }
        }

        /// <summary>
        /// Process click of exit item in file menu.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Process click of convert to BMP menu item in process menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertToBmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFolderDialog = new FolderBrowserDialog
            {
                SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (openFolderDialog.ShowDialog().Equals(DialogResult.OK))
            {
                var paths = (from DataGridViewRow dataGridViewRow in this.dataGridView.Rows
                             select dataGridViewRow.Cells["FilePathColumn"].Value as string).ToList();
                Parallel.ForEach(paths, path =>
                {
                    var newPath = Path.Combine(openFolderDialog.SelectedPath,
                        Path.GetFileNameWithoutExtension(path) + ".bmp");
                    var image = new DicomImage(path);
                    image.RenderImage().Save(newPath, ImageFormat.Bmp);
                    image = null;
                });
            }
        }

        /// <summary>
        /// Process click of convert to JPG menu item in process menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertToJpegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFolderDialog = new FolderBrowserDialog
            {
                SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (openFolderDialog.ShowDialog().Equals(DialogResult.OK))
            {
                var paths = (from DataGridViewRow dataGridViewRow in this.dataGridView.Rows
                             select dataGridViewRow.Cells["FilePathColumn"].Value as string).ToList();
                Parallel.ForEach(paths, path =>
                {
                    var newPath = Path.Combine(openFolderDialog.SelectedPath,
                        Path.GetFileNameWithoutExtension(path) + ".jpg");
                    var image = new DicomImage(path);
                    image.RenderImage().Save(newPath, ImageFormat.Jpeg);
                    image = null;
                });
            }
        }

        /// <summary>
        /// Process click of convert to PNG menu item in process menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertToPngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFolderDialog = new FolderBrowserDialog
            {
                SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (openFolderDialog.ShowDialog().Equals(DialogResult.OK))
            {
                var paths = (from DataGridViewRow dataGridViewRow in this.dataGridView.Rows
                             select dataGridViewRow.Cells["FilePathColumn"].Value as string).ToList();
                Parallel.ForEach(paths, path =>
                {
                    var newPath = Path.Combine(openFolderDialog.SelectedPath,
                        Path.GetFileNameWithoutExtension(path) + ".png");
                    var image = new DicomImage(path);
                    image.RenderImage().Save(newPath, ImageFormat.Png);
                    image = null;
                });
            }
        }

        /// <summary>
        /// Add file to the data grid.
        /// </summary>
        /// <param name="path">The path of the file to be added.</param>
        private void AddFile(string path)
        {
            var index = this.dataGridView.Rows.Add(new DataGridViewRow());
            this.dataGridView.Rows[index].Cells["FileNameColumn"].Value = Path.GetFileName(path);
            this.dataGridView.Rows[index].Cells["FileSizeColumn"].Value = BytesToString(new FileInfo(path).Length);
            this.dataGridView.Rows[index].Cells["FilePathColumn"].Value = path;
        }

        private void RefreshAvailableButtons()
        {
            if (this.dataGridView.Rows.Count >= 1)
            {
                this.ConvertToBmpToolStripMenuItem.Enabled = true;
                this.ConvertToJpegToolStripMenuItem.Enabled = true;
                this.ConvertToPngToolStripMenuItem.Enabled = true;
                this.convertToTextToolStripMenuItem.Enabled = false;
                this.expandDimensionsToolStripMenuItem.Enabled = false;
                this.extractROIValuesToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.ConvertToBmpToolStripMenuItem.Enabled = false;
                this.ConvertToJpegToolStripMenuItem.Enabled = false;
                this.ConvertToPngToolStripMenuItem.Enabled = false;
                this.convertToTextToolStripMenuItem.Enabled = false;
                this.expandDimensionsToolStripMenuItem.Enabled = false;
                this.extractROIValuesToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// Converts number of bytes into human-readable numbers.
        /// </summary>
        /// <param name="byteCount">The number of bytes.</param>
        /// <remarks>Method taken from StackOverflow user deepee1.</remarks>
        /// <returns>The human-readable number of bytes.</returns>
        static string BytesToString(long byteCount)
        {
            string[] suffix = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (byteCount == 0) return "0" + suffix[0];
            var bytes = Math.Abs(byteCount);
            var place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            var num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num) + suffix[place];
        }

    }
}
