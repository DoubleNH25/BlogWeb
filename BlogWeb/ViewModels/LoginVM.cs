using Microsoft.Build.Framework;
namespace BlogWeb.ViewModels
{
	public class LoginVM
	{
		[Required] // đánh dấu thuộc tính bắt buộc có giá trị
		public string? Username { get; set; }

		[Required]
		public string? Password { get; set; }

		public bool RememberMe { get; set; }
	}
}
