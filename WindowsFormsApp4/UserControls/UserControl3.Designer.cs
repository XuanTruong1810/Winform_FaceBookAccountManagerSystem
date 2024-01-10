
namespace WindowsFormsApp4.UserControls
{
    partial class UserControl3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.RT_comment = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_UserCmd = new System.Windows.Forms.ComboBox();
            this.cbo_User = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Post = new System.Windows.Forms.DataGridView();
            this.PostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewComments = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Post)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.RT_comment);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbo_UserCmd);
            this.groupBox1.Controls.Add(this.cbo_User);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bình luận";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Image = global::WindowsFormsApp4.Properties.Resources.edit_clear;
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clear.Location = new System.Drawing.Point(519, 193);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(123, 52);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // RT_comment
            // 
            this.RT_comment.Location = new System.Drawing.Point(209, 95);
            this.RT_comment.Name = "RT_comment";
            this.RT_comment.Size = new System.Drawing.Size(283, 96);
            this.RT_comment.TabIndex = 12;
            this.RT_comment.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chọn người dùng bình luận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Danh sách người dùng";
            // 
            // cbo_UserCmd
            // 
            this.cbo_UserCmd.FormattingEnabled = true;
            this.cbo_UserCmd.Location = new System.Drawing.Point(209, 208);
            this.cbo_UserCmd.Name = "cbo_UserCmd";
            this.cbo_UserCmd.Size = new System.Drawing.Size(283, 24);
            this.cbo_UserCmd.TabIndex = 9;
            // 
            // cbo_User
            // 
            this.cbo_User.FormattingEnabled = true;
            this.cbo_User.Location = new System.Drawing.Point(209, 51);
            this.cbo_User.Name = "cbo_User";
            this.cbo_User.Size = new System.Drawing.Size(283, 24);
            this.cbo_User.TabIndex = 8;
            this.cbo_User.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung bình luận";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Post);
            this.groupBox2.Location = new System.Drawing.Point(30, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(940, 302);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bài đăng";
            // 
            // dgv_Post
            // 
            this.dgv_Post.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Post.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PostID,
            this.Content,
            this.CreatedAt});
            this.dgv_Post.Location = new System.Drawing.Point(6, 46);
            this.dgv_Post.Name = "dgv_Post";
            this.dgv_Post.RowHeadersWidth = 51;
            this.dgv_Post.RowTemplate.Height = 24;
            this.dgv_Post.Size = new System.Drawing.Size(928, 248);
            this.dgv_Post.TabIndex = 0;
            this.dgv_Post.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // PostID
            // 
            this.PostID.HeaderText = "Mã bài đăng";
            this.PostID.MinimumWidth = 6;
            this.PostID.Name = "PostID";
            this.PostID.Width = 200;
            // 
            // Content
            // 
            this.Content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Content.HeaderText = "Nội dung";
            this.Content.MinimumWidth = 6;
            this.Content.Name = "Content";
            // 
            // CreatedAt
            // 
            this.CreatedAt.HeaderText = "Ngày tạo";
            this.CreatedAt.MinimumWidth = 6;
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_remove);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Location = new System.Drawing.Point(695, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 259);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_update
            // 
            this.btn_update.Image = global::WindowsFormsApp4.Properties.Resources.update2;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(50, 178);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(173, 54);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Sửa bình luận";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Image = global::WindowsFormsApp4.Properties.Resources.Comment_remove;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove.Location = new System.Drawing.Point(50, 105);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(173, 54);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "Xóa bình luận";
            this.btn_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::WindowsFormsApp4.Properties.Resources.comment_add;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(50, 30);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(173, 54);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Thêm bình luận";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewComments);
            this.groupBox4.Location = new System.Drawing.Point(1001, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 569);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách các bình luận của bài đăng";
            // 
            // dataGridViewComments
            // 
            this.dataGridViewComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComments.Location = new System.Drawing.Point(6, 30);
            this.dataGridViewComments.Name = "dataGridViewComments";
            this.dataGridViewComments.RowHeadersWidth = 51;
            this.dataGridViewComments.RowTemplate.Height = 24;
            this.dataGridViewComments.Size = new System.Drawing.Size(303, 531);
            this.dataGridViewComments.TabIndex = 0;
            this.dataGridViewComments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComments_CellClick);
            this.dataGridViewComments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComments_CellContentClick);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(1391, 806);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Post)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Post;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewComments;
        private System.Windows.Forms.ComboBox cbo_UserCmd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.RichTextBox RT_comment;
        private System.Windows.Forms.Button btn_Clear;
    }
}
