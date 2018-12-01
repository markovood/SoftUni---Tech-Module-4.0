namespace TeisterMask.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using TeisterMask.Data;
    using TeisterMask.Models;

    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new TeisterMaskDbContext())
            {
                var tasks = db.Tasks.ToList();

                return View(tasks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Task taskToCreate)
        {
            if (ModelState.IsValid)
            {
                using (var db = new TeisterMaskDbContext())
                {
                    db.Tasks.Add(taskToCreate);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            else
            {
                ViewData["Error"] = "bg-danger";
                return View(taskToCreate);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var taskToEdit = db.Tasks.FirstOrDefault(t => t.Id == id);

                if (taskToEdit != null)
                {
                    return View(taskToEdit);
                }
                else
                {
                    // TODO: Log some error message
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public IActionResult Edit(Task edittedTask)
        {
            if (ModelState.IsValid)
            {
                using (var db = new TeisterMaskDbContext())
                {
                    var entityToEdit = db.Tasks.FirstOrDefault(t => t.Id == edittedTask.Id);
                    entityToEdit.Title = edittedTask.Title;
                    entityToEdit.Status = edittedTask.Status;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");

            }
            else
            {
                ViewData["Error"] = "bg-danger";
                return View(edittedTask);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var taskToDelete = db.Tasks.FirstOrDefault(t => t.Id == id);

                if (taskToDelete != null)
                {
                    return View(taskToDelete);
                }
                else
                {
                    // TODO: Log some error message
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public IActionResult Delete(Task taskToDelete)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var entityToDelete = db.Tasks.FirstOrDefault(t => t.Id == taskToDelete.Id);
                if (entityToDelete != null)
                {
                    db.Tasks.Remove(entityToDelete);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    // TODO: Log error message
                    return RedirectToAction("Index");
                }
            }
        }
    }
}