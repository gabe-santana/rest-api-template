using System;

namespace rest_api_template.Domain.Entities
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
        
    }
}