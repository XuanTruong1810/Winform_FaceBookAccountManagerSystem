using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp4.UserControls
{

    public partial class UserControl3 : UserControl
    {
        private string connectString = "Data Source=ANHNHI;Initial Catalog=QLTK;Integrated Security=True";
        private int selectedPostID;
       
        public UserControl3()
        {
            InitializeComponent();
            PopulateAccountsComboBox();
            PopulateAccountsComboBox1();
            DataGridViewPost(int.Parse(cbo_User.SelectedValue.ToString()));
            btn_remove.Enabled = false;
            btn_update.Enabled = false;
        }
        private void PopulateAccountsComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT UserID, Username FROM Accounts Where IsAdmin = 0";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    cbo_User.DataSource = dataTable;
                    cbo_User.ValueMember = "UserID";
                    cbo_User.DisplayMember = "Username";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void PopulateAccountsComboBox1()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT UserID, Username FROM Accounts Where IsAdmin = 0";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    cbo_UserCmd.DataSource = dataTable;
                    cbo_UserCmd.ValueMember = "UserID";
                    cbo_UserCmd.DisplayMember = "Username";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DataGridViewPost(int userID)
        {
            dgv_Post.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Posts WHERE UserID = @UserID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userID);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgv_Post.Rows.Add(reader["PostID"], reader["Content"], reader["CreatedAt"]);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_User.SelectedValue != null && int.TryParse(cbo_User.SelectedValue.ToString(), out int selectedUserID))
            {
             
                DataGridViewPost(selectedUserID);
            }
        }
        private void UpdateComent()
        {
            selectedPostID = Convert.ToInt32(dgv_Post.SelectedRows[0].Cells["PostID"].Value);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    connection.Open();

                    string query = @"
                    SELECT Comments.CommentID, Accounts.UserName, Comments.Content, Comments.CreatedAt
                    FROM Comments
                    INNER JOIN Accounts ON Comments.UserID = Accounts.UserID
                    WHERE Comments.PostID = @PostID
                    ORDER BY Comments.CreatedAt DESC";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@PostID", selectedPostID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewComments.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Post.SelectedRows.Count > 0)
            {
                UpdateComent();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string commentContent = RT_comment.Text;
            int.TryParse(cbo_UserCmd.SelectedValue.ToString(), out int selectIdUserComment);
            if (dgv_Post.SelectedRows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(commentContent))
                {

                    MessageBox.Show("Vui lòng nhập nội dung comment.");
                    RT_comment.Focus();
                    return;
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectString))
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand("AddComment", connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PostID", selectedPostID);
                        cmd.Parameters.AddWithValue("@UserID", selectIdUserComment);
                        cmd.Parameters.AddWithValue("@Content", commentContent);


                        cmd.ExecuteNonQuery();
                        UpdateComent();
                        MessageBox.Show("Thêm comment thành công!");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                RT_comment.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bài đăng");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewComments.SelectedRows.Count > 0)
            {
                try
                {
                    int idComment = Convert.ToInt32(dataGridViewComments.SelectedRows[0].Cells["CommentID"].Value);
                    using (SqlConnection connection = new SqlConnection(connectString))
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand("DeleteComment", connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CommentID", idComment);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            UpdateComent();
                            MessageBox.Show("Comment đã được xóa thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa comment.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một comment để xóa.");
            }
            
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv_Post.SelectedRows.Count > 0)
            {
                string content = RT_comment.Text;
                
                if (!string.IsNullOrEmpty(content))
                    try
                    {
                        int idComment = Convert.ToInt32(dataGridViewComments.SelectedRows[0].Cells["CommentID"].Value);
                        using (SqlConnection connection = new SqlConnection(connectString))
                        {
                            connection.Open();

                            SqlCommand cmd = new SqlCommand("UpdateComment", connection);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@CommentID", idComment);
                            cmd.Parameters.AddWithValue("@Content", content);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Comment đã được cập nhật thành công.");
                                UpdateComent();
                            }
                            else
                            {
                                MessageBox.Show("Không thể cập nhật comment.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                else
                {
                    MessageBox.Show("Vui lòng nhập nội dung bình luận");
                    RT_comment.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bình luận");
            }
            RT_comment.Clear();
        }

        private void dataGridViewComments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridViewComments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridViewComments.Rows.Count)
            {

                btn_add.Enabled = false;
                btn_remove.Enabled = true;
                btn_update.Enabled = true;
                DataGridViewRow selectedRow = dataGridViewComments.Rows[rowIndex];

                RT_comment.Text = Convert.ToString(selectedRow.Cells[2].Value);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            RT_comment.Text = "";
        }
    }
}
