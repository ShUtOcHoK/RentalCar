using RentalCar.DAL.Account;
using System.ComponentModel.DataAnnotations;
namespace RentalCar.Models.Account
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указан Логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Не указан Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Не указан повторно Пароль")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадает")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Не указано Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указана Фамилия")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Не указана Отчество")]
        public string Patronomic { get; set; 
        }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Не указан номер телефона")]
        public string Phone { get; set; }

    }
}
