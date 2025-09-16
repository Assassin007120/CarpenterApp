using System;
using System.Windows.Forms;

namespace CarpenterApp
{
    public partial class Form1 : Form
    {
        public Form1()
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
            var numberOfDrawers = txtNoOfDrawers.Text;
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
                    MessageBox.Show("Selected option: " + selectedText);
                    break;
                }
            }
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            GetSelectedRadioButtonFromPanel();
        }
    }
}
