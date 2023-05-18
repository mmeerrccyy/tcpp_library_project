namespace library_app
{
    partial class AddArticle
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
            this.articleTitle = new System.Windows.Forms.TextBox();
            this.articleText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Article:";
            // 
            // articleTitle
            // 
            this.articleTitle.Location = new System.Drawing.Point(79, 16);
            this.articleTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.articleTitle.Name = "articleTitle";
            this.articleTitle.Size = new System.Drawing.Size(971, 22);
            this.articleTitle.TabIndex = 1;
            // 
            // articleText
            // 
            this.articleText.Location = new System.Drawing.Point(21, 50);
            this.articleText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.articleText.Name = "articleText";
            this.articleText.Size = new System.Drawing.Size(1028, 414);
            this.articleText.TabIndex = 2;
            this.articleText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 473);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1029, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create article";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.articleText);
            this.Controls.Add(this.articleTitle);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddArticle";
            this.Text = "Add Article";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddArticle_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox articleTitle;
        private System.Windows.Forms.RichTextBox articleText;
        private System.Windows.Forms.Button button1;
    }
}