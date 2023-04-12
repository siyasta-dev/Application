using System.ComponentModel.DataAnnotations;

namespace Application.API.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
