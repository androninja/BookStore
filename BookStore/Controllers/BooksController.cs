using Microsoft.AspNetCore.Mvc;
using BookStore.Services;
using BookStore.Models;
using System.Reflection;
using Microsoft.AspNetCore.Authorization;

namespace BookStore.Controllers
{

    [Authorize]
    public class BooksController : Controller
    {
        //Dependecy injection at runtime
        private IBookRepository bookRepository;

        public BooksController(IBookRepository repository)
        {
            this.bookRepository = repository;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {

            return View(bookRepository.GetAll());
        }
        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        //not working needs fix
        public IActionResult Delete(int? id) {
            bookRepository.Delete(id);
            TempData["Success"] = "Book Deleted Successfully!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if(ModelState.IsValid){
                bookRepository.Create(book);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Details(int? id) {
            var book = bookRepository.Get(id);
            
            return View(book);
        }
    }
}
