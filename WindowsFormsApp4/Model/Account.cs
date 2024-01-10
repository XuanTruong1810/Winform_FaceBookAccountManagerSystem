using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WindowsFormsApp4.Model
{
    class Account
    {
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        [RegularExpression(@"^[A-Za-z][A-Za-z0-9]*$", ErrorMessage = "Tên đăng nhập phải bắt đầu bằng chữ cái và có thể chứa chữ cái hoặc số")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mật khâ không được để trống"),RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Mật khẩu phải chứa ít nhất 8 ký tự, bao gồm chữ cái và số")]
        public string Password { get; set; }

        [EmailAddress(ErrorMessage = "Không phải định dạng của Email")]
        public string Email { get; set; }
    }
}

