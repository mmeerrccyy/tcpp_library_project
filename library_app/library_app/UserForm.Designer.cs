
namespace library_app
{
    partial class UserForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAddBookData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textArticle = new System.Windows.Forms.RichTextBox();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonUpdateArticle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUsername.Location = new System.Drawing.Point(139, 18);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(120, 29);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "username";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLogout.Location = new System.Drawing.Point(1125, 15);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(212, 46);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(17, 53);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1320, 695);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.buttonAddBookData);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1312, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Articles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 11);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(936, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonAddBookData
            // 
            this.buttonAddBookData.Location = new System.Drawing.Point(969, 11);
            this.buttonAddBookData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddBookData.Name = "buttonAddBookData";
            this.buttonAddBookData.Size = new System.Drawing.Size(324, 30);
            this.buttonAddBookData.TabIndex = 6;
            this.buttonAddBookData.Text = "Add new article";
            this.buttonAddBookData.UseVisualStyleBackColor = true;
            this.buttonAddBookData.Click += new System.EventHandler(this.buttonSaveBookData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Controls.Add(this.textArticle);
            this.groupBox1.Controls.Add(this.buttonDeleteBook);
            this.groupBox1.Controls.Add(this.buttonUpdateArticle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1293, 619);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Article";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Enabled = false;
            this.textBoxTitle.Location = new System.Drawing.Point(77, 20);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(1207, 22);
            this.textBoxTitle.TabIndex = 5;
            // 
            // textArticle
            // 
            this.textArticle.Location = new System.Drawing.Point(24, 69);
            this.textArticle.Margin = new System.Windows.Forms.Padding(4);
            this.textArticle.Name = "textArticle";
            this.textArticle.Size = new System.Drawing.Size(1260, 505);
            this.textArticle.TabIndex = 7;
            this.textArticle.Text = "";
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Enabled = false;
            this.buttonDeleteBook.Location = new System.Drawing.Point(24, 582);
            this.buttonDeleteBook.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(617, 30);
            this.buttonDeleteBook.TabIndex = 6;
            this.buttonDeleteBook.Text = "Delete article";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonUpdateArticle
            // 
            this.buttonUpdateArticle.Enabled = false;
            this.buttonUpdateArticle.Location = new System.Drawing.Point(649, 582);
            this.buttonUpdateArticle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateArticle.Name = "buttonUpdateArticle";
            this.buttonUpdateArticle.Size = new System.Drawing.Size(673, 30);
            this.buttonUpdateArticle.TabIndex = 6;
            this.buttonUpdateArticle.Text = "Update article";
            this.buttonUpdateArticle.UseVisualStyleBackColor = true;
            this.buttonUpdateArticle.Click += new System.EventHandler(this.buttonUpdateBookData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1312, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Articles overviw";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 597);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1288, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Read Full Article";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 47);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(1287, 542);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(172, 9);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(1128, 24);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(8, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose Article:";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 752);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.Text = "Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddBookData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUpdateArticle;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox textArticle;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}