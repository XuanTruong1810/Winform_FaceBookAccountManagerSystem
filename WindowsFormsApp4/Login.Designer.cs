
namespace WindowsFormsApp4
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Signin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ErrorPassword = new System.Windows.Forms.Label();
            this.ErrorUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(103, 114);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(279, 22);
            this.UserName.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(103, 198);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(279, 22);
            this.Password.TabIndex = 1;
            // 
            // Signin
            // 
            this.Signin.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.Signin.BackColor = System.Drawing.Color.DodgerBlue;
            this.Signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signin.ForeColor = System.Drawing.Color.White;
            this.Signin.Location = new System.Drawing.Point(103, 280);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(216, 58);
            this.Signin.TabIndex = 2;
            this.Signin.Text = "Đăng nhập";
            this.Signin.UseVisualStyleBackColor = false;
            this.Signin.Click += new System.EventHandler(this.Signin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(94, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 52);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đăng nhập";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ErrorPassword);
            this.groupBox1.Controls.Add(this.ErrorUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UserName);
            this.groupBox1.Controls.Add(this.Signin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Location = new System.Drawing.Point(411, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 392);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ErrorPassword
            // 
            this.ErrorPassword.AutoSize = true;
            this.ErrorPassword.Location = new System.Drawing.Point(22, 215);
            this.ErrorPassword.Name = "ErrorPassword";
            this.ErrorPassword.Size = new System.Drawing.Size(0, 17);
            this.ErrorPassword.TabIndex = 7;
            // 
            // ErrorUserName
            // 
            this.ErrorUserName.AutoSize = true;
            this.ErrorUserName.Location = new System.Drawing.Point(22, 144);
            this.ErrorUserName.Name = "ErrorUserName";
            this.ErrorUserName.Size = new System.Drawing.Size(0, 17);
            this.ErrorUserName.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.png_clipart_computer_icons_password_user_window_furniture_window;
            this.pictureBox1.Location = new System.Drawing.Point(41, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(875, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Signin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ErrorPassword;
        private System.Windows.Forms.Label ErrorUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}