using Microsoft.EntityFrameworkCore;

namespace Application.API.Models
{
    [Index(nameof(Id))]
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
