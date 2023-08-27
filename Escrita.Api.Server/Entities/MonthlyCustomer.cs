using System.ComponentModel.DataAnnotations;

namespace Escrita.Api.Server.Entities
{
    public class MonthlyCustomer
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ConnectionString { get; set; } 
            
        public Guid Tenant { get; set; }
    }
}
