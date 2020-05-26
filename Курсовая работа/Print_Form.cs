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
                        if (Storage.car[i].store_number == store_number)
                        {
                            printBox2.Text += ($"Product name: {Storage.car[i].manufacturer} {Storage.car[i].product_name}\n");
                            printBox2.Text += ($"Quantity: {Storage.car[i].quantity}\n\n");
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
                if (Storage.car[i].consignment < 5)
                {
                    printBox2.Text += ($"Product name: {Storage.car[i].manufacturer} {Storage.car[i].product_name}\n");
                    printBox2.Text += ($"Quantity: {Storage.car[i].quantity}\n\n");
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
                printBox2.Text += ($"Product name: {Storage.car[i].manufacturer} {Storage.car[i].product_name}\n");
                printBox2.Text += ($"Unit price: {Storage.car[i].price}$\n\n");
            }
        }
        private void sortSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarShop[] sort = new CarShop[1];
            CarShop[] temp_array = new CarShop[Storage.size];
            for (int i = 0; i < Storage.size; i++)
            {
                temp_array[i] = Storage.car[i];
            }
            switch(sortSelection.Text)
            {
                case "Alphabetically":
                    for (int i = 0; i < Storage.car.Length - 1; i++)
                    {
                        for (int j = i + 1; j < Storage.car.Length; j++)
                        {
                            if (string.Compare(Storage.car[i].product_name, Storage.car[j].product_name) > 0)
                            {
                                sort[0] = Storage.car[i];
                                Storage.car[i] = Storage.car[j];
                                Storage.car[j] = sort[0];
                            }
                        }
                    }
                    SwapBack(temp_array);
                    break;
                case "By price (from cheap to exp.)":
                    for (int i = 0; i < Storage.car.Length - 1; i++)
                    {
                        for (int j = i + 1; j < Storage.car.Length; j++)
                        {
                            if (Storage.car[i].price > Storage.car[j].price)
                            {
                                sort[0] = Storage.car[i];
                                Storage.car[i] = Storage.car[j];
                                Storage.car[j] = sort[0];
                            }
                        }
                    }
                    SwapBack(temp_array);
                    break;
                case "By price (from exp. to cheap)":
                    for (int i = 0; i < Storage.car.Length - 1; i++)
                    {
                        for (int j = i + 1; j < Storage.car.Length; j++)
                        {
                            if (Storage.car[i].price < Storage.car[j].price)
                            {
                                sort[0] = Storage.car[i];
                                Storage.car[i] = Storage.car[j];
                                Storage.car[j] = sort[0];
                            }
                        }
                    }
                    SwapBack(temp_array);
                    break;
                case "By store number":
                    for (int i = 0; i < Storage.car.Length - 1; i++)
                    {
                        for (int j = i + 1; j < Storage.car.Length; j++)
                        {
                            if (Storage.car[i].store_number > Storage.car[j].store_number)
                            {
                                sort[0] = Storage.car[i];
                                Storage.car[i] = Storage.car[j];
                                Storage.car[j] = sort[0];
                            }
                        }
                    }
                    SwapBack(temp_array);
                    break;
            }
        }
        private void Output()
        {
            printBox.Clear();
            for (int i = 0; i < Storage.size; i++)
            {
                printBox.Text += ($"Product №{i + 1}\n");
                printBox.Text += ($"Product name: {Storage.car[i].product_name}\n");
                printBox.Text += ($"Manufacturer: {Storage.car[i].manufacturer}\n");
                printBox.Text += ($"Unit price: {Storage.car[i].price}$\n");
                printBox.Text += ($"Quantity: {Storage.car[i].quantity}\n");
                printBox.Text += ($"Store number: {Storage.car[i].store_number}\n");
                printBox.Text += ($"Minimum party: {Storage.car[i].consignment}\n\n");
            }
        }

        private void SwapBack(CarShop[] temp_array)
        {
            Output();
            for (int i = 0; i < Storage.size; i++)
            {
                Storage.car[i] = temp_array[i];
            }
            Array.Clear(temp_array, 0, Storage.size);
        }

        private void Print_Form_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            FAQ_Form faq = new FAQ_Form();
            faq.Show();
        }
    }
}
