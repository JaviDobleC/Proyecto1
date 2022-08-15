using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class a : Controller
    {
        // GET: a
        public ActionResult Index()
        {
            return View();
        }

        // GET: a/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: a/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: a/Create
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

        // GET: a/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: a/Edit/5
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

        // GET: a/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: a/Delete/5
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
