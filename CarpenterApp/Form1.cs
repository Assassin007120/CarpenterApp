using System;
using System.Windows.Forms;

namespace CarpenterApp
{
    public partial class frmCarpenter : Form
    {
        public frmCarpenter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            var inputValue = txtLength.Text;
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            var width = txtWidth.Text;
        }

        private void txtNoOfDrawers_TextChanged(object sender, EventArgs e)
        {
            var numberOfDrawers = txtNumDrawers.Text;
        }

        private void pnWoodPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GetSelectedRadioButtonFromPanel()
        {
            foreach (Control control in pnWoodPanel.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    // This is the selected radio button
                    string selectedText = radioButton.Text;
                    break;
                }
            }
        }

        private double GetSurfaceAreaCost()
        {
            var result = CalculateSurfaceArea();

            if (result) // If true, add additional cost to the total
                return 300;

            return 0;
        }

        private bool CalculateSurfaceArea()
        {
            double surfaceArea = 0;

            if (double.TryParse(txtLength.Text, out double length) && double.TryParse(txtWidth.Text, out double width))
                surfaceArea = length * width;

            var extraCostCheck = SurfaceAreaExtraCostCheck(surfaceArea);

            if (extraCostCheck) // Return true to add additional cost to the total
                return true;

            return false;
        }

        private bool SurfaceAreaExtraCostCheck(double surfaceArea)
        {
            // Check if surface area exceeds 700,000 square millimeters (700,000 mm²)
            if (surfaceArea > 700000)
                return true;

            return false;
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            const double minCharge = 1200;
            double charge = 0;

            charge = GetSurfaceAreaCost();
            GetSelectedRadioButtonFromPanel();
        }
    }
}
