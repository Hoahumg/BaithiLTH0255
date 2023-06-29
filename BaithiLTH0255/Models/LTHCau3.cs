using System.ComponentModel.DataAnnotations;
namespace BaithiLTH0255.Models;
public class LTHCau3
{
    [Key]
    public string Masinhvien {get; set;}
    public string Hoten {get; set;}
    public string Malop {get; set;}
}