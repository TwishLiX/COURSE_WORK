using System;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class FAQ_Form : Form
    {
        public FAQ_Form()
        {
            InitializeComponent();
            CenterToScreen();
            faqBox.Text = "In this section you can get all the necessary information to use the program.\n\nTo get the information you are interested in, select one of the sections on the left.";
        }

        private void faqGeneralBtn_Click(object sender, EventArgs e)
        {
            faqTitleLabel.Text = "General information";
            faqBox.Text = "In this program you can create a database for car dealership products.\n\nAfter its creation, you can add new elements to it, edit, delete them, save the contents of the database to a file, read the previously created database from the file, and also display the contents of the entire database.";
        }

        private void faqAddBtn_Click(object sender, EventArgs e)
        {
            faqTitleLabel.Text = "Add item";
            faqBox.Text = "You can add an item to the database if you go along the path 'Main Menu -> Add data to database'.\n\nHaving followed this path, you will need to fill in the fields corresponding to the data for each database item (product name, manufacturer, unit price, quantity and minimum consignment) and then click on the 'Add' button. After this action, the database size will be increased by one, and item will be added to it.\n\nYou can add items to the database without leaving this section an unlimited number of times.";
        }

        private void faqEditBtn_Click(object sender, EventArgs e)
        {
            faqTitleLabel.Text = "Edit item";
            faqBox.Text = "You can edit an item from the database if you go along the path 'Main Menu -> Edit database'.\n\nHaving followed this path, you will need to enter the password that is defined in the program code. Default password: course_c#\n\nAfter entering the password, the database editing function will become available to you.\n\nYou can select the element you need for editing by searching by the name of the element, or by switching between all elements of the database.";
        }

        private void faqDelBtn_Click(object sender, EventArgs e)
        {
            faqTitleLabel.Text = "Delete item";
            faqBox.Text = "You can edit an item from the database if you go along the path 'Main Menu -> Edit database'.\n\nHaving followed this path, you will need to enter the password that is defined in the program code. Default password: course_c#\n\nAfter entering the password, you will have the option to remove the item from the database.\n\nYou can select the element you need to delete by searching by the name of the element, or by switching between all elements of the database.\n\nIn addition, you will have the option to delete all items from the database at the click of a button.";
        }

        private void faqDispBtn_Click(object sender, EventArgs e)
        {
            faqTitleLabel.Text = "Information output";
            faqBox.Text = "You can view database information if you go along the path 'Main Menu -> Display data'.\n\nIn this section of the program you will be shown detailed information about each database item with its index number.\n\nYou can sort the output of information about items alphabetically, by price (from cheap to expensive and from expensive to cheap) and by the store number in which this item is available.\n\nIn addition, in this section you can search for the necessary item by the store number in which this item is available, display a price list for all products, and also find all products with a minimum consignment of less than five.";
        }

        private void faqSaveBtn_Click(object sender, EventArgs e)
        {
            faqTitleLabel.Text = "Save item";
            faqBox.Text = "You can save the database in a binary file for interacting with the data the next time the program starts.\nTo do this, you need to click on the button 'Save data to file' in the main menu.\n\nWhen you click on this button, a dialog box will open in which you will have to name the file and select a location to save in the computer's memory.\n\nAfter clicking the 'OK' button, the file will be saved at the specified path and you will load the information from it into your database the next time the program starts.\n\nWhen you exit the program, you will be asked to save the current database to a file so as not to lose the current data.";
        }

        private void faqLoadBtn_Click(object sender, EventArgs e)
        {
            faqTitleLabel.Text = "Load item";
            faqBox.Text = "You can load the database from a file if you go along the path 'Main Menu -> Load data from file'.\n\nIf your database already contains data at the time of loading data from a file, the program will offer you two options: overwrite existing data and add data from a file to their place, or add data from a file to the end of the current database.\n\nAfter choosing one of these options, you will see an explorer in which you will need to select a file that contains the information you need to load into the database.\n\nAfter selecting a file, the data from it will be loaded into the database and your database will be updated.";
        }

        private void faqAboutBtn_Click(object sender, EventArgs e)
        {
            faqTitleLabel.Text = "Information about program";
            faqBox.Text = "This program was developed as a course project for the course 'Programming and Theory of Algorithms', performed by Khatsaiuk A.A.\n\nTo test the functionality of the program, use the file '20 elements.bin' that is located on the main page of the repository with the program.\n\nOdessa, 2020.";
        }
    }
}
