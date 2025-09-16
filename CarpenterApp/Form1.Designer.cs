namespace CarpenterApp
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblNoOfDrawers = new System.Windows.Forms.Label();
            this.lblTypeOfWood = new System.Windows.Forms.Label();
            this.lblQuotePrice = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtNoOfDrawers = new System.Windows.Forms.TextBox();
            this.pnWoodPanel = new System.Windows.Forms.Panel();
            this.radPine = new System.Windows.Forms.RadioButton();
            this.radOak = new System.Windows.Forms.RadioButton();
            this.radMahogany = new System.Windows.Forms.RadioButton();
            this.radCherry = new System.Windows.Forms.RadioButton();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnWoodPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(99, 48);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(96, 13);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Desk Length (mm):";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(99, 84);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(91, 13);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Desk Width (mm):";
            // 
            // lblNoOfDrawers
            // 
            this.lblNoOfDrawers.AutoSize = true;
            this.lblNoOfDrawers.Location = new System.Drawing.Point(99, 119);
            this.lblNoOfDrawers.Name = "lblNoOfDrawers";
            this.lblNoOfDrawers.Size = new System.Drawing.Size(100, 13);
            this.lblNoOfDrawers.TabIndex = 2;
            this.lblNoOfDrawers.Text = "Number Of Drawers";
            // 
            // lblTypeOfWood
            // 
            this.lblTypeOfWood.AutoSize = true;
            this.lblTypeOfWood.Location = new System.Drawing.Point(99, 156);
            this.lblTypeOfWood.Name = "lblTypeOfWood";
            this.lblTypeOfWood.Size = new System.Drawing.Size(75, 13);
            this.lblTypeOfWood.TabIndex = 3;
            this.lblTypeOfWood.Text = "Type of Wood";
            // 
            // lblQuotePrice
            // 
            this.lblQuotePrice.AutoSize = true;
            this.lblQuotePrice.Location = new System.Drawing.Point(99, 285);
            this.lblQuotePrice.Name = "lblQuotePrice";
            this.lblQuotePrice.Size = new System.Drawing.Size(80, 13);
            this.lblQuotePrice.TabIndex = 4;
            this.lblQuotePrice.Text = "Quote Price Is: ";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(270, 45);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(159, 20);
            this.txtLength.TabIndex = 5;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(270, 81);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(159, 20);
            this.txtWidth.TabIndex = 6;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // txtNoOfDrawers
            // 
            this.txtNoOfDrawers.Location = new System.Drawing.Point(270, 116);
            this.txtNoOfDrawers.Name = "txtNoOfDrawers";
            this.txtNoOfDrawers.Size = new System.Drawing.Size(159, 20);
            this.txtNoOfDrawers.TabIndex = 7;
            this.txtNoOfDrawers.TextChanged += new System.EventHandler(this.txtNoOfDrawers_TextChanged);
            // 
            // pnWoodPanel
            // 
            this.pnWoodPanel.Controls.Add(this.radPine);
            this.pnWoodPanel.Controls.Add(this.radOak);
            this.pnWoodPanel.Controls.Add(this.radMahogany);
            this.pnWoodPanel.Controls.Add(this.radCherry);
            this.pnWoodPanel.Location = new System.Drawing.Point(270, 156);
            this.pnWoodPanel.Name = "pnWoodPanel";
            this.pnWoodPanel.Size = new System.Drawing.Size(159, 100);
            this.pnWoodPanel.TabIndex = 8;
            this.pnWoodPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnWoodPanel_Paint);
            // 
            // radPine
            // 
            this.radPine.AutoSize = true;
            this.radPine.Location = new System.Drawing.Point(12, 74);
            this.radPine.Name = "radPine";
            this.radPine.Size = new System.Drawing.Size(46, 17);
            this.radPine.TabIndex = 3;
            this.radPine.TabStop = true;
            this.radPine.Text = "Pine";
            this.radPine.UseVisualStyleBackColor = true;
            // 
            // radOak
            // 
            this.radOak.AutoSize = true;
            this.radOak.Location = new System.Drawing.Point(12, 53);
            this.radOak.Name = "radOak";
            this.radOak.Size = new System.Drawing.Size(45, 17);
            this.radOak.TabIndex = 2;
            this.radOak.TabStop = true;
            this.radOak.Text = "Oak";
            this.radOak.UseVisualStyleBackColor = true;
            // 
            // radMahogany
            // 
            this.radMahogany.AutoSize = true;
            this.radMahogany.Location = new System.Drawing.Point(12, 30);
            this.radMahogany.Name = "radMahogany";
            this.radMahogany.Size = new System.Drawing.Size(75, 17);
            this.radMahogany.TabIndex = 1;
            this.radMahogany.TabStop = true;
            this.radMahogany.Text = "Mahogany";
            this.radMahogany.UseVisualStyleBackColor = true;
            // 
            // radCherry
            // 
            this.radCherry.AutoSize = true;
            this.radCherry.Location = new System.Drawing.Point(12, 7);
            this.radCherry.Name = "radCherry";
            this.radCherry.Size = new System.Drawing.Size(55, 17);
            this.radCherry.TabIndex = 0;
            this.radCherry.TabStop = true;
            this.radCherry.Text = "Cherry";
            this.radCherry.UseVisualStyleBackColor = true;
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Location = new System.Drawing.Point(222, 330);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(75, 23);
            this.btnGetQuote.TabIndex = 9;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(267, 285);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(86, 13);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Quote goes here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 410);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.pnWoodPanel);
            this.Controls.Add(this.txtNoOfDrawers);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblQuotePrice);
            this.Controls.Add(this.lblTypeOfWood);
            this.Controls.Add(this.lblNoOfDrawers);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnWoodPanel.ResumeLayout(false);
            this.pnWoodPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblNoOfDrawers;
        private System.Windows.Forms.Label lblTypeOfWood;
        private System.Windows.Forms.Label lblQuotePrice;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtNoOfDrawers;
        private System.Windows.Forms.Panel pnWoodPanel;
        private System.Windows.Forms.RadioButton radOak;
        private System.Windows.Forms.RadioButton radMahogany;
        private System.Windows.Forms.RadioButton radCherry;
        private System.Windows.Forms.RadioButton radPine;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.Label lblPrice;
    }
}

