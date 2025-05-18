namespace acebook.Models;
using System.ComponentModel.DataAnnotations;

public class Comment
{
  [Key]
  public int _Id { get; set; }

  public string Text { get; set; }
}