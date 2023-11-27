using System.ComponentModel.DataAnnotations;

namespace Vinsj.Models.Account;

public class LoginViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    [Display(Name = "Husk meg?")]
    public bool RememberMe { get; set; }
}
