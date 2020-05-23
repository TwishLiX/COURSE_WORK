namespace Курсовая_работа
{
    partial class Print_Form
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
            this.printBox = new System.Windows.Forms.RichTextBox();
            this.printBox2 = new System.Windows.Forms.RichTextBox();
            this.sortSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.storeNumberBox = new System.Windows.Forms.TextBox();
            this.okStoreNumBtn = new System.Windows.Forms.Button();
            this.printMinBtn = new System.Windows.Forms.Button();
            this.printPricesBtn = new System.Windows.Forms.Button();
            this.backBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printBox
            // 
            this.printBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.printBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printBox.Location = new System.Drawing.Point(22, 23);
            this.printBox.Name = "printBox";
            this.printBox.ReadOnly = true;
            this.printBox.Size = new System.Drawing.Size(366, 337);
            this.printBox.TabIndex = 0;
            this.printBox.Text = "";
            // 
            // printBox2
            // 
            this.printBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.printBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printBox2.Location = new System.Drawing.Point(410, 23);
            this.printBox2.Name = "printBox2";
            this.printBox2.ReadOnly = true;
            this.printBox2.Size = new System.Drawing.Size(366, 337);
            this.printBox2.TabIndex = 2;
            this.printBox2.Text = "";
            // 
            // sortSelection
            // 
            this.sortSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortSelection.FormattingEnabled = true;
            this.sortSelection.Location = new System.Drawing.Point(135, 389);
            this.sortSelection.Name = "sortSelection";
            this.sortSelection.Size = new System.Drawing.Size(253, 32);
            this.sortSelection.TabIndex = 3;
            this.sortSelection.Text = "Sort...";
            this.sortSelection.SelectedIndexChanged += new System.EventHandler(this.sortSelection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(406, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Display all products that are in store №";
            // 
            // storeNumberBox
            // 
            this.storeNumberBox.Location = new System.Drawing.Point(709, 374);
            this.storeNumberBox.Name = "storeNumberBox";
            this.storeNumberBox.Size = new System.Drawing.Size(27, 20);
            this.storeNumberBox.TabIndex = 5;
            // 
            // okStoreNumBtn
            // 
            this.okStoreNumBtn.BackColor = System.Drawing.SystemColors.Control;
            this.okStoreNumBtn.Location = new System.Drawing.Point(744, 372);
            this.okStoreNumBtn.Name = "okStoreNumBtn";
            this.okStoreNumBtn.Size = new System.Drawing.Size(32, 23);
            this.okStoreNumBtn.TabIndex = 6;
            this.okStoreNumBtn.Text = "OK";
            this.okStoreNumBtn.UseVisualStyleBackColor = false;
            this.okStoreNumBtn.Click += new System.EventHandler(this.okStoreNumBtn_Click);
            // 
            // printMinBtn
            // 
            this.printMinBtn.BackColor = System.Drawing.SystemColors.Control;
            this.printMinBtn.Location = new System.Drawing.Point(410, 406);
            this.printMinBtn.Name = "printMinBtn";
            this.printMinBtn.Size = new System.Drawing.Size(174, 28);
            this.printMinBtn.TabIndex = 7;
            this.printMinBtn.Text = "Display minimum consignments";
            this.printMinBtn.UseVisualStyleBackColor = false;
            this.printMinBtn.Click += new System.EventHandler(this.printMinBtn_Click);
            // 
            // printPricesBtn
            // 
            this.printPricesBtn.BackColor = System.Drawing.SystemColors.Control;
            this.printPricesBtn.Location = new System.Drawing.Point(602, 406);
            this.printPricesBtn.Name = "printPricesBtn";
            this.printPricesBtn.Size = new System.Drawing.Size(174, 28);
            this.printPricesBtn.TabIndex = 8;
            this.printPricesBtn.Text = "Display the price list";
            this.printPricesBtn.UseVisualStyleBackColor = false;
            this.printPricesBtn.Click += new System.EventHandler(this.printPricesBtn_Click);
            // 
            // backBtn2
            // 
            this.backBtn2.BackColor = System.Drawing.SystemColors.Control;
            this.backBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backBtn2.Location = new System.Drawing.Point(22, 387);
            this.backBtn2.Name = "backBtn2";
            this.backBtn2.Size = new System.Drawing.Size(99, 37);
            this.backBtn2.TabIndex = 28;
            this.backBtn2.Text = "Back";
            this.backBtn2.UseVisualStyleBackColor = false;
            this.backBtn2.Click += new System.EventHandler(this.backBtn2_Click);
            // 
            // Print_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.backBtn2);
            this.Controls.Add(this.printPricesBtn);
            this.Controls.Add(this.printMinBtn);
            this.Controls.Add(this.okStoreNumBtn);
            this.Controls.Add(this.storeNumberBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortSelection);
            this.Controls.Add(this.printBox2);
            this.Controls.Add(this.printBox);
            this.MaximizeBox = false;
            this.Name = "Print_Form";
            this.Text = "Print_Form";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Print_Form_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox printBox;
        private System.Windows.Forms.RichTextBox printBox2;
        private System.Windows.Forms.ComboBox sortSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox storeNumberBox;
        private System.Windows.Forms.Button okStoreNumBtn;
        private System.Windows.Forms.Button printMinBtn;
        private System.Windows.Forms.Button printPricesBtn;
        private System.Windows.Forms.Button backBtn2;
    }
}