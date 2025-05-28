using System.ComponentModel.DataAnnotations;
namespace Markov_laba.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "ID клиента")]
        public int clientId {  get; set; }
        [Display(Name = "ID курьера")]
        public int courierId { get; set; }
        [Display(Name = "Адрес")]
        public string adress { get; set; }
        [Display(Name = "Блюдо")]
        public string? dish { get; set; }
        [Display(Name = "Доставлен")]
        public bool delivered { get; set; }
    }
}
