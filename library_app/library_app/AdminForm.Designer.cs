
namespace library_app
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonEdit = new System.Windows.Forms.RadioButton();
            this.radioButtonReadOnly = new System.Windows.Forms.RadioButton();
            this.radioButtonAuthors = new System.Windows.Forms.RadioButton();
            this.radioButtonBooks = new System.Windows.Forms.RadioButton();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.comboBoxBooks = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonSaveBookData = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUsername.Location = new System.Drawing.Point(104, 15);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(95, 24);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "username";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLogout.Location = new System.Drawing.Point(844, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(159, 37);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 453);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSaveBookData);
            this.tabPage1.Controls.Add(this.textBoxPrice);
            this.tabPage1.Controls.Add(this.textBoxPages);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxTitle);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.radioButtonAuthors);
            this.tabPage1.Controls.Add(this.radioButtonBooks);
            this.tabPage1.Controls.Add(this.comboBoxAuthors);
            this.tabPage1.Controls.Add(this.comboBoxBooks);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books DB";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxPages
            // 
            this.textBoxPages.Enabled = false;
            this.textBoxPages.Location = new System.Drawing.Point(548, 40);
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(147, 20);
            this.textBoxPages.TabIndex = 5;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Enabled = false;
            this.textBoxTitle.Location = new System.Drawing.Point(319, 40);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(147, 20);
            this.textBoxTitle.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(488, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(275, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonEdit);
            this.panel1.Controls.Add(this.radioButtonReadOnly);
            this.panel1.Location = new System.Drawing.Point(3, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 70);
            this.panel1.TabIndex = 3;
            // 
            // radioButtonEdit
            // 
            this.radioButtonEdit.AutoSize = true;
            this.radioButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonEdit.Location = new System.Drawing.Point(7, 33);
            this.radioButtonEdit.Name = "radioButtonEdit";
            this.radioButtonEdit.Size = new System.Drawing.Size(55, 24);
            this.radioButtonEdit.TabIndex = 2;
            this.radioButtonEdit.Text = "Edit";
            this.radioButtonEdit.UseVisualStyleBackColor = true;
            this.radioButtonEdit.CheckedChanged += new System.EventHandler(this.radioButtonEdit_CheckedChanged);
            // 
            // radioButtonReadOnly
            // 
            this.radioButtonReadOnly.AutoSize = true;
            this.radioButtonReadOnly.Checked = true;
            this.radioButtonReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonReadOnly.Location = new System.Drawing.Point(7, 3);
            this.radioButtonReadOnly.Name = "radioButtonReadOnly";
            this.radioButtonReadOnly.Size = new System.Drawing.Size(98, 24);
            this.radioButtonReadOnly.TabIndex = 2;
            this.radioButtonReadOnly.TabStop = true;
            this.radioButtonReadOnly.Text = "Read only";
            this.radioButtonReadOnly.UseVisualStyleBackColor = true;
            this.radioButtonReadOnly.CheckedChanged += new System.EventHandler(this.radioButtonReadOnly_CheckedChanged);
            // 
            // radioButtonAuthors
            // 
            this.radioButtonAuthors.AutoSize = true;
            this.radioButtonAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonAuthors.Location = new System.Drawing.Point(10, 64);
            this.radioButtonAuthors.Name = "radioButtonAuthors";
            this.radioButtonAuthors.Size = new System.Drawing.Size(83, 24);
            this.radioButtonAuthors.TabIndex = 2;
            this.radioButtonAuthors.TabStop = true;
            this.radioButtonAuthors.Text = "Authors";
            this.radioButtonAuthors.UseVisualStyleBackColor = true;
            this.radioButtonAuthors.CheckedChanged += new System.EventHandler(this.radioButtonAuthors_CheckedChanged);
            // 
            // radioButtonBooks
            // 
            this.radioButtonBooks.AutoSize = true;
            this.radioButtonBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonBooks.Location = new System.Drawing.Point(10, 7);
            this.radioButtonBooks.Name = "radioButtonBooks";
            this.radioButtonBooks.Size = new System.Drawing.Size(72, 24);
            this.radioButtonBooks.TabIndex = 2;
            this.radioButtonBooks.TabStop = true;
            this.radioButtonBooks.Text = "Books";
            this.radioButtonBooks.UseVisualStyleBackColor = true;
            this.radioButtonBooks.CheckedChanged += new System.EventHandler(this.radioButtonBooks_CheckedChanged);
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthors.Enabled = false;
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(10, 94);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(182, 21);
            this.comboBoxAuthors.TabIndex = 0;
            this.comboBoxAuthors.SelectedIndexChanged += new System.EventHandler(this.comboBoxBooks_SelectedIndexChanged);
            // 
            // comboBoxBooks
            // 
            this.comboBoxBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBooks.Enabled = false;
            this.comboBoxBooks.FormattingEnabled = true;
            this.comboBoxBooks.Location = new System.Drawing.Point(10, 37);
            this.comboBoxBooks.Name = "comboBoxBooks";
            this.comboBoxBooks.Size = new System.Drawing.Size(182, 21);
            this.comboBoxBooks.TabIndex = 0;
            this.comboBoxBooks.SelectedIndexChanged += new System.EventHandler(this.comboBoxBooks_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users DB";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(701, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Enabled = false;
            this.textBoxPrice.Location = new System.Drawing.Point(751, 40);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(147, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // buttonSaveBookData
            // 
            this.buttonSaveBookData.Enabled = false;
            this.buttonSaveBookData.Location = new System.Drawing.Point(279, 64);
            this.buttonSaveBookData.Name = "buttonSaveBookData";
            this.buttonSaveBookData.Size = new System.Drawing.Size(619, 24);
            this.buttonSaveBookData.TabIndex = 6;
            this.buttonSaveBookData.Text = "Save book data";
            this.buttonSaveBookData.UseVisualStyleBackColor = true;
            this.buttonSaveBookData.Click += new System.EventHandler(this.buttonSaveBookData_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 508);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radioButtonBooks;
        private System.Windows.Forms.ComboBox comboBoxBooks;
        private System.Windows.Forms.RadioButton radioButtonAuthors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonEdit;
        private System.Windows.Forms.RadioButton radioButtonReadOnly;
        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSaveBookData;
    }
}