namespace OnlineLibrary
{
    partial class ReturnedBooks
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
            this.returnedbooksView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.returnedbooksView1)).BeginInit();
            this.SuspendLayout();
            // 
            // returnedbooksView1
            // 
            this.returnedbooksView1.AllowUserToAddRows = false;
            this.returnedbooksView1.AllowUserToDeleteRows = false;
            this.returnedbooksView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnedbooksView1.Location = new System.Drawing.Point(0, 0);
            this.returnedbooksView1.Name = "returnedbooksView1";
            this.returnedbooksView1.ReadOnly = true;
            this.returnedbooksView1.RowHeadersWidth = 51;
            this.returnedbooksView1.RowTemplate.Height = 24;
            this.returnedbooksView1.Size = new System.Drawing.Size(1031, 425);
            this.returnedbooksView1.TabIndex = 0;
            // 
            // ReturnedBookscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 520);
            this.Controls.Add(this.returnedbooksView1);
            this.Name = "ReturnedBookscs";
            this.Text = "ReturnedBookscs";
            this.Load += new System.EventHandler(this.ReturnedBookscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.returnedbooksView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView returnedbooksView1;
    }
}