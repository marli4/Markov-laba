using System.ComponentModel.DataAnnotations;
namespace Markov_laba.Models
{
    public class Courier
    {
        public int Id { get; set; }
        [Required]
        [Display (Name ="Логин")]
        public string login { get; set; }
        [Required]
        [Display(Name ="Пароль")]
        public string password { get; set; }
    }
}
