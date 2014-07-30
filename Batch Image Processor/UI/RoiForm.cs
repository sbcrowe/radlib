using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchImageProcessor.UI
{
    public partial class RoiForm : Form
    {

        /// <summary>
        /// The list of regions of interest names.
        /// </summary>
        private List<string> regionsOfInterestNames; 

        /// <summary>
        /// The list of regions of interest dimensions.
        /// </summary>
        private List<int[]> regionsOfInterestDimensions;

        /// <summary>
        /// The class constructor.
        /// </summary>
        public RoiForm(List<string> regionsOfInterestNames, List<int[]> regionsOfInterestDimensions)
        {
            InitializeComponent();
            this.regionsOfInterestNames = regionsOfInterestNames;
            this.regionsOfInterestDimensions = regionsOfInterestDimensions;
        }

        /// <summary>
        /// Process click of convert to PNG menu item in process menu.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event argurments.</param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                if (row.Cells["NameColumn"].Value == null) continue;
                if (row.Cells["X1Column"].Value == null) continue;
                if (row.Cells["Y1Column"].Value == null) continue;
                if (row.Cells["X2Column"].Value == null) continue;
                if (row.Cells["Y2Column"].Value == null) continue;
                regionsOfInterestNames.Add(row.Cells["NameColumn"].Value as string);
                regionsOfInterestDimensions.Add(new int[] { 
                    int.Parse(row.Cells["X1Column"].Value as string), 
                    int.Parse(row.Cells["Y1Column"].Value as string),
                    int.Parse(row.Cells["X2Column"].Value as string),
                    int.Parse(row.Cells["Y2Column"].Value as string)
            });
            }
            this.Close();
        }

        /// <summary>
        /// Process click of the cancel button.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.regionsOfInterestNames.Clear();
            this.regionsOfInterestDimensions.Clear();
            this.Close();
        }
    }
}
