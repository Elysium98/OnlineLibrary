namespace OnlineLibrary
{
    partial class AddBook
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
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.textBookName = new System.Windows.Forms.TextBox();
            this.btn_insertBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(367, 71);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(149, 22);
            this.textAuthor.TabIndex = 0;
            // 
            // textBookName
            // 
            this.textBookName.Location = new System.Drawing.Point(367, 108);
            this.textBookName.Name = "textBookName";
            this.textBookName.Size = new System.Drawing.Size(149, 22);
            this.textBookName.TabIndex = 0;
            // 
            // btn_insertBook
            // 
            this.btn_insertBook.Location = new System.Drawing.Point(371, 164);
            this.btn_insertBook.Name = "btn_insertBook";
            this.btn_insertBook.Size = new System.Drawing.Size(114, 23);
            this.btn_insertBook.TabIndex = 1;
            this.btn_insertBook.Text = "Insert Book";
            this.btn_insertBook.UseVisualStyleBackColor = true;
            this.btn_insertBook.Click += new System.EventHandler(this.btn_insertBook_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_insertBook);
            this.Controls.Add(this.textBookName);
            this.Controls.Add(this.textAuthor);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.TextBox textBookName;
        private System.Windows.Forms.Button btn_insertBook;
    }
}