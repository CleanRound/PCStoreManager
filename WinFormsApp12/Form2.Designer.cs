namespace ComputerStore
{
    partial class Form2
    {
        private System.Windows.Forms.ListBox listBoxComponents;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCharacteristics;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;

        private void InitializeComponent()
        {
            this.listBoxComponents = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCharacteristics = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxComponents
            // 
            this.listBoxComponents.FormattingEnabled = true;
            this.listBoxComponents.Location = new System.Drawing.Point(12, 12);
            this.listBoxComponents.Name = "listBoxComponents";
            this.listBoxComponents.Size = new System.Drawing.Size(200, 95);
            this.listBoxComponents.TabIndex = 0;
            this.listBoxComponents.SelectedIndexChanged += new System.EventHandler(this.listBoxComponents_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 130);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxCharacteristics
            // 
            this.textBoxCharacteristics.Location = new System.Drawing.Point(12, 160);
            this.textBoxCharacteristics.Name = "textBoxCharacteristics";
            this.textBoxCharacteristics.Size = new System.Drawing.Size(200, 20);
            this.textBoxCharacteristics.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(12, 190);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 20);
            this.textBoxDescription.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 220);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrice.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 260);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(137, 260);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxCharacteristics);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxComponents);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
