using System;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Edit_Form : Form
    {
        Storage storage = new Storage();
        int current;
        public static bool confirmation;
        public Edit_Form()
        {
            InitializeComponent();
            if (confirmation == true)
                GetVisibleElements();
        }

        private void backBtn3_Click(object sender, EventArgs e)
        {
            Close();
            Title title = new Title();
            title.Show();
        }

        private void passOkBtn_Click(object sender, EventArgs e)
        {
            current = 0;
            string password = passBox.Text;
            if (password == Storage.password)
            {
                confirmation = true;
                MessageBox.Show("Correct! Now you can edit the database.");
                GetVisibleElements();
            }
            else
            {
                MessageBox.Show("Incorrect! Try again.");
            }
        }
        private void previousElementBtn_Click(object sender, EventArgs e)
        {
            if (current == 0)
                current = Storage.size - 1;
            else
                current--;
            TextBoxAssignment(current);
        }

        private void nextElementBtn_Click(object sender, EventArgs e)
        {
            current++;
            if (current == Storage.size)
                current = 0;
            TextBoxAssignment(current);
        }

        private void searchNameBtn_Click(object sender, EventArgs e)
        {
            string search = searchNameBox.Text;
            int count = 0;
            for (int i = 0; i < Storage.size; i++)
            {
                if (search == Storage.car[i].product_name)
                {
                    current = i;
                    TextBoxAssignment(current);
                    count++;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Product doesn't exist.");
            }
        }

        private void deleteAllBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you are want to clear the database?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                storage.ClearAll();
                MessageBox.Show("The database was cleared.");
                backBtn3_Click(sender, e);
            }
        }

        private void overwriteBtn_Click(object sender, EventArgs e)
        {
            string product_name, manufacturer;
            int price, quantity, store_number, min_consignment;
            try
            {
                product_name = editNameBox.Text;
                manufacturer = editManufactureBox.Text;
                price = Convert.ToInt32(editPriceBox.Text);
                quantity = Convert.ToInt32(editQuantityBox.Text);
                store_number = Convert.ToInt32(editStoreNumberBox.Text);
                min_consignment = Convert.ToInt32(editConsignmentBox.Text);
                if (product_name.Length >= 3 && manufacturer.Length >= 3 && price > 0 && quantity >= 0 && store_number > 0 && min_consignment > 0)
                {
                    storage.ProductEdit(product_name, manufacturer, price, quantity, store_number, min_consignment, current);
                    MessageBox.Show("Data was successfully recorded.");
                }
                else
                {
                    MessageBox.Show("One of the fields is too short.");
                }
            }
            catch
            {
                MessageBox.Show("Incorrectly entered format.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            storage.ProductDelete(current);
            if (current == Storage.size)
                current--;
            MessageBox.Show("Element was successfully deleted.");
            TextBoxAssignment(current);
        }

        private void TextBoxAssignment(int current)
        {
            elementNumLabel.Text = $"Element №{current + 1}";
            editNameBox.Text = Storage.car[current].product_name;
            editManufactureBox.Text = Storage.car[current].manufacturer;
            editPriceBox.Text = Convert.ToString(Storage.car[current].price);
            editQuantityBox.Text = Convert.ToString(Storage.car[current].quantity);
            editStoreNumberBox.Text = Convert.ToString(Storage.car[current].store_number);
            editConsignmentBox.Text = Convert.ToString(Storage.car[current].consignment);
        }

        private void GetVisibleElements()
        {
            passRequestLabel.Visible = false;
            passBox.Visible = false;
            passOkBtn.Visible = false;
            editLabel.Visible = true;
            searchNameBox.Visible = true;
            searchNameBtn.Visible = true;
            deleteAllBtn.Visible = true;
            elementNumLabel.Visible = true;
            editNameLabel.Visible = true;
            editManufactureLabel.Visible = true;
            editPriceLabel.Visible = true;
            editQuantityLabel.Visible = true;
            editStoreNumberLabel.Visible = true;
            editConsignmentLabel.Visible = true;
            editNameBox.Visible = true;
            editManufactureBox.Visible = true;
            editPriceBox.Visible = true;
            editQuantityBox.Visible = true;
            editStoreNumberBox.Visible = true;
            editConsignmentBox.Visible = true;
            overwriteBtn.Visible = true;
            deleteBtn.Visible = true;
            previousElementBtn.Visible = true;
            nextElementBtn.Visible = true;
            TextBoxAssignment(current);
        }

        private void Edit_Form_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            FAQ_Form faq = new FAQ_Form();
            faq.Show();
        }
    }
}
