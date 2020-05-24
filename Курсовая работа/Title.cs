using System;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Title : Form
    {
        Files files = new Files();
        public Title()
        {
            InitializeComponent();
            if (Storage.first_start == true)
            {
                Storage storage = new Storage();
                storage.BeginAssingment();
            }
            if (Storage.size == 0)
            {
                editBtn.Enabled = false;
                printBtn.Enabled = false;
                saveBtn.Enabled = false;
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Add_Form add = new Add_Form();
            add.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Edit_Form edit = new Edit_Form();
            edit.Show();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Print_Form print = new Print_Form();
            print.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            files.Write();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            bool is_overwrite;
            if (Storage.size > 0)
            {
                var result = MessageBox.Show("Do you want to overwrite the data? if you click 'no', then data from the file will be written to the end of the current database", "Choose an action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    is_overwrite = true;
                    files.Read(is_overwrite);
                }
                if (result == DialogResult.No)
                {
                    is_overwrite = false;
                    files.Read(is_overwrite);
                }
            }
            else if (Storage.size == 0)
            {
                is_overwrite = true;
                files.Read(is_overwrite);
                Hide();
                Title title = new Title();
                title.Show();
            }
        }

        private void faqBtn_Click(object sender, EventArgs e)
        {
            FAQ_Form faq = new FAQ_Form();
            faq.Show();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Title_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Storage.size > 0)
            {
                var result = MessageBox.Show("Do you want to save data in file before exit?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    files.Write();
                    Environment.Exit(0);
                }
                if (result == DialogResult.No)
                {
                    Environment.Exit(0);
                }
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            if (Storage.size == 0)
            {
                Environment.Exit(0);
            }
        }

        private void Title_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            FAQ_Form faq = new FAQ_Form();
            faq.Show();
        }
    }
}
