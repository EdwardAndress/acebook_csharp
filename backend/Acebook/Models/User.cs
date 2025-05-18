namespace acebook.Models;
using System.ComponentModel.DataAnnotations;

public class User
{
  [Key]
  public int _Id {get; set;}

  public string? Username { get; set; }

  public string? Email { get; set; }
  
  // validates password
  [RegularExpression(@"^(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Password is invalid.")]
  public string? Password { get; set; }

  public ICollection<Post>? Posts { get; set; }
}