using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.Model;
using WebApplication1.Services;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<User> _repo;

        public HomeController(IRepository<User> repository)
        {
            _repo = repository;
        }
        public IActionResult Index()
        {
            var list = _repo.GetAll();
            var vms = list.Select(x => new StudentViewModel
            {
                name = $"{x.firstName} {x.lastName}",
                age = System.DateTime.Now.Subtract(x.birthday).Days / 365,
                id = x.id
            });
            var vm = new HomeIndexViewModel
            {
                students = vms
            };
            return View(vm);
        }
        public IActionResult Detail(int id)
        {
            var x = _repo.FindById(id);

            if (x == null)
            {
                return RedirectToAction("Index");
            }
            var studentView = new StudentViewModel
            {
                name = $"{x.firstName} {x.lastName}",
                age = System.DateTime.Now.Subtract(x.birthday).Days / 365,
                id = x.id
            };
            return View(studentView);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(StudentCreateModel studentCreateModel)
        {
            if (ModelState.IsValid)
            {
                var newStudent = new User
                {
                    firstName = studentCreateModel.firstName,
                    lastName = studentCreateModel.lastName,
                    birthday = studentCreateModel.birthday,

                };
                _repo.Add(newStudent);

                return RedirectToAction(nameof(Detail), new { id = newStudent.id });
            }
            else
            {
                return View();

            }
           
          
        }
    }
}
