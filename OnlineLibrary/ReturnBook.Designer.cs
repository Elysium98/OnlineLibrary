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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.btn_returnBook = new System.Windows.Forms.Button();
            this.returnBooksGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.returnBooksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_returnBook
            // 
            this.btn_returnBook.BackColor = System.Drawing.Color.Wheat;
            this.btn_returnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_returnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_returnBook.Location = new System.Drawing.Point(1047, 324);
            this.btn_returnBook.Margin = new System.Windows.Forms.Padding(2);
            this.btn_returnBook.Name = "btn_returnBook";
            this.btn_returnBook.Size = new System.Drawing.Size(137, 48);
            this.btn_returnBook.TabIndex = 1;
            this.btn_returnBook.Text = "Return Book";
            this.btn_returnBook.UseVisualStyleBackColor = false;
            this.btn_returnBook.Click += new System.EventHandler(this.btn_returnBook_Click);
            // 
            // returnBooksGridView
            // 
            this.returnBooksGridView.AllowUserToAddRows = false;
            this.returnBooksGridView.AllowUserToDeleteRows = false;
            this.returnBooksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.returnBooksGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.returnBooksGridView.BackgroundColor = System.Drawing.Color.White;
            this.returnBooksGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.returnBooksGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.returnBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnBooksGridView.EnableHeadersVisualStyles = false;
            this.returnBooksGridView.GridColor = System.Drawing.Color.Black;
            this.returnBooksGridView.Location = new System.Drawing.Point(-2, 0);
            this.returnBooksGridView.Margin = new System.Windows.Forms.Padding(2);
            this.returnBooksGridView.Name = "returnBooksGridView";
            this.returnBooksGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.returnBooksGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.returnBooksGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.returnBooksGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.returnBooksGridView.RowTemplate.Height = 24;
            this.returnBooksGridView.Size = new System.Drawing.Size(1209, 298);
            this.returnBooksGridView.TabIndex = 2;
            this.returnBooksGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.returnBooksGridView_CellMouseClick);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1208, 718);
            this.Controls.Add(this.returnBooksGridView);
            this.Controls.Add(this.btn_returnBook);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.returnBooksGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_returnBook;
        private System.Windows.Forms.DataGridView returnBooksGridView;
    }
}