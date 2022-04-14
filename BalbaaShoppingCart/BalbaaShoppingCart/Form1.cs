using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalbaaShoppingCart
{
    public partial class frmShoppingCart : Form
    {
        public frmShoppingCart()
        {
            InitializeComponent();
        }
        int itemsOrdered;
        const int numberOfProducts = 10;
        Product[] products = new Product[numberOfProducts];

        private void Form1_Load(object sender, EventArgs e)
        {
            products[0] = new Product("Computer", 1000);
            products[1] = new Product("Memory", 450);
            products[2] = new Product("Printer", 500);
            products[3] = new Product("Headphones", 150);
            products[4] = new Product("Monitor", 300);
            products[5] = new Product("Microphone", 100);
            products[6] = new Product("Power Bank", 350);
            products[7] = new Product("USB Cable", 20);
            products[8] = new Product("Mouse",50);
            products[9] = new Product("Keyboard", 50);

            for (int i = 0; i < numberOfProducts; i++)
            {
                dudProducts.Items.Add(products[i].Description);
            }
            dudProducts.SelectedIndex = 0;

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            products[dudProducts.SelectedIndex].NumberOrdered++;
            itemsOrdered++;
            lblItemsOrdered.Text = "Items Ordered: " + itemsOrdered.ToString();

        }

        private void tabShoppingCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabOrderForm.SelectedIndex)
            {
                case 1:
                    if (itemsOrdered == 0)
                    {
                        MessageBox.Show("No items were ordered!", "Invalid Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabOrderForm.SelectedIndex = 0;
                    }
                    else
                    {
                        double totalCost = 0;
                        lstProducts.Items.Clear();
                        for (int i = 0; i < numberOfProducts; i++)
                        {
                            if (products[i].NumberOrdered != 0)
                            {
                                lstProducts.Items.Add(products[i].NumberOrdered.ToString() + " " + products[i].Description);
                                totalCost += products[i].Cost * products[i].NumberOrdered;
                            }
                        }

                        lblTotalCost.Text = "Total Cost: $"+ string.Format("{0}",totalCost);
                    }
                    break;
                case 2:
                    if (txtOrderAdress.Text == "")
                    {
                        MessageBox.Show("No adress was mentioned!", "Invalid Adress", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabOrderForm.SelectedIndex = 0;
                        txtOrderAdress.Focus();
                    }
                    else
                    {
                        string adress = txtOrderAdress.Text;
                        txtMailingLabel.Text = adress;
                    }
                    break;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            txtOrderAdress.Text = "";
            itemsOrdered = 0;
            lblItemsOrdered.Text = "Items Ordered: 0";
            for (int i = 0; i < numberOfProducts; i++)
            {
                products[i].NumberOrdered = 0;
            }
            dudProducts.SelectedIndex = 0;
            lstProducts.Items.Clear();
            lblTotalCost.Text = "Total Cost";
            txtMailingLabel.Text = "";
        }
    }
}
