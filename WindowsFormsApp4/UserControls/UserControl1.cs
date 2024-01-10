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
using System.IO;

namespace WindowsFormsApp4.UserControls
{
    
    public partial class UserControl1 : UserControl
    {

        private int selectedUserID;
        private string connectString = "Data Source=ANHNHI;Initial Catalog=QLTK;Integrated Security=True";
        public UserControl1()
        {
            InitializeComponent();
            btn_Remove.Enabled = false;
            btn_Update.Enabled = false;


        }
        private void UpdateDataGridViewAccounts()
        {
            dgv_account.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM [Accounts] WHERE IsAdmin = 0";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        dgv_account.Rows.Add(reader["UserID"], reader["Username"], reader["Email"], reader["Password"]);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {
            UpdateDataGridViewAccounts();
        }

        private void dataGridViewAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dgv_account.Rows.Count)
            {
                btn_Add.Enabled = false;
                btn_Remove.Enabled = true;
                btn_Update.Enabled = true;
                DataGridViewRow selectedRow = dgv_account.Rows[rowIndex];
                selectedUserID = Convert.ToInt32(selectedRow.Cells[0].Value);
                txt_User.Text = Convert.ToString(selectedRow.Cells[1].Value);
                txtEmail.Text = Convert.ToString(selectedRow.Cells[2].Value);
                txtPassword.Text = Convert.ToString(selectedRow.Cells[3].Value);
                Txt_IDUser.Text = selectedUserID.ToString();
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    try
                    {
                        connection.Open();

                        string query =$"SELECT Image FROM dbo.Accounts where UserID = {selectedUserID}";

                        SqlCommand command = new SqlCommand(query, connection);
                        var reader = command.ExecuteScalar();

                        pictureUSer.ImageLocation = $"C:\\Users\\asus\\OneDrive\\Máy tính\\WindowsFormsApp4\\WindowsFormsApp4\\Image\\{reader}";
                    }
                    catch (Exception)
                    {
                        pictureUSer.ImageLocation = "C:\\Users\\asus\\OneDrive\\Máy tính\\WindowsFormsApp4\\WindowsFormsApp4\\Image\\Default.png";
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv_account.SelectedRows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand("DeleteAccount", connection);
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", selectedUserID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            UpdateDataGridViewAccounts();
                            MessageBox.Show("Xóa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa");
            }
            txt_User.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }
        private void ClearErrorLabels()
        {

            ErrorUsername.Text = "";
            ErrorPassword.Text = "";
            ErrorEmail.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = txt_User.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            ClearErrorLabels();
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {

                Account newAcc = new Account()
                {
                    Email = email,
                    Password = password,
                    Username = username,
                };
                if (ValidateAccount(newAcc))
                {
                    using (SqlConnection connection = new SqlConnection(connectString))
                    {
                        try
                        {
                            connection.Open();

                            SqlCommand command = new SqlCommand("AddAccount", connection);
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@Username", newAcc.Username);
                            command.Parameters.AddWithValue("@Email", newAcc.Email);
                            command.Parameters.AddWithValue("@Password", newAcc.Password);

                            int result = command.ExecuteNonQuery();
                            MessageBox.Show(result > 0 ? "Thêm tài khoản thành công" : " thêm tài khoản thất bại");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Email đã tồn tại vui lòng nhập 1 email mới");
                            txt_User.Focus();
                        }

                        UpdateDataGridViewAccounts();

                        txt_User.Text = "";
                        txtEmail.Text = "";
                        txtPassword.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txt_User.Focus();
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            if (selectedUserID != 0)
            {
               
                string id = Txt_IDUser.Text;
                string username = txt_User.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                
                ClearErrorLabels();
                Account newAcc = new Account()
                {
                    Email = email,
                    Password = password,
                    Username = username,

                };
                if (ValidateAccount(newAcc))
                {
                    using (SqlConnection connection = new SqlConnection(connectString))
                    {
                        try
                        {

                            connection.Open();

                            SqlCommand command = new SqlCommand("UpdateAccount", connection);
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@UserID", id);
                            command.Parameters.AddWithValue("@Username", newAcc.Username);
                            command.Parameters.AddWithValue("@Email", newAcc.Email);
                            command.Parameters.AddWithValue("@Password", newAcc.Password);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                UpdateDataGridViewAccounts();
                                MessageBox.Show("Cập nhật thành công");
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thất bại");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
                
                
                selectedUserID = 0;
                txt_User.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người dùng để cập nhật");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_User.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            Txt_IDUser.Text = "";
            btn_Add.Enabled = true;
            pictureUSer.ImageLocation = "C:\\Users\\asus\\OneDrive\\Máy tính\\WindowsFormsApp4\\WindowsFormsApp4\\Image\\Default.png";
        }
        private bool ValidateAccount(Account account)
        {

            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(account, null, null);
            var validationResults = new System.Collections.Generic.List<System.ComponentModel.DataAnnotations.ValidationResult>();


            bool isValid = System.ComponentModel.DataAnnotations.Validator.TryValidateObject(account, validationContext, validationResults, true);

            if (!isValid)
            {
                foreach (var validationResult in validationResults)
                {
                    if (validationResult.MemberNames.Contains("Username"))
                    {
                        ErrorUsername.Text = validationResult.ErrorMessage;
                        ErrorUsername.ForeColor = Color.Red;
                    }
                    else if (validationResult.MemberNames.Contains("Password"))
                    {
                        ErrorPassword.Text = validationResult.ErrorMessage;
                        ErrorPassword.ForeColor = Color.Red;
                    }
                    else 
                    {
                        ErrorEmail.Text = validationResult.ErrorMessage;
                        ErrorEmail.ForeColor = Color.Red;
                    }
                }
            }

            return isValid;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp; *.webp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp; *.webp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = openFileDialog.FileName;
                    string destinationFolderPath = @"C:\Users\asus\OneDrive\Máy tính\WindowsFormsApp4\WindowsFormsApp4\Image"; 
                    string fileName = Path.GetFileName(selectedImagePath);

                    string destinationPath = Path.Combine(destinationFolderPath, fileName);
                    using (SqlConnection connection = new SqlConnection(connectString))
                    {
                        try
                        {
                            connection.Open();

                            string query = $"UPDATE dbo.Accounts SET Image ='{fileName}' WHERE dbo.Accounts.UserID = ${Txt_IDUser.Text}";

                            SqlCommand command = new SqlCommand(query, connection);
                            int reader = command.ExecuteNonQuery();
                            if(reader > 0)
                            {
                                MessageBox.Show("Thêm ảnh thành công");
                            }
                            else
                            {
                                MessageBox.Show("Thêm không thành công");
                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    File.Copy(selectedImagePath, destinationPath, true);

                    
                    pictureUSer.ImageLocation = destinationPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
