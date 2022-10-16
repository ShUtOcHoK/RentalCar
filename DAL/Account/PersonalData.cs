using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using 
namespace RentalCar.DAL.Account
{
    public class PersonalData
    {
        [Key]
        public int Id { get; set; }
        public int Account_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronomic { get; set; }
        public string Addres { get; set; }
        public string Phone { get; set; }

        [InverseProperty(nameof(Account.PersonalData))]
        public Account Account { get; set; }
    }
}
