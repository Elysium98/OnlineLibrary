namespace OnlineLibrary
{
    partial class showBooks
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
            this.dataBooksView = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.textDateAdded = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.textBookName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.textLanguage = new System.Windows.Forms.TextBox();
            this.textNumberOfPages = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataBooksView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBooksView
            // 
            this.dataBooksView.AllowUserToAddRows = false;
            this.dataBooksView.AllowUserToDeleteRows = false;
            this.dataBooksView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBooksView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataBooksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBooksView.Location = new System.Drawing.Point(1, 2);
            this.dataBooksView.Name = "dataBooksView";
            this.dataBooksView.ReadOnly = true;
            this.dataBooksView.RowHeadersWidth = 51;
            this.dataBooksView.RowTemplate.Height = 24;
            this.dataBooksView.Size = new System.Drawing.Size(945, 367);
            this.dataBooksView.TabIndex = 0;
            this.dataBooksView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataBooksView_CellMouseClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(676, 375);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 32);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Sterge";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // textDateAdded
            // 
            this.textDateAdded.Location = new System.Drawing.Point(214, 437);
            this.textDateAdded.Name = "textDateAdded";
            this.textDateAdded.Size = new System.Drawing.Size(100, 22);
            this.textDateAdded.TabIndex = 2;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(766, 375);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(97, 32);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Actualizeaza";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // textBookName
            // 
            this.textBookName.Location = new System.Drawing.Point(214, 409);
            this.textBookName.Name = "textBookName";
            this.textBookName.Size = new System.Drawing.Size(100, 22);
            this.textBookName.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 385);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(214, 385);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(100, 22);
            this.textAuthor.TabIndex = 2;
            // 
            // textLanguage
            // 
            this.textLanguage.Location = new System.Drawing.Point(214, 465);
            this.textLanguage.Name = "textLanguage";
            this.textLanguage.Size = new System.Drawing.Size(100, 22);
            this.textLanguage.TabIndex = 2;
            // 
            // textNumberOfPages
            // 
            this.textNumberOfPages.Location = new System.Drawing.Point(214, 493);
            this.textNumberOfPages.Name = "textNumberOfPages";
            this.textNumberOfPages.Size = new System.Drawing.Size(100, 22);
            this.textNumberOfPages.TabIndex = 2;
            // 
            // showBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 596);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textNumberOfPages);
            this.Controls.Add(this.textLanguage);
            this.Controls.Add(this.textBookName);
            this.Controls.Add(this.textDateAdded);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dataBooksView);
            this.Name = "showBooks";
            this.Text = "showBooks";
            this.Load += new System.EventHandler(this.showBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBooksView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataBooksView;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox textDateAdded;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox textBookName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.TextBox textLanguage;
        private System.Windows.Forms.TextBox textNumberOfPages;
    }
}