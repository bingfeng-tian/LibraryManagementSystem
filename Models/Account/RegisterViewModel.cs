using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "用戶名為必填欄位")]
        [Display(Name = "用戶名")]
        public string username { get; set; }

        [Required(ErrorMessage = "電子郵件為必填欄位")]
        [EmailAddress(ErrorMessage = "請輸入有效的電子郵件地址")]
        [Display(Name = "電子郵件")]
        public string email { get; set; }

        [Required(ErrorMessage = "密碼為必填欄位")]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string password { get; set; }
    }
}