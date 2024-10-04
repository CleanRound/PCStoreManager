namespace ComputerStore
{
    partial class Form1
    {
        private System.Windows.Forms.ComboBox comboBoxComponents;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAddToSale;
        private System.Windows.Forms.ListBox listBoxSales;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Button buttonOpenForm2;


        private void InitializeComponent()
        {
            this.comboBoxComponents = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAddToSale = new System.Windows.Forms.Button();
            this.listBoxSales = new System.Windows.Forms.ListBox();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.buttonOpenForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxComponents
            // 
            this.comboBoxComponents.FormattingEnabled = true;
            this.comboBoxComponents.Location = new System.Drawing.Point(12, 12);
            this.comboBoxComponents.Name = "comboBoxComponents";
            this.comboBoxComponents.Size = new System.Drawing.Size(200, 21);
            this.comboBoxComponents.TabIndex = 0;
            this.comboBoxComponents.SelectedIndexChanged += new System.EventHandler(this.comboBoxComponents_SelectedIndexChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 50);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 1;
            // 
            // buttonAddToSale
            // 
            this.buttonAddToSale.Location = new System.Drawing.Point(12, 85);
            this.buttonAddToSale.Name = "buttonAddToSale";
            this.buttonAddToSale.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToSale.TabIndex = 2;
            this.buttonAddToSale.Text = "Add to Sale";
            this.buttonAddToSale.UseVisualStyleBackColor = true;
            this.buttonAddToSale.Click += new System.EventHandler(this.buttonAddToSale_Click);
            // 
            // listBoxSales
            // 
            this.listBoxSales.FormattingEnabled = true;
            this.listBoxSales.Location = new System.Drawing.Point(12, 125);
            this.listBoxSales.Name = "listBoxSales";
            this.listBoxSales.Size = new System.Drawing.Size(200, 95);
            this.listBoxSales.TabIndex = 3;
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(12, 230);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(61, 13);
            this.labelTotalCost.TabIndex = 4;
            this.labelTotalCost.Text = "Total: $0.00";
            // 
            // buttonOpenForm2
            // 
            this.buttonOpenForm2.Location = new System.Drawing.Point(130, 50);
            this.buttonOpenForm2.Name = "buttonOpenForm2";
            this.buttonOpenForm2.Size = new System.Drawing.Size(82, 23);
            this.buttonOpenForm2.TabIndex = 5;
            this.buttonOpenForm2.Text = "Edit Products";
            this.buttonOpenForm2.UseVisualStyleBackColor = true;
            this.buttonOpenForm2.Click += new System.EventHandler(this.buttonOpenForm2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonOpenForm2);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.listBoxSales);
            this.Controls.Add(this.buttonAddToSale);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxComponents);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
