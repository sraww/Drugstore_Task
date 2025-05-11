using Microsoft.AspNetCore.Mvc;

namespace Drugstore_Task.Controllers
{
    // Контроллер страницы Contact
    public class ContactController : Controller  
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Check(ContactController contact) // Ситраница контакты
        {
            if (ModelState.IsValid)
            {
                return Redirect("/"); //Возвращение на главную
            }
            return View();
        }
    }
}
