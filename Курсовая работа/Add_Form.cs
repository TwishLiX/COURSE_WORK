using System;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Add_Form : Form
    {
        public Add_Form()
        {
            InitializeComponent();
        }

        private void backBtn1_Click(object sender, EventArgs e)
        {
            Close();
            Title title = new Title();
            title.Show();
        }

        private void addDBBtn_Click(object sender, EventArgs e)
        {
            Storage storage = new Storage();
            string product_name, manufacturer;
            int price, quantity, store_number, min_consignment, count = 0;

            try
            {
                product_name = nameBox.Text;
                manufacturer = manufactureBox.Text;
                price = Convert.ToInt32(priceBox.Text);
                quantity = Convert.ToInt32(quantityBox.Text);
                store_number = Convert.ToInt32(storeNumberBox.Text);
                min_consignment = Convert.ToInt32(consignmentBox.Text);

                for (int i = 0; i < Storage.size; i++)
                {
                    if (product_name == Storage.car[i].product_name)
                        count++;
                }
                if (count != 0)
                {
                    MessageBox.Show("Product with that name is already exist in database.");
                }
                else
                {
                    if (product_name.Length >= 3 && manufacturer.Length >= 3 && price > 0 && quantity >= 0 && store_number > 0 && min_consignment > 0)
                    {
                        storage.ProductAdd(product_name, manufacturer, price, quantity, store_number, min_consignment);
                        MessageBox.Show("Data was successfully recorded.");
                        nameBox.Clear();
                        manufactureBox.Clear();
                        priceBox.Clear();
                        quantityBox.Clear();
                        storeNumberBox.Clear();
                        consignmentBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("One of the fields is too short.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Incorrectly entered format.");
            }
        }

        private void Add_Form_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            FAQ_Form faq = new FAQ_Form();
            faq.Show();
        }
    }
}
