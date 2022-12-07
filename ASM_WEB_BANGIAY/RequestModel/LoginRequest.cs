using System.ComponentModel.DataAnnotations;

namespace ASM_WEB_BANGIAY.RequestModel
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Vui lòng không để trống")]
        public string TaiKhoan { get; set; }

        [Required(ErrorMessage = "Vui lòng không để trống")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = " ít nhất 6 ký tự")]
        public string MatKhau { get; set; }
    }
}
