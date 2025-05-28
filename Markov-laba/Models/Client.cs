using System.ComponentModel.DataAnnotations;

namespace Markov_laba.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Display(Name ="Логин")]
        [Required]
        public string login { get; set; }
        [Display(Name ="Пароль")]
        [Required]
        public string password { get; set; }
    }
}
