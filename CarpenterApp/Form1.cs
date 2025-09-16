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
        private double GetSurfaceAreaCost()
        {
            try
            {
                var result = CalculateSurfaceArea();

                if (result) // If true, add additional cost to the total
                    return 300;

                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool CalculateSurfaceArea()
        {
            try
            {
                double surfaceArea = 0;

                if (double.TryParse(txtLength.Text, out double length) && double.TryParse(txtWidth.Text, out double width))
                    surfaceArea = length * width;

                var extraCostCheck = SurfaceAreaExtraCostCheck(surfaceArea);

                if (extraCostCheck) // Return true to add additional cost to the total
                    return true;

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool SurfaceAreaExtraCostCheck(double surfaceArea)
        {
            try
            {
                // Check if surface area exceeds 700,000 square millimeters (700,000 mm²)
                if (surfaceArea > 700000)
                    return true;

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private double GetDrawerCost()
        {
            try
            {
                if (int.TryParse(txtNumDrawers.Text, out int numberOfDrawers))
                    return numberOfDrawers * 180; // Each drawer costs R180

                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private double CalculateTypeOfWoodCost()
        {
            try
            {
                foreach (Control control in pnWoodPanel.Controls)
                {
                    if (control is RadioButton radioButton && radioButton.Checked)
                    {
                        // This is the selected radio button
                        string selectedText = radioButton.Text;

                        if (selectedText == "Cherry" || selectedText == "Mahogany")
                            return 900;

                        if (selectedText == "Oak")
                            return 750;
                    }
                }

                return 0; // Default return value if no radio button is selected
            }
            catch (Exception)
            {
                throw;
            }
        }

        private double CalculateTotalOrderCost()
        {
            try
            {
                const double minCharge = 1200;
                double totalCharge = minCharge + GetSurfaceAreaCost() + GetDrawerCost() + CalculateTypeOfWoodCost();

                return totalCharge;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            try
            {
                var total = CalculateTotalOrderCost();

                lblPrice.Text = "R " + total.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
