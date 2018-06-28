namespace Stock
{
    partial class Login
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
            this.Name_txtBox = new System.Windows.Forms.TextBox();
            this.Password_txtBox = new System.Windows.Forms.TextBox();
            this.U_Name = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Forgot_Psw = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Name_txtBox
            // 
            this.Name_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_txtBox.Font = new System.Drawing.Font("SimSun", 10F);
            this.Name_txtBox.Location = new System.Drawing.Point(174, 92);
            this.Name_txtBox.Name = "Name_txtBox";
            this.Name_txtBox.Size = new System.Drawing.Size(221, 23);
            this.Name_txtBox.TabIndex = 0;
            this.Name_txtBox.Text = "Admin";
            // 
            // Password_txtBox
            // 
            this.Password_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_txtBox.Font = new System.Drawing.Font("SimSun", 10F);
            this.Password_txtBox.Location = new System.Drawing.Point(174, 135);
            this.Password_txtBox.Name = "Password_txtBox";
            this.Password_txtBox.PasswordChar = '#';
            this.Password_txtBox.Size = new System.Drawing.Size(221, 23);
            this.Password_txtBox.TabIndex = 1;
            this.Password_txtBox.Text = "Admin123";
            // 
            // U_Name
            // 
            this.U_Name.AutoSize = true;
            this.U_Name.Font = new System.Drawing.Font("SimSun", 10F);
            this.U_Name.Location = new System.Drawing.Point(78, 102);
            this.U_Name.Name = "U_Name";
            this.U_Name.Size = new System.Drawing.Size(77, 14);
            this.U_Name.TabIndex = 2;
            this.U_Name.Text = "User Name:";
            this.U_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("SimSun", 10F);
            this.Password.Location = new System.Drawing.Point(85, 139);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 14);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password:";
            this.Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(177, 213);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(103, 42);
            this.Clear_btn.TabIndex = 4;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(292, 213);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(103, 42);
            this.Login_btn.TabIndex = 5;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Forgot_Psw
            // 
            this.Forgot_Psw.AutoSize = true;
            this.Forgot_Psw.Font = new System.Drawing.Font("SimSun", 10F);
            this.Forgot_Psw.Location = new System.Drawing.Point(276, 164);
            this.Forgot_Psw.Name = "Forgot_Psw";
            this.Forgot_Psw.Size = new System.Drawing.Size(119, 14);
            this.Forgot_Psw.TabIndex = 6;
            this.Forgot_Psw.TabStop = true;
            this.Forgot_Psw.Text = "Forgot Password?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 284);
            this.Controls.Add(this.Forgot_Psw);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.U_Name);
            this.Controls.Add(this.Password_txtBox);
            this.Controls.Add(this.Name_txtBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_txtBox;
        private System.Windows.Forms.TextBox Password_txtBox;
        private System.Windows.Forms.Label U_Name;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.LinkLabel Forgot_Psw;
    }
}