using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2_MVC.Controllers
{
    public class ExampleController1 : Controller
    {
        // GET: ExampleController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExampleController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExampleController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExampleController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExampleController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExampleController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExampleController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExampleController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
