using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Model;
using System.Data.SqlClient;
namespace WindowsFormsApp4.UserControls
{
    public partial class UserControl2 : UserControl
    {
        private string connectString = "Data Source=ANHNHI;Initial Catalog=QLTK;Integrated Security=True";
        private int selectedPostID;
        public UserControl2()
        {
            InitializeComponent();
            btn_remove.Enabled = false;
            btn_update.Enabled = false;
            PopulateAccountsComboBox();
            UpdateDataGridViewPost(int.Parse(cbo_ListUser.SelectedValue.ToString()));
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
                    cbo_ListUser.DataSource = dataTable;
                    cbo_ListUser.ValueMember = "UserID";
                    cbo_ListUser.DisplayMember = "Username";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_ListUser.SelectedValue != null && int.TryParse(cbo_ListUser.SelectedValue.ToString(), out int selectedUserID))
            {
                UpdateDataGridViewPost(selectedUserID);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dgv_post.Rows.Count)
            {
                btn_add.Enabled = false;
                btn_remove.Enabled = true;
                btn_update.Enabled = true;
                DataGridViewRow selectedRow = dgv_post.Rows[rowIndex];
                selectedPostID = Convert.ToInt32(selectedRow.Cells[0].Value);
                txt_IdPost.Text = Convert.ToString(selectedRow.Cells[0].Value);
                rt_Content.Text = Convert.ToString(selectedRow.Cells[1].Value);
                txt_createAt.Text = Convert.ToString(selectedRow.Cells[2].Value);

            }
            
        }
        private void UpdateDataGridViewPost(int userID)
        {
            dgv_post.Rows.Clear();

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
                        dgv_post.Rows.Add(reader["PostID"], reader["Content"], reader["CreatedAt"]);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void AddPostToDatabase(int userID, string content)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("AddPost", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@Content", content);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        UpdateDataGridViewPost(userID);
                        MessageBox.Show("Post added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add post.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DeletePostFromDatabase(int postID)
        {
            
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DeletePost", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PostID", postID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        UpdateDataGridViewPost(int.Parse(cbo_ListUser.SelectedValue.ToString()));
                        MessageBox.Show("Post deleted successfully!");

                    }
                    else
                    {
                        MessageBox.Show("Failed to delete post.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void UpdatePost(int postID, string content)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UpdatePost", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PostID", postID);
                    command.Parameters.AddWithValue("@Content", content);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        UpdateDataGridViewPost(int.Parse(cbo_ListUser.SelectedValue.ToString()));
                        MessageBox.Show("Cập nhật bài viết thành công");

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật bài viết thất bại");
                    }

                }
            }
            catch
            {

            }
        }
        private void clearData()
        {
            txt_IdPost.Text = "";
            rt_Content.Text = "";
            txt_createAt.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int selectedUserID = Convert.ToInt32(cbo_ListUser.SelectedValue);
            string content = rt_Content.Text;

            if (!string.IsNullOrEmpty(content))
            {
                AddPostToDatabase(selectedUserID, content);
            }
            else
            {
                MessageBox.Show("Hãy nhập nội dung bài đăng");
                rt_Content.Focus();
            }
            clearData();


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_post.SelectedRows.Count > 0)
            { 
                DeletePostFromDatabase(selectedPostID);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bài đăng để xóa");
            }
            clearData();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv_post.SelectedRows.Count > 0)
            {
                string content = rt_Content.Text;
                if (!string.IsNullOrEmpty(content))
                    UpdatePost(selectedPostID, content);
                else
                    MessageBox.Show("Vui lòng nhập nội dung để cập nhật");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bài viết để cập nhật");
            }
            clearData();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_createAt.Text = "";
            txt_IdPost.Text = "";
            rt_Content.Text = "";
            btn_add.Enabled = true;
        }
    }
}
