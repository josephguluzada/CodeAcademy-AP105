using System.ComponentModel.DataAnnotations;

namespace Pustok.ViewModels.Member
{
	public class MemberRegisterViewModel
	{
		[Required]
		[StringLength(maximumLength:50)]
		public string Fullname { get; set; }
        [Required]
		[StringLength(maximumLength:20)]
        public string Username { get; set; }
        [Required]
        [StringLength(maximumLength:100)]
		public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 30,MinimumLength =8),DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(maximumLength: 30, MinimumLength = 8)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
	}
}
