using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalCar.DAL.Account
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [InverseProperty(nameof(DAL.Account.Account.Role))]
        public ICollection<Account> Accounts { get; set; }
    }
}
