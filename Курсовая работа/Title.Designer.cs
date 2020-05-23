namespace Курсовая_работа
{
    partial class Title
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.faqBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.Location = new System.Drawing.Point(334, 25);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(134, 31);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.questionLabel.Location = new System.Drawing.Point(295, 56);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(211, 25);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "What do you like to do?";
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.SystemColors.Control;
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createBtn.Location = new System.Drawing.Point(292, 108);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(211, 32);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "Add data to database";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.SystemColors.Control;
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.printBtn.Location = new System.Drawing.Point(292, 204);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(211, 32);
            this.printBtn.TabIndex = 4;
            this.printBtn.Text = "Display data";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitBtn.Location = new System.Drawing.Point(292, 393);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(211, 32);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.SystemColors.Control;
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loadBtn.Location = new System.Drawing.Point(292, 299);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(211, 32);
            this.loadBtn.TabIndex = 6;
            this.loadBtn.Text = "Load data from file";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveBtn.Location = new System.Drawing.Point(292, 252);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(211, 32);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save data to file";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.SystemColors.Control;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editBtn.Location = new System.Drawing.Point(292, 156);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(211, 32);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Edit database";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // faqBtn
            // 
            this.faqBtn.BackColor = System.Drawing.SystemColors.Control;
            this.faqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.faqBtn.Location = new System.Drawing.Point(292, 346);
            this.faqBtn.Name = "faqBtn";
            this.faqBtn.Size = new System.Drawing.Size(211, 32);
            this.faqBtn.TabIndex = 7;
            this.faqBtn.Text = "Read FAQ";
            this.faqBtn.UseVisualStyleBackColor = false;
            this.faqBtn.Click += new System.EventHandler(this.faqBtn_Click);
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.faqBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.welcomeLabel);
            this.MaximizeBox = false;
            this.Name = "Title";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Title_FormClosing);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Title_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button faqBtn;
    }
}