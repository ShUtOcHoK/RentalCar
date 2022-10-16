using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RentalCar.DAL.Account
{
    public class Account
    {
        [Key] //ключ
        public int Id {get;set;}
        [Required] // не null
        public string Login {get;set;}
        [Required]
        public string Password {get;set;}
        [Required]
        public int Role_Id {get;set;}

        [ForeignKey(nameof(Role_Id))] 
        [InverseProperty(nameof(Role.Account))] 
        public Role Role { get; set; } 

        [Required]
        public int PersonalData_Id { get; set; }

        [ForeignKey(nameof(PersonalData_Id))]
        [InverseProperty(nameof(PersonalData.Account))]
        public PersonalData PersonalData { get; set; }

    }
}
