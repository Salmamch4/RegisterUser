using Microsoft.AspNetCore.Mvc;
using RegisterUser.Mappers;
using RegisterUser.Models;
using RegisterUser.Repositories;
using RegisterUser.ViewModels.Users;

namespace RegisterUser.Controllers
{
    public class UserController : Controller
    {
        IUsersRepository repo;
        public UserController(IUsersRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(RegisterVM vm)
        {
            if (!ModelState.IsValid)
            { 
                return View();

            }
            User user = UsersMapper.MapToUser(vm);
            repo.Add(user);


            return RedirectToAction(nameof(Index));
        }
    }
}
