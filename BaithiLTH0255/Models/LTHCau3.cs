using System.ComponentModel.DataAnnotations;
namespace BaithiLTH0255.Models;
public class LTHCau3
{
    [Key]
    [Display(Name="Mã sinh viên")]
    public string Masinhvien {get; set;}
    [Display(Name="Họ tên")]
    public string Hoten {get; set;}
    [Display(Name="Mã lớp")]
    public string Malop {get; set;}
}