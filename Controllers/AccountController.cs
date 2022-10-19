using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalCar.Models.Account;
using RentalCar.DAL.Account;
using RentalCar.DAL;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace RentalCar.Controllers
{
    public class AccountController : Controller
    {
        private AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            RegisterModel model = new RegisterModel { };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                Account account = await _context.Accounts.FirstOrDefaultAsync(u => u.Login == model.Login);
                if (account == null)
                {
                    // добавляем пользователя в бд
                    account = new Account { Login = model.Login, Password = model.Password, Role_Id = 3 };
                    PersonalData personalData=new PersonalData { FirstName=model.Name, LastName=model.Surname,Patronymic=model.Middlename, Phone=model.Phone, Addres=model.Addres };
                    _context.PersonalDatas.Add(personalData);
                    await _context.SaveChangesAsync();
                    account.PersonalData_Id = personalData.Id;
                    _context.Accounts.Add(account);
                    await _context.SaveChangesAsync();

                    await Authenticate(account); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                Account account = await _context.Accounts
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.Login == model.Login && u.Password == model.Password);
                if (account != null)
                {
                    await Authenticate(account); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        private async Task Authenticate(Account account)
        {
            Account acc = await _context.Accounts
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.Login == account.Login && u.Password == account.Password);
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, acc.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, acc.Role?.Name)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }


        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
        [Authorize(Roles = "Администратор")]
        [HttpGet]
        public IActionResult RegisterAdmin()
        {
            RegisterModel model = new RegisterModel { Roles = GetRoles() };
            return View(model);
        }
        [Authorize(Roles = "Администратор")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterAdmin(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                Account account = await _context.Accounts.FirstOrDefaultAsync(u => u.Login == model.Login);
                if (account == null)
                {
                    // добавляем пользователя в бд
                    account = new Account { Login = model.Login, Password = model.Password, Role_Id = model.RoleId };
                    PersonalData personalData = new PersonalData { FirstName = model.Name, LastName = model.Surname, Patronymic = model.Middlename, Phone = model.Phone, Addres = model.Addres };
                    _context.PersonalDatas.Add(personalData);
                    await _context.SaveChangesAsync();
                    account.PersonalData_Id = personalData.Id;
                    _context.Accounts.Add(account);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }

            return View(model);
        }
        private IEnumerable<Role> GetRoles()
        {
            return _context.Roles;
        }
    }
}
