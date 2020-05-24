using System;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Print_Form : Form
    {
        public Print_Form()
        {
            InitializeComponent();
            sortSelection.Items.AddRange(new string[] { "Alphabetically", "By price (from cheap to exp.)", "By price (from exp. to cheap)", "By store number" });
            Output();
        }

        private void backBtn2_Click(object sender, EventArgs e)
        {
            Close();
            Title title = new Title();
            title.Show();
        }
        private void okStoreNumBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                int store_number = Convert.ToInt32(storeNumberBox.Text);
                if (store_number <= 0)
                {
                    MessageBox.Show("Incorrect store number.");
                }
                else
                {
                    if (printBox2.Text != String.Empty)
                    {
                        printBox2.Clear();
                    }
                    for (int i = 0; i < Storage.size; i++)
                    {
                        if (Storage.store_number[i] == store_number)
                        {
                            printBox2.Text += ($"Product name: {Storage.manufacturer[i]} {Storage.product_name[i]}\n");
                            printBox2.Text += ($"Quantity: {Storage.quantity[i]}\n\n");
                            count++;
                        }
                    }
                    if (count == 0)
                        MessageBox.Show("Products in that store were not found.");
                }
            }
            catch
            {
                MessageBox.Show("Incorrectly entered format.");
            }
        }
        private void printMinBtn_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (printBox2.Text != String.Empty)
            {
                printBox2.Clear();
            }
            for (int i = 0; i < Storage.size; i++)
            {
                if (Storage.consignment[i] < 5)
                {
                    printBox2.Text += ($"Product name: {Storage.manufacturer[i]} {Storage.product_name[i]}\n");
                    printBox2.Text += ($"Quantity: {Storage.quantity[i]}\n\n");
                    count++;
                }
            }
            if (count == 0)
                MessageBox.Show("There are no any products with consignment less than 5.");
        }
        private void printPricesBtn_Click(object sender, EventArgs e)
        {
            if (printBox2.Text != String.Empty)
            {
                printBox2.Clear();
            }
            for (int i = 0; i < Storage.size; i++)
            {
                printBox2.Text += ($"Product name: {Storage.manufacturer[i]} {Storage.product_name[i]}\n");
                printBox2.Text += ($"Unit price: {Storage.price[i]}$\n\n");
            }
        }
        private void sortSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(sortSelection.Text)
            {
                case "Alphabetically":
                    printBox.Clear();
                    Array.Sort(Storage.product_name);
                    Output();
                    break;
                case "By price (from cheap to exp.)":
                    printBox.Clear();
                    Array.Sort(Storage.price);
                    Output();
                    break;
                case "By price (from exp. to cheap)":
                    printBox.Clear();
                    Array.Sort(Storage.price);
                    Array.Reverse(Storage.price);
                    Output();
                    break;
                case "By store number":
                    printBox.Clear();
                    Array.Sort(Storage.store_number);
                    Output();
                    break;
            }
        }
        private void Output()
        {
            
            for (int i = 0; i < Storage.size; i++)
            {
                printBox.Text += ($"Product №{i + 1}\n");
                printBox.Text += ($"Product name: {Storage.product_name[i]}\n");
                printBox.Text += ($"Manufacturer: {Storage.manufacturer[i]}\n");
                printBox.Text += ($"Unit price: {Storage.price[i]}$\n");
                printBox.Text += ($"Quantity: {Storage.quantity[i]}\n");
                printBox.Text += ($"Store number: {Storage.store_number[i]}\n");
                printBox.Text += ($"Minimum party: {Storage.consignment[i]}\n\n");
            }
        }

        private void Print_Form_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            FAQ_Form faq = new FAQ_Form();
            faq.Show();
        }
    }
}
