using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Escrita.Api.Server.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        
        public string? Email { get; set; }

        public string? Password { get; set; }
        public Guid MonthlyCustomerId { get; set; }
    }
}
