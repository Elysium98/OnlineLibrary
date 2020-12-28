namespace OnlineLibrary
{
    partial class ReturnBook
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
            this.returnBooksGridView = new System.Windows.Forms.DataGridView();
            this.btn_returnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.returnBooksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // returnBooksGridView
            // 
            this.returnBooksGridView.AllowUserToAddRows = false;
            this.returnBooksGridView.AllowUserToDeleteRows = false;
            this.returnBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnBooksGridView.Location = new System.Drawing.Point(1, 1);
            this.returnBooksGridView.Name = "returnBooksGridView";
            this.returnBooksGridView.ReadOnly = true;
            this.returnBooksGridView.RowHeadersWidth = 51;
            this.returnBooksGridView.RowTemplate.Height = 24;
            this.returnBooksGridView.Size = new System.Drawing.Size(992, 366);
            this.returnBooksGridView.TabIndex = 0;
            this.returnBooksGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.returnBooksGridView_CellMouseClick);
            // 
            // btn_returnBook
            // 
            this.btn_returnBook.Location = new System.Drawing.Point(715, 436);
            this.btn_returnBook.Name = "btn_returnBook";
            this.btn_returnBook.Size = new System.Drawing.Size(112, 37);
            this.btn_returnBook.TabIndex = 1;
            this.btn_returnBook.Text = "Return Book";
            this.btn_returnBook.UseVisualStyleBackColor = true;
            this.btn_returnBook.Click += new System.EventHandler(this.btn_returnBook_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 565);
            this.Controls.Add(this.btn_returnBook);
            this.Controls.Add(this.returnBooksGridView);
            this.Name = "ReturnBook";
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.returnBooksGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView returnBooksGridView;
        private System.Windows.Forms.Button btn_returnBook;
    }
}