using System.ComponentModel.DataAnnotations;

namespace Markov_laba.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string adress { get; set; }
        public string? name { get; set; }
        public string? cuisine { get; set; }
    }
}
