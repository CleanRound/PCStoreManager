using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ComputerStore
{
    public partial class Form1 : Form
    {
        private List<Component> componentList;
        private List<Component> saleList;
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
            componentList = new List<Component>();
            saleList = new List<Component>();
            form2 = new Form2(componentList, this);
        }

        public void UpdateComponentList()
        {
            comboBoxComponents.Items.Clear();
            foreach (var component in componentList)
            {
                comboBoxComponents.Items.Add(component.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateComponentList();
        }

        private void comboBoxComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxComponents.SelectedIndex >= 0)
            {
                Component selectedComponent = componentList[comboBoxComponents.SelectedIndex];
                textBoxPrice.Text = selectedComponent.Price.ToString();
            }
        }

        private void buttonAddToSale_Click(object sender, EventArgs e)
        {
            if (comboBoxComponents.SelectedIndex >= 0)
            {
                Component selectedComponent = componentList[comboBoxComponents.SelectedIndex];
                saleList.Add(selectedComponent);
                UpdateSaleList();
            }
        }

        private void UpdateSaleList()
        {
            listBoxSales.Items.Clear();
            decimal totalCost = 0;
            foreach (var component in saleList)
            {
                listBoxSales.Items.Add(component.Name);
                totalCost += component.Price;
            }
            labelTotalCost.Text = $"Total: {totalCost:C}";
        }

        private void buttonOpenForm2_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }
    }

    public class Component
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Component(string name, string characteristics, string description, decimal price)
        {
            Name = name;
            Characteristics = characteristics;
            Description = description;
            Price = price;
        }
    }
}
