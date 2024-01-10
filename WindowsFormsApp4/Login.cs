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
namespace WindowsFormsApp4
{
    public partial class Login : Form
    {
        private string connectString = "Data Source=ANHNHI;Initial Catalog=QLTK;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
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
                        ErrorUserName.Text = validationResult.ErrorMessage;
                        ErrorUserName.ForeColor = Color.Red;
                    }
                    else if (validationResult.MemberNames.Contains("Password"))
                    {
                        ErrorPassword.Text = validationResult.ErrorMessage;
                        ErrorPassword.ForeColor = Color.Red;

                    }
                }
            }

            return isValid;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void ClearErrorLabels()
        {

            ErrorUserName.Text = "";
            ErrorPassword.Text = "";
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            ClearErrorLabels();
            Account userAccount = new Account
            {
                Username = UserName.Text,
                Password = Password .Text
            };

           
            if (ValidateAccount(userAccount))
            {
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT COUNT(*) FROM Accounts WHERE Username = @Username AND Password = @Password AND IsAdmin = 1";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Username", userAccount.Username);
                        command.Parameters.AddWithValue("@Password", userAccount.Password);

                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            Form1 form1 = new Form1();
                            this.Hide();
                            form1.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Bạn không có quyền truy cập",ex.Message);
                    }

                }
                UserName.Text = "";
                Password.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
