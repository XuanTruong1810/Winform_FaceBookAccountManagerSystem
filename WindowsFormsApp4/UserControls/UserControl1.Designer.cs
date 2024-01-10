
namespace WindowsFormsApp4.UserControls
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.dgv_account = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ErrorUsername = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.ErrorPassword = new System.Windows.Forms.Label();
            this.ErrorEmail = new System.Windows.Forms.Label();
            this.pictureUSer = new System.Windows.Forms.PictureBox();
            this.Txt_IDUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUSer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_account
            // 
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.Email,
            this.Password});
            this.dgv_account.Location = new System.Drawing.Point(14, 21);
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.RowHeadersWidth = 51;
            this.dgv_account.RowTemplate.Height = 24;
            this.dgv_account.Size = new System.Drawing.Size(767, 523);
            this.dgv_account.TabIndex = 0;
            this.dgv_account.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccounts_CellClick);
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 200;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên người dùng";
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(341, 69);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(144, 22);
            this.txt_User.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(58, 264);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(78, 325);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(376, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.btn_Remove);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Location = new System.Drawing.Point(14, 501);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 92);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_Add
            // 
            this.btn_Add.Image = global::WindowsFormsApp4.Properties.Resources.add_contact;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(20, 25);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(163, 52);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Thêm tài khoản";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Image = global::WindowsFormsApp4.Properties.Resources.user_delete;
            this.btn_Remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Remove.Location = new System.Drawing.Point(341, 25);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(144, 52);
            this.btn_Remove.TabIndex = 9;
            this.btn_Remove.Text = "Xóa tài khoản";
            this.btn_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Image = global::WindowsFormsApp4.Properties.Resources.update;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(189, 25);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(146, 52);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Sửa tài khoản";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_account);
            this.groupBox2.Location = new System.Drawing.Point(525, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 559);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tài khoản";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ErrorUsername);
            this.groupBox3.Controls.Add(this.btn_Clear);
            this.groupBox3.Controls.Add(this.ErrorPassword);
            this.groupBox3.Controls.Add(this.ErrorEmail);
            this.groupBox3.Controls.Add(this.pictureUSer);
            this.groupBox3.Controls.Add(this.Txt_IDUser);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_User);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(14, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 461);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin tài khoản";
            // 
            // ErrorUsername
            // 
            this.ErrorUsername.AutoSize = true;
            this.ErrorUsername.Location = new System.Drawing.Point(233, 105);
            this.ErrorUsername.Name = "ErrorUsername";
            this.ErrorUsername.Size = new System.Drawing.Size(0, 17);
            this.ErrorUsername.TabIndex = 15;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Image = global::WindowsFormsApp4.Properties.Resources.edit_clear;
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clear.Location = new System.Drawing.Point(362, 392);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(123, 52);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.button5_Click);
            // 
            // ErrorPassword
            // 
            this.ErrorPassword.AutoSize = true;
            this.ErrorPassword.Location = new System.Drawing.Point(10, 360);
            this.ErrorPassword.Name = "ErrorPassword";
            this.ErrorPassword.Size = new System.Drawing.Size(0, 17);
            this.ErrorPassword.TabIndex = 14;
            // 
            // ErrorEmail
            // 
            this.ErrorEmail.AutoSize = true;
            this.ErrorEmail.Location = new System.Drawing.Point(10, 297);
            this.ErrorEmail.Name = "ErrorEmail";
            this.ErrorEmail.Size = new System.Drawing.Size(0, 17);
            this.ErrorEmail.TabIndex = 13;
            // 
            // pictureUSer
            // 
            this.pictureUSer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureUSer.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureUSer.ErrorImage")));
            this.pictureUSer.Image = ((System.Drawing.Image)(resources.GetObject("pictureUSer.Image")));
            this.pictureUSer.Location = new System.Drawing.Point(9, 21);
            this.pictureUSer.Name = "pictureUSer";
            this.pictureUSer.Size = new System.Drawing.Size(218, 212);
            this.pictureUSer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUSer.TabIndex = 12;
            this.pictureUSer.TabStop = false;
            this.pictureUSer.WaitOnLoad = true;
            this.pictureUSer.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Txt_IDUser
            // 
            this.Txt_IDUser.Location = new System.Drawing.Point(341, 21);
            this.Txt_IDUser.Name = "Txt_IDUser";
            this.Txt_IDUser.ReadOnly = true;
            this.Txt_IDUser.Size = new System.Drawing.Size(144, 22);
            this.Txt_IDUser.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã người dùng";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1383, 775);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUSer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox Txt_IDUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.PictureBox pictureUSer;
        private System.Windows.Forms.Label ErrorUsername;
        private System.Windows.Forms.Label ErrorPassword;
        private System.Windows.Forms.Label ErrorEmail;
    }
}
