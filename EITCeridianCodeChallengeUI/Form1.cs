using EITCeridianCodeChallengeJMTE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EITCeridianCodeChallengeUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize form
            txOrdering.Focus();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            // Add new item to be ordered
            lbNames.Items.Add(txName.Text);
            txName.Clear();
            txName.Focus();
        }

        private void btReorder_Click(object sender, EventArgs e)
        {
            // Create component
            Reorder reorder = new Reorder();

            // Extract values from listbox to be ordered
            List<string> names = new List<string>();
            foreach (var item in lbNames.Items)
            { names.Add(item.ToString()); }

            // Reorder items by paramaters given
            string[] results = reorder.ReorderNames(names.ToArray(), txOrdering.Text.Split(','));

            // Validate results
            if (!results.Any(r => r.Contains("ERROR:")))
            {
                // Show successful results
                foreach (string item in results)
                { lbResults.Items.Add(item); }
            }
            else
            {
                // Show error message if so
                MessageBox.Show(results.FirstOrDefault(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            // Clear and prepare next execution
            txOrdering.Clear();
            txName.Clear();
            lbNames.Items.Clear();
            lbResults.Items.Clear();

            txOrdering.Focus();
        }

    }
}
