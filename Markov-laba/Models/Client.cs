using System.ComponentModel.DataAnnotations;

namespace Markov_laba.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Display(Name ="Логин")]
        public string login { get; set; }
    }
}
