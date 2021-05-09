
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAuthorYear = new System.Windows.Forms.MaskedTextBox();
            this.buttonUpdateAuthorData = new System.Windows.Forms.Button();
            this.buttonAddAuthorData = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.buttonAddBookData = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonEdit = new System.Windows.Forms.RadioButton();
            this.radioButtonReadOnly = new System.Windows.Forms.RadioButton();
            this.radioButtonAuthors = new System.Windows.Forms.RadioButton();
            this.radioButtonBooks = new System.Windows.Forms.RadioButton();
            this.comboBoxAddAuthor = new System.Windows.Forms.ComboBox();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.comboBoxBooks = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxYear = new System.Windows.Forms.MaskedTextBox();
            this.buttonUpdateBookData = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonClearBookInfo = new System.Windows.Forms.Button();
            this.radioAddNewBook = new System.Windows.Forms.RadioButton();
            this.radioUpdateBook = new System.Windows.Forms.RadioButton();
            this.radioDeleteBook = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.textBoxPrice);
            this.tabPage1.Controls.Add(this.textBoxPages);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxTitle);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.radioButtonAuthors);
            this.tabPage1.Controls.Add(this.radioButtonBooks);
            this.tabPage1.Controls.Add(this.comboBoxAddAuthor);
            this.tabPage1.Controls.Add(this.comboBoxAuthors);
            this.tabPage1.Controls.Add(this.comboBoxBooks);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books DB";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxAuthorYear);
            this.groupBox2.Controls.Add(this.buttonUpdateAuthorData);
            this.groupBox2.Controls.Add(this.buttonAddAuthorData);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxAuthorName);
            this.groupBox2.Location = new System.Drawing.Point(261, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 220);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Author info";
            // 
            // textBoxAuthorYear
            // 
            this.textBoxAuthorYear.Enabled = false;
            this.textBoxAuthorYear.Location = new System.Drawing.Point(309, 18);
            this.textBoxAuthorYear.Mask = "0000";
            this.textBoxAuthorYear.Name = "textBoxAuthorYear";
            this.textBoxAuthorYear.Size = new System.Drawing.Size(147, 20);
            this.textBoxAuthorYear.TabIndex = 7;
            this.textBoxAuthorYear.ValidatingType = typeof(int);
            // 
            // buttonUpdateAuthorData
            // 
            this.buttonUpdateAuthorData.Enabled = false;
            this.buttonUpdateAuthorData.Location = new System.Drawing.Point(242, 184);
            this.buttonUpdateAuthorData.Name = "buttonUpdateAuthorData";
            this.buttonUpdateAuthorData.Size = new System.Drawing.Size(216, 23);
            this.buttonUpdateAuthorData.TabIndex = 6;
            this.buttonUpdateAuthorData.Text = "Update author data";
            this.buttonUpdateAuthorData.UseVisualStyleBackColor = true;
            // 
            // buttonAddAuthorData
            // 
            this.buttonAddAuthorData.Enabled = false;
            this.buttonAddAuthorData.Location = new System.Drawing.Point(10, 184);
            this.buttonAddAuthorData.Name = "buttonAddAuthorData";
            this.buttonAddAuthorData.Size = new System.Drawing.Size(226, 23);
            this.buttonAddAuthorData.TabIndex = 6;
            this.buttonAddAuthorData.Text = "Add new author data";
            this.buttonAddAuthorData.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(4, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(227, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Birth year";
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Enabled = false;
            this.textBoxAuthorName.Location = new System.Drawing.Point(61, 16);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(147, 20);
            this.textBoxAuthorName.TabIndex = 5;
            // 
            // buttonAddBookData
            // 
            this.buttonAddBookData.Enabled = false;
            this.buttonAddBookData.Location = new System.Drawing.Point(18, 97);
            this.buttonAddBookData.Name = "buttonAddBookData";
            this.buttonAddBookData.Size = new System.Drawing.Size(302, 24);
            this.buttonAddBookData.TabIndex = 6;
            this.buttonAddBookData.Text = "Add new book data";
            this.buttonAddBookData.UseVisualStyleBackColor = true;
            this.buttonAddBookData.Click += new System.EventHandler(this.buttonSaveBookData_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Enabled = false;
            this.textBoxPrice.Location = new System.Drawing.Point(751, 40);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(147, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // textBoxPages
            // 
            this.textBoxPages.Enabled = false;
            this.textBoxPages.Location = new System.Drawing.Point(548, 40);
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(147, 20);
            this.textBoxPages.TabIndex = 5;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(485, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(270, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year";
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
            // comboBoxAddAuthor
            // 
            this.comboBoxAddAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddAuthor.Enabled = false;
            this.comboBoxAddAuthor.FormattingEnabled = true;
            this.comboBoxAddAuthor.Location = new System.Drawing.Point(548, 64);
            this.comboBoxAddAuthor.Name = "comboBoxAddAuthor";
            this.comboBoxAddAuthor.Size = new System.Drawing.Size(350, 21);
            this.comboBoxAddAuthor.TabIndex = 0;
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
            this.comboBoxAuthors.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthors_SelectedIndexChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDeleteBook);
            this.groupBox1.Controls.Add(this.radioUpdateBook);
            this.groupBox1.Controls.Add(this.radioAddNewBook);
            this.groupBox1.Controls.Add(this.textBoxYear);
            this.groupBox1.Controls.Add(this.buttonAddBookData);
            this.groupBox1.Controls.Add(this.buttonClearBookInfo);
            this.groupBox1.Controls.Add(this.buttonDeleteBook);
            this.groupBox1.Controls.Add(this.buttonUpdateBookData);
            this.groupBox1.Location = new System.Drawing.Point(261, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 154);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book info";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Enabled = false;
            this.textBoxYear.Location = new System.Drawing.Point(58, 37);
            this.textBoxYear.Mask = "0000";
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(147, 20);
            this.textBoxYear.TabIndex = 7;
            this.textBoxYear.ValidatingType = typeof(int);
            // 
            // buttonUpdateBookData
            // 
            this.buttonUpdateBookData.Enabled = false;
            this.buttonUpdateBookData.Location = new System.Drawing.Point(347, 97);
            this.buttonUpdateBookData.Name = "buttonUpdateBookData";
            this.buttonUpdateBookData.Size = new System.Drawing.Size(290, 24);
            this.buttonUpdateBookData.TabIndex = 6;
            this.buttonUpdateBookData.Text = "Update book data";
            this.buttonUpdateBookData.UseVisualStyleBackColor = true;
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
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Enabled = false;
            this.buttonDeleteBook.Location = new System.Drawing.Point(18, 124);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(302, 24);
            this.buttonDeleteBook.TabIndex = 6;
            this.buttonDeleteBook.Text = "Delete book";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            // 
            // buttonClearBookInfo
            // 
            this.buttonClearBookInfo.Enabled = false;
            this.buttonClearBookInfo.Location = new System.Drawing.Point(347, 124);
            this.buttonClearBookInfo.Name = "buttonClearBookInfo";
            this.buttonClearBookInfo.Size = new System.Drawing.Size(290, 24);
            this.buttonClearBookInfo.TabIndex = 6;
            this.buttonClearBookInfo.Text = "Clear book info";
            this.buttonClearBookInfo.UseVisualStyleBackColor = true;
            this.buttonClearBookInfo.Click += new System.EventHandler(this.buttonClearBookInfo_Click);
            // 
            // radioAddNewBook
            // 
            this.radioAddNewBook.AutoSize = true;
            this.radioAddNewBook.Location = new System.Drawing.Point(18, 69);
            this.radioAddNewBook.Name = "radioAddNewBook";
            this.radioAddNewBook.Size = new System.Drawing.Size(94, 17);
            this.radioAddNewBook.TabIndex = 8;
            this.radioAddNewBook.TabStop = true;
            this.radioAddNewBook.Text = "Add new book";
            this.radioAddNewBook.UseVisualStyleBackColor = true;
            // 
            // radioUpdateBook
            // 
            this.radioUpdateBook.AutoSize = true;
            this.radioUpdateBook.Location = new System.Drawing.Point(287, 73);
            this.radioUpdateBook.Name = "radioUpdateBook";
            this.radioUpdateBook.Size = new System.Drawing.Size(87, 17);
            this.radioUpdateBook.TabIndex = 8;
            this.radioUpdateBook.TabStop = true;
            this.radioUpdateBook.Text = "Update book";
            this.radioUpdateBook.UseVisualStyleBackColor = true;
            // 
            // radioDeleteBook
            // 
            this.radioDeleteBook.AutoSize = true;
            this.radioDeleteBook.Location = new System.Drawing.Point(552, 70);
            this.radioDeleteBook.Name = "radioDeleteBook";
            this.radioDeleteBook.Size = new System.Drawing.Size(83, 17);
            this.radioDeleteBook.TabIndex = 8;
            this.radioDeleteBook.TabStop = true;
            this.radioDeleteBook.Text = "Delete book";
            this.radioDeleteBook.UseVisualStyleBackColor = true;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button buttonAddBookData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxAddAuthor;
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddAuthorData;
        private System.Windows.Forms.MaskedTextBox textBoxAuthorYear;
        private System.Windows.Forms.MaskedTextBox textBoxYear;
        private System.Windows.Forms.Button buttonUpdateAuthorData;
        private System.Windows.Forms.Button buttonUpdateBookData;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonClearBookInfo;
        private System.Windows.Forms.RadioButton radioDeleteBook;
        private System.Windows.Forms.RadioButton radioUpdateBook;
        private System.Windows.Forms.RadioButton radioAddNewBook;
    }
}