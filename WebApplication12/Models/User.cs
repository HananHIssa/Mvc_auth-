using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    
        public class User
        {
            [Key]
            public Guid Id { get; set; }
            public string name { get; set; } = null!;
            [DataType(DataType.EmailAddress)]
            public string email { get; set; } = null!;
            [DataType(DataType.Password)]
            public string password { get; set; } = null!;
            public bool isActive { get; set; }
        }

}
