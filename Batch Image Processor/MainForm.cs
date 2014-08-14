/**
 * RadLib - Batch Image Processor
 * Copyright (c) 2014 Scott Crowe
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License along
 * with this program; if not, write to the Free Software Foundation, Inc.,
 * 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
 *
 * Contact Details:
 * Scott Crowe (mailto:sb.crowe@gmail.com)
 */

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchImageProcessor.UI;
using Dicom;
using Dicom.Imaging;

namespace BatchImageProcessor
{
    public partial class MainForm : Form
    {

        /// <summary>
        /// The class constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            tableLayoutPanel1.ColumnStyles[0].Width = 0;
            this.RefreshAvailableButtons();
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
            this.RefreshAvailableButtons();
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
                var subFolders = Directory.GetDirectories(openFolderDialog.SelectedPath);
                foreach (var subFolder in subFolders)
                {
                    var subFolderFilePaths = Directory.GetFiles(subFolder);
                    foreach (var subFolderFilePath in subFolderFilePaths)
                        if (subFolderFilePath.EndsWith(".dcm") || subFolderFilePath.EndsWith(".img"))
                            this.AddFile(subFolderFilePath);
                }
            }
            this.RefreshAvailableButtons();
        }

        /// <summary>
        /// Process click of the clear files item in the file menu.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ClearFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView.Rows.Clear();
            this.RefreshAvailableButtons();
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
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
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
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
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
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
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
        /// Process click of extract ROI values menu item in process menu.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ExtractRoiValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get region of interest data from user
            var regionsOfInterestNames = new List<string>();
            var regionsOfInterestDimensions = new List<int[]>();
            var roiForm = new RoiForm(regionsOfInterestNames, regionsOfInterestDimensions);
            roiForm.ShowDialog();
            if (regionsOfInterestNames.Count <= 0) return;
            // get export directory from user
            var saveFileDialog = new SaveFileDialog
            {
                DefaultExt = ".csv",
                AddExtension = true
            };
            if (!saveFileDialog.ShowDialog().Equals(DialogResult.OK)) return;
            // iterate through user specified input files
            var paths = (from DataGridViewRow dataGridViewRow in this.dataGridView.Rows
                select dataGridViewRow.Cells["FilePathColumn"].Value as string).ToList();
            var result = new ConcurrentBag<string>();
            Parallel.ForEach(paths, path =>
            {
                
                var file = DicomFile.Open(path);
                var rescaleSlope = 1.0;
                if (file.Dataset.Contains(DicomTag.RescaleSlope))
                    rescaleSlope = file.Dataset.Get<double>(DicomTag.RescaleSlope, 1.0);
                var rescaleIntercept = 0.0;
                if (file.Dataset.Contains(DicomTag.RescaleIntercept))
                    rescaleIntercept = file.Dataset.Get<double>(DicomTag.RescaleIntercept, 0.0);
                file = null;
                var image = new DicomImage(path);
                byte[] imageBytes = image.PixelData.GetFrame(0).Data;
                var bytesPerValue = image.PixelData.BitsAllocated / 8;
                for (var roiIndex = 0; roiIndex < regionsOfInterestNames.Count; roiIndex++)
                {
                    var population = new List<double>();
                    var startIndexX = regionsOfInterestDimensions[roiIndex][0];
                    var finalIndexX = regionsOfInterestDimensions[roiIndex][2];
                    var startIndexY = regionsOfInterestDimensions[roiIndex][1];
                    var finalIndexY = regionsOfInterestDimensions[roiIndex][3];
                    for (var currIndexX = startIndexX; currIndexX < finalIndexX; currIndexX++)
                    {
                        for (var currIndexY = startIndexY; currIndexY < finalIndexY; currIndexY++)
                        {
                            var byteArrayIndex = bytesPerValue * (currIndexY * image.Width + currIndexX);
                            switch (image.PixelData.BitsAllocated)
                            {
                                case 8:
                                    population.Add(image.PixelData.GetFrame(0).Data[byteArrayIndex] * rescaleSlope +
                                                   rescaleIntercept);
                                    break;
                                case 16:
                                    if (image.PixelData.PixelRepresentation == PixelRepresentation.Signed)
                                        population.Add(
                                            BitConverter.ToInt16(image.PixelData.GetFrame(0).Data, byteArrayIndex) *
                                            rescaleSlope * (-1) + rescaleIntercept * (-1));
                                    else
                                        population.Add(
                                            BitConverter.ToUInt16(image.PixelData.GetFrame(0).Data, byteArrayIndex) *
                                            rescaleSlope * (-1) + rescaleIntercept * (-1));
                                    break;
                                case 32:
                                    if (image.PixelData.PixelRepresentation == PixelRepresentation.Signed)
                                        population.Add(
                                            BitConverter.ToInt32(image.PixelData.GetFrame(0).Data, byteArrayIndex) *
                                            rescaleSlope * (-1) + rescaleIntercept * (-1));
                                    else
                                        population.Add(
                                            BitConverter.ToUInt64(image.PixelData.GetFrame(0).Data, byteArrayIndex) *
                                            rescaleSlope * (-1) + rescaleIntercept * (-1));
                                    break;
                            }
                        }
                    }
                    population.Sort();
                    // calculate mean value and standard deviation
                    var mean = population.Average();
                    var stdev = Math.Sqrt(population.Average(v => Math.Pow(v - mean, 2)));
                    result.Add(Path.GetFileNameWithoutExtension(path) + "," + regionsOfInterestNames[roiIndex] + "," + mean + "," + stdev);
                }
                image = null;
                
            });
            File.WriteAllLines(saveFileDialog.FileName, result);
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

        /// <summary>
        /// Refresh the available menu items, depending on the presence of added files.
        /// </summary>
        private void RefreshAvailableButtons()
        {
            if (this.dataGridView.Rows.Count >= 1)
            {
                this.ClearFilesToolStripMenuItem.Enabled = true;
                this.ConvertToBmpToolStripMenuItem.Enabled = true;
                this.ConvertToJpegToolStripMenuItem.Enabled = true;
                this.ConvertToPngToolStripMenuItem.Enabled = true;
                this.convertToTextToolStripMenuItem.Enabled = false;
                this.ExpandDimensionsToolStripMenuItem.Enabled = false;
                this.ExtractRoiValuesToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.ClearFilesToolStripMenuItem.Enabled = false;
                this.ConvertToBmpToolStripMenuItem.Enabled = false;
                this.ConvertToJpegToolStripMenuItem.Enabled = false;
                this.ConvertToPngToolStripMenuItem.Enabled = false;
                this.convertToTextToolStripMenuItem.Enabled = false;
                this.ExpandDimensionsToolStripMenuItem.Enabled = false;
                this.ExtractRoiValuesToolStripMenuItem.Enabled = false;
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
