using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Application.API.Models
{
    [Index(nameof(Id))]
    public class Account
    {
        public int Id { get; set; }
        [Required]
        public int Balance { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
