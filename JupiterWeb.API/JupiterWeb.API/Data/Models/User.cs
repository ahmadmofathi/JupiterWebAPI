using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JupiterWeb.API.Data.Models
{
    public class User
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Role { get; set; }
            public string Address { get; set; }
            public decimal BasicSalary { get; set; }
            public decimal Bonus { get; set; }
            public string Email { get; set; }
            public string WhatsApp { get; set; }
            public string PhoneNumber { get; set; }
            public int JupiterCoins { get; set; }
            public DateTime GetEmployedAt { get; set; }
            public string Branch { get; set; }
        }
    }

