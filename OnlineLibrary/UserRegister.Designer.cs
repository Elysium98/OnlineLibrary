namespace OnlineLibrary
{
    partial class UserRegister
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textFullName = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // textFullName
            // 
            this.textFullName.Location = new System.Drawing.Point(156, 117);
            this.textFullName.Name = "textFullName";
            this.textFullName.Size = new System.Drawing.Size(265, 22);
            this.textFullName.TabIndex = 1;
            this.textFullName.Text = "Please enter your Full Name";
            this.textFullName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textFullName_MouseClick);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(156, 145);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(265, 22);
            this.textEmail.TabIndex = 1;
            this.textEmail.Text = "Please enter your email";
            this.textEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textEmail_MouseClick);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(156, 173);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(265, 22);
            this.textPassword.TabIndex = 1;
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(156, 245);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register.TabIndex = 2;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textFullName);
            this.Controls.Add(this.label1);
            this.Name = "UserRegister";
            this.Size = new System.Drawing.Size(651, 430);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFullName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button btn_Register;
    }
}
