namespace ToDoList.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using ToDoList.Data;
    using ToDoList.Models;

    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new ToDoDbContext())
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
        public IActionResult Create(Task newTask)
        {
            if (ModelState.IsValid)
            {
                using (var db = new ToDoDbContext())
                {
                    db.Add(newTask);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            else
            {
                ViewData["Error"] = "Title and comments are required!";
                return View();
            }
        }

        public IActionResult Details(Task taskToDelete)
        {
            using (var db = new ToDoDbContext())
            {
                var entityToDelete = db.Tasks.FirstOrDefault(t => t.Id == taskToDelete.Id);

                if (entityToDelete != null)
                {
                    return View(entityToDelete);
                }
                else
                {
                    // this is the case when the user tries to delete invalid id passing it in the URL directly
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            using (var db = new ToDoDbContext())
            {
                var entityToDelete = db.Tasks.FirstOrDefault(t => t.Id == id);
                if (entityToDelete != null)
                {
                    db.Tasks.Remove(entityToDelete);
                    db.SaveChanges();

                    // TODO: Log message for successful deletion
                    return RedirectToAction("Index");
                }
                else
                {
                    // TODO: Log message for unsuccessful deletion
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new ToDoDbContext())
            {
                var taskToEdit = db.Tasks.FirstOrDefault(t => t.Id == id);

                return View(taskToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Task edittedTask)
        {
            if (ModelState.IsValid)
            {
                using (var db = new ToDoDbContext())
                {
                    var entityToEdit = db.Tasks.FirstOrDefault(t => t.Id == edittedTask.Id);
                    entityToEdit.Title = edittedTask.Title;
                    entityToEdit.Comments = edittedTask.Comments;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            else
            {
                ViewData["Error"] = "Leaving empty title or comment is not allowed!";
                if (string.IsNullOrWhiteSpace(edittedTask.Title))
                {
                    ViewData["TitleError"] = "bg-danger";
                }

                if (string.IsNullOrWhiteSpace(edittedTask.Comments))
                {
                    ViewData["CommentsError"] = "bg-danger";
                }

                return View();
            }
        }
    }
}