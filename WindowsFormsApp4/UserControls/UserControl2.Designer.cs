
namespace WindowsFormsApp4.UserControls
{
    partial class UserControl2
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
            this.dgv_post = new System.Windows.Forms.DataGridView();
            this.Post_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_IdPost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_createAt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rt_Content = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_ListUser = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_post)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_post
            // 
            this.dgv_post.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_post.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_post.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Post_Id,
            this.content,
            this.Date});
            this.dgv_post.Location = new System.Drawing.Point(8, 23);
            this.dgv_post.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_post.Name = "dgv_post";
            this.dgv_post.RowHeadersWidth = 51;
            this.dgv_post.RowTemplate.Height = 24;
            this.dgv_post.Size = new System.Drawing.Size(915, 403);
            this.dgv_post.TabIndex = 0;
            this.dgv_post.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Post_Id
            // 
            this.Post_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Post_Id.HeaderText = "Mã bài đăng";
            this.Post_Id.MinimumWidth = 6;
            this.Post_Id.Name = "Post_Id";
            this.Post_Id.ReadOnly = true;
            this.Post_Id.Width = 125;
            // 
            // content
            // 
            this.content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.content.HeaderText = "Nội dung";
            this.content.MinimumWidth = 6;
            this.content.Name = "content";
            this.content.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Ngày đăng bài";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 200;
            // 
            // txt_IdPost
            // 
            this.txt_IdPost.Location = new System.Drawing.Point(109, 45);
            this.txt_IdPost.Name = "txt_IdPost";
            this.txt_IdPost.ReadOnly = true;
            this.txt_IdPost.Size = new System.Drawing.Size(227, 22);
            this.txt_IdPost.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã bài đăng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nội dung";
            // 
            // txt_createAt
            // 
            this.txt_createAt.Location = new System.Drawing.Point(1110, 496);
            this.txt_createAt.Name = "txt_createAt";
            this.txt_createAt.ReadOnly = true;
            this.txt_createAt.Size = new System.Drawing.Size(227, 22);
            this.txt_createAt.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1039, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngày tạo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rt_Content);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbo_ListUser);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_IdPost);
            this.groupBox3.Location = new System.Drawing.Point(32, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 267);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin bài đăng";
            // 
            // rt_Content
            // 
            this.rt_Content.Location = new System.Drawing.Point(109, 80);
            this.rt_Content.Name = "rt_Content";
            this.rt_Content.Size = new System.Drawing.Size(227, 137);
            this.rt_Content.TabIndex = 1;
            this.rt_Content.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Danh sách người dùng";
            // 
            // cbo_ListUser
            // 
            this.cbo_ListUser.FormattingEnabled = true;
            this.cbo_ListUser.Location = new System.Drawing.Point(174, 223);
            this.cbo_ListUser.Name = "cbo_ListUser";
            this.cbo_ListUser.Size = new System.Drawing.Size(162, 24);
            this.cbo_ListUser.TabIndex = 19;
            this.cbo_ListUser.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_remove);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Location = new System.Drawing.Point(32, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 161);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Image = global::WindowsFormsApp4.Properties.Resources.edit_clear;
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clear.Location = new System.Drawing.Point(208, 97);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(128, 58);
            this.btn_Clear.TabIndex = 22;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::WindowsFormsApp4.Properties.Resources.post_add;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(20, 35);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(162, 56);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Thêm bài viết";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Image = global::WindowsFormsApp4.Properties.Resources.post_remove;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove.Location = new System.Drawing.Point(20, 97);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(162, 58);
            this.btn_remove.TabIndex = 11;
            this.btn_remove.Text = "Xóa bài viết";
            this.btn_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_update
            // 
            this.btn_update.Image = global::WindowsFormsApp4.Properties.Resources.update1;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(208, 35);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(128, 56);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Sửa bài viết";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_post);
            this.groupBox2.Location = new System.Drawing.Point(406, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(931, 434);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bài đăng";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_createAt);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1369, 826);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_post)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_post;
        private System.Windows.Forms.TextBox txt_IdPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_createAt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_ListUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.RichTextBox rt_Content;
        private System.Windows.Forms.Button btn_Clear;
    }
}
