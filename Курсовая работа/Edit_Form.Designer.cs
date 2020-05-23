namespace Курсовая_работа
{
    partial class Edit_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backBtn3 = new System.Windows.Forms.Button();
            this.passRequestLabel = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.passOkBtn = new System.Windows.Forms.Button();
            this.editConsignmentLabel = new System.Windows.Forms.Label();
            this.editStoreNumberLabel = new System.Windows.Forms.Label();
            this.editQuantityLabel = new System.Windows.Forms.Label();
            this.editPriceLabel = new System.Windows.Forms.Label();
            this.editManufactureLabel = new System.Windows.Forms.Label();
            this.editNameLabel = new System.Windows.Forms.Label();
            this.editConsignmentBox = new System.Windows.Forms.TextBox();
            this.editStoreNumberBox = new System.Windows.Forms.TextBox();
            this.editQuantityBox = new System.Windows.Forms.TextBox();
            this.editPriceBox = new System.Windows.Forms.TextBox();
            this.editManufactureBox = new System.Windows.Forms.TextBox();
            this.editNameBox = new System.Windows.Forms.TextBox();
            this.editLabel = new System.Windows.Forms.Label();
            this.overwriteBtn = new System.Windows.Forms.Button();
            this.searchNameBtn = new System.Windows.Forms.Button();
            this.searchNameBox = new System.Windows.Forms.TextBox();
            this.deleteAllBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.previousElementBtn = new System.Windows.Forms.Button();
            this.nextElementBtn = new System.Windows.Forms.Button();
            this.elementNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn3
            // 
            this.backBtn3.BackColor = System.Drawing.SystemColors.Control;
            this.backBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backBtn3.Location = new System.Drawing.Point(12, 14);
            this.backBtn3.Name = "backBtn3";
            this.backBtn3.Size = new System.Drawing.Size(99, 37);
            this.backBtn3.TabIndex = 29;
            this.backBtn3.Text = "Back";
            this.backBtn3.UseVisualStyleBackColor = false;
            this.backBtn3.Click += new System.EventHandler(this.backBtn3_Click);
            // 
            // passRequestLabel
            // 
            this.passRequestLabel.AutoSize = true;
            this.passRequestLabel.BackColor = System.Drawing.Color.Transparent;
            this.passRequestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.passRequestLabel.Location = new System.Drawing.Point(176, 163);
            this.passRequestLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passRequestLabel.Name = "passRequestLabel";
            this.passRequestLabel.Size = new System.Drawing.Size(454, 26);
            this.passRequestLabel.TabIndex = 30;
            this.passRequestLabel.Text = "To edit the database please input a password:";
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passBox.Location = new System.Drawing.Point(269, 206);
            this.passBox.Margin = new System.Windows.Forms.Padding(2);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '•';
            this.passBox.Size = new System.Drawing.Size(181, 26);
            this.passBox.TabIndex = 31;
            // 
            // passOkBtn
            // 
            this.passOkBtn.BackColor = System.Drawing.SystemColors.Control;
            this.passOkBtn.Location = new System.Drawing.Point(465, 205);
            this.passOkBtn.Name = "passOkBtn";
            this.passOkBtn.Size = new System.Drawing.Size(47, 26);
            this.passOkBtn.TabIndex = 32;
            this.passOkBtn.Text = "OK";
            this.passOkBtn.UseVisualStyleBackColor = false;
            this.passOkBtn.Click += new System.EventHandler(this.passOkBtn_Click);
            // 
            // editConsignmentLabel
            // 
            this.editConsignmentLabel.AutoSize = true;
            this.editConsignmentLabel.BackColor = System.Drawing.Color.Transparent;
            this.editConsignmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editConsignmentLabel.Location = new System.Drawing.Point(179, 345);
            this.editConsignmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editConsignmentLabel.Name = "editConsignmentLabel";
            this.editConsignmentLabel.Size = new System.Drawing.Size(174, 20);
            this.editConsignmentLabel.TabIndex = 44;
            this.editConsignmentLabel.Text = "Minimum Consignment:";
            this.editConsignmentLabel.Visible = false;
            // 
            // editStoreNumberLabel
            // 
            this.editStoreNumberLabel.AutoSize = true;
            this.editStoreNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.editStoreNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editStoreNumberLabel.Location = new System.Drawing.Point(241, 306);
            this.editStoreNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editStoreNumberLabel.Name = "editStoreNumberLabel";
            this.editStoreNumberLabel.Size = new System.Drawing.Size(112, 20);
            this.editStoreNumberLabel.TabIndex = 43;
            this.editStoreNumberLabel.Text = "Store Number:";
            this.editStoreNumberLabel.Visible = false;
            // 
            // editQuantityLabel
            // 
            this.editQuantityLabel.AutoSize = true;
            this.editQuantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.editQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editQuantityLabel.Location = new System.Drawing.Point(281, 267);
            this.editQuantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editQuantityLabel.Name = "editQuantityLabel";
            this.editQuantityLabel.Size = new System.Drawing.Size(72, 20);
            this.editQuantityLabel.TabIndex = 42;
            this.editQuantityLabel.Text = "Quantity:";
            this.editQuantityLabel.Visible = false;
            // 
            // editPriceLabel
            // 
            this.editPriceLabel.AutoSize = true;
            this.editPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.editPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editPriceLabel.Location = new System.Drawing.Point(272, 227);
            this.editPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editPriceLabel.Name = "editPriceLabel";
            this.editPriceLabel.Size = new System.Drawing.Size(81, 20);
            this.editPriceLabel.TabIndex = 41;
            this.editPriceLabel.Text = "Unit Price:";
            this.editPriceLabel.Visible = false;
            // 
            // editManufactureLabel
            // 
            this.editManufactureLabel.AutoSize = true;
            this.editManufactureLabel.BackColor = System.Drawing.Color.Transparent;
            this.editManufactureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editManufactureLabel.Location = new System.Drawing.Point(245, 187);
            this.editManufactureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editManufactureLabel.Name = "editManufactureLabel";
            this.editManufactureLabel.Size = new System.Drawing.Size(108, 20);
            this.editManufactureLabel.TabIndex = 40;
            this.editManufactureLabel.Text = "Manufacturer:";
            this.editManufactureLabel.Visible = false;
            // 
            // editNameLabel
            // 
            this.editNameLabel.AutoSize = true;
            this.editNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.editNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editNameLabel.Location = new System.Drawing.Point(239, 148);
            this.editNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editNameLabel.Name = "editNameLabel";
            this.editNameLabel.Size = new System.Drawing.Size(114, 20);
            this.editNameLabel.TabIndex = 39;
            this.editNameLabel.Text = "Product Name:";
            this.editNameLabel.Visible = false;
            // 
            // editConsignmentBox
            // 
            this.editConsignmentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editConsignmentBox.Location = new System.Drawing.Point(361, 342);
            this.editConsignmentBox.Margin = new System.Windows.Forms.Padding(2);
            this.editConsignmentBox.Name = "editConsignmentBox";
            this.editConsignmentBox.Size = new System.Drawing.Size(181, 26);
            this.editConsignmentBox.TabIndex = 38;
            this.editConsignmentBox.Visible = false;
            // 
            // editStoreNumberBox
            // 
            this.editStoreNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editStoreNumberBox.Location = new System.Drawing.Point(361, 303);
            this.editStoreNumberBox.Margin = new System.Windows.Forms.Padding(2);
            this.editStoreNumberBox.Name = "editStoreNumberBox";
            this.editStoreNumberBox.Size = new System.Drawing.Size(181, 26);
            this.editStoreNumberBox.TabIndex = 37;
            this.editStoreNumberBox.Visible = false;
            // 
            // editQuantityBox
            // 
            this.editQuantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editQuantityBox.Location = new System.Drawing.Point(361, 264);
            this.editQuantityBox.Margin = new System.Windows.Forms.Padding(2);
            this.editQuantityBox.Name = "editQuantityBox";
            this.editQuantityBox.Size = new System.Drawing.Size(181, 26);
            this.editQuantityBox.TabIndex = 36;
            this.editQuantityBox.Visible = false;
            // 
            // editPriceBox
            // 
            this.editPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editPriceBox.Location = new System.Drawing.Point(361, 224);
            this.editPriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.editPriceBox.Name = "editPriceBox";
            this.editPriceBox.Size = new System.Drawing.Size(181, 26);
            this.editPriceBox.TabIndex = 35;
            this.editPriceBox.Visible = false;
            // 
            // editManufactureBox
            // 
            this.editManufactureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editManufactureBox.Location = new System.Drawing.Point(361, 184);
            this.editManufactureBox.Margin = new System.Windows.Forms.Padding(2);
            this.editManufactureBox.Name = "editManufactureBox";
            this.editManufactureBox.Size = new System.Drawing.Size(181, 26);
            this.editManufactureBox.TabIndex = 34;
            this.editManufactureBox.Visible = false;
            // 
            // editNameBox
            // 
            this.editNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editNameBox.Location = new System.Drawing.Point(361, 145);
            this.editNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.editNameBox.Name = "editNameBox";
            this.editNameBox.Size = new System.Drawing.Size(181, 26);
            this.editNameBox.TabIndex = 33;
            this.editNameBox.Visible = false;
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.editLabel.Location = new System.Drawing.Point(150, 15);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(503, 24);
            this.editLabel.TabIndex = 45;
            this.editLabel.Text = "To edit or delete an element, input its name or find it below:";
            this.editLabel.Visible = false;
            // 
            // overwriteBtn
            // 
            this.overwriteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.overwriteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.overwriteBtn.Location = new System.Drawing.Point(280, 391);
            this.overwriteBtn.Name = "overwriteBtn";
            this.overwriteBtn.Size = new System.Drawing.Size(99, 37);
            this.overwriteBtn.TabIndex = 46;
            this.overwriteBtn.Text = "Overwrite";
            this.overwriteBtn.UseVisualStyleBackColor = false;
            this.overwriteBtn.Visible = false;
            this.overwriteBtn.Click += new System.EventHandler(this.overwriteBtn_Click);
            // 
            // searchNameBtn
            // 
            this.searchNameBtn.BackColor = System.Drawing.SystemColors.Control;
            this.searchNameBtn.Location = new System.Drawing.Point(442, 53);
            this.searchNameBtn.Name = "searchNameBtn";
            this.searchNameBtn.Size = new System.Drawing.Size(47, 26);
            this.searchNameBtn.TabIndex = 47;
            this.searchNameBtn.Text = "OK";
            this.searchNameBtn.UseVisualStyleBackColor = false;
            this.searchNameBtn.Visible = false;
            this.searchNameBtn.Click += new System.EventHandler(this.searchNameBtn_Click);
            // 
            // searchNameBox
            // 
            this.searchNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchNameBox.Location = new System.Drawing.Point(246, 53);
            this.searchNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchNameBox.Name = "searchNameBox";
            this.searchNameBox.Size = new System.Drawing.Size(181, 26);
            this.searchNameBox.TabIndex = 48;
            this.searchNameBox.Visible = false;
            // 
            // deleteAllBtn
            // 
            this.deleteAllBtn.BackColor = System.Drawing.SystemColors.Control;
            this.deleteAllBtn.Location = new System.Drawing.Point(501, 54);
            this.deleteAllBtn.Name = "deleteAllBtn";
            this.deleteAllBtn.Size = new System.Drawing.Size(71, 26);
            this.deleteAllBtn.TabIndex = 49;
            this.deleteAllBtn.Text = "Delete All";
            this.deleteAllBtn.UseVisualStyleBackColor = false;
            this.deleteAllBtn.Visible = false;
            this.deleteAllBtn.Click += new System.EventHandler(this.deleteAllBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteBtn.Location = new System.Drawing.Point(385, 391);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(99, 37);
            this.deleteBtn.TabIndex = 50;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // previousElementBtn
            // 
            this.previousElementBtn.BackColor = System.Drawing.SystemColors.Control;
            this.previousElementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.previousElementBtn.Location = new System.Drawing.Point(77, 238);
            this.previousElementBtn.Name = "previousElementBtn";
            this.previousElementBtn.Size = new System.Drawing.Size(99, 37);
            this.previousElementBtn.TabIndex = 52;
            this.previousElementBtn.Text = "Previous";
            this.previousElementBtn.UseVisualStyleBackColor = false;
            this.previousElementBtn.Visible = false;
            this.previousElementBtn.Click += new System.EventHandler(this.previousElementBtn_Click);
            // 
            // nextElementBtn
            // 
            this.nextElementBtn.BackColor = System.Drawing.SystemColors.Control;
            this.nextElementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nextElementBtn.Location = new System.Drawing.Point(620, 238);
            this.nextElementBtn.Name = "nextElementBtn";
            this.nextElementBtn.Size = new System.Drawing.Size(99, 37);
            this.nextElementBtn.TabIndex = 53;
            this.nextElementBtn.Text = "Next";
            this.nextElementBtn.UseVisualStyleBackColor = false;
            this.nextElementBtn.Visible = false;
            this.nextElementBtn.Click += new System.EventHandler(this.nextElementBtn_Click);
            // 
            // elementNumLabel
            // 
            this.elementNumLabel.AutoSize = true;
            this.elementNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.elementNumLabel.Location = new System.Drawing.Point(335, 99);
            this.elementNumLabel.Name = "elementNumLabel";
            this.elementNumLabel.Size = new System.Drawing.Size(115, 24);
            this.elementNumLabel.TabIndex = 54;
            this.elementNumLabel.Text = "Element №1";
            this.elementNumLabel.Visible = false;
            // 
            // Edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.elementNumLabel);
            this.Controls.Add(this.nextElementBtn);
            this.Controls.Add(this.previousElementBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.deleteAllBtn);
            this.Controls.Add(this.searchNameBox);
            this.Controls.Add(this.searchNameBtn);
            this.Controls.Add(this.overwriteBtn);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.editConsignmentLabel);
            this.Controls.Add(this.editStoreNumberLabel);
            this.Controls.Add(this.editQuantityLabel);
            this.Controls.Add(this.editPriceLabel);
            this.Controls.Add(this.editManufactureLabel);
            this.Controls.Add(this.editNameLabel);
            this.Controls.Add(this.editConsignmentBox);
            this.Controls.Add(this.editStoreNumberBox);
            this.Controls.Add(this.editQuantityBox);
            this.Controls.Add(this.editPriceBox);
            this.Controls.Add(this.editManufactureBox);
            this.Controls.Add(this.editNameBox);
            this.Controls.Add(this.passOkBtn);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.passRequestLabel);
            this.Controls.Add(this.backBtn3);
            this.MaximizeBox = false;
            this.Name = "Edit_Form";
            this.Text = "Edit_Form";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Edit_Form_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn3;
        private System.Windows.Forms.Label passRequestLabel;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button passOkBtn;
        private System.Windows.Forms.Label editConsignmentLabel;
        private System.Windows.Forms.Label editStoreNumberLabel;
        private System.Windows.Forms.Label editQuantityLabel;
        private System.Windows.Forms.Label editPriceLabel;
        private System.Windows.Forms.Label editManufactureLabel;
        private System.Windows.Forms.Label editNameLabel;
        private System.Windows.Forms.TextBox editConsignmentBox;
        private System.Windows.Forms.TextBox editStoreNumberBox;
        private System.Windows.Forms.TextBox editQuantityBox;
        private System.Windows.Forms.TextBox editPriceBox;
        private System.Windows.Forms.TextBox editManufactureBox;
        private System.Windows.Forms.TextBox editNameBox;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.Button overwriteBtn;
        private System.Windows.Forms.Button searchNameBtn;
        private System.Windows.Forms.TextBox searchNameBox;
        private System.Windows.Forms.Button deleteAllBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button previousElementBtn;
        private System.Windows.Forms.Button nextElementBtn;
        private System.Windows.Forms.Label elementNumLabel;
    }
}