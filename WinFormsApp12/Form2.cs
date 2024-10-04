using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ComputerStore
{
    public partial class Form2 : Form
    {
        private List<Component> componentList;
        private Form1 form1;

        public Form2(List<Component> componentList, Form1 form1)
        {
            InitializeComponent();
            this.componentList = componentList;
            this.form1 = form1;
            UpdateComponentList();
        }

        private void UpdateComponentList()
        {
            listBoxComponents.Items.Clear();
            foreach (var component in componentList)
            {
                listBoxComponents.Items.Add(component.Name);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string characteristics = textBoxCharacteristics.Text;
            string description = textBoxDescription.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);

            Component newComponent = new Component(name, characteristics, description, price);
            componentList.Add(newComponent);
            UpdateComponentList();
            form1.UpdateComponentList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxComponents.SelectedIndex >= 0)
            {
                Component selectedComponent = componentList[listBoxComponents.SelectedIndex];
                selectedComponent.Name = textBoxName.Text;
                selectedComponent.Characteristics = textBoxCharacteristics.Text;
                selectedComponent.Description = textBoxDescription.Text;
                selectedComponent.Price = decimal.Parse(textBoxPrice.Text);

                UpdateComponentList();
                form1.UpdateComponentList();
            }
        }

        private void listBoxComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxComponents.SelectedIndex >= 0)
            {
                Component selectedComponent = componentList[listBoxComponents.SelectedIndex];
                textBoxName.Text = selectedComponent.Name;
                textBoxCharacteristics.Text = selectedComponent.Characteristics;
                textBoxDescription.Text = selectedComponent.Description;
                textBoxPrice.Text = selectedComponent.Price.ToString();
            }
        }
    }
}
