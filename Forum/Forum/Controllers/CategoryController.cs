using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Data;
using Forum.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Forum.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ForumDbContext db;

        public CategoryController(ForumDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(Category category)
        {
            string authorId = this.db.Users.SingleOrDefault(u => u.UserName == this.User.Identity.Name).Id;
            category.AuthorId = authorId;

            if (ModelState.IsValid)
            {
                this.db.Categories.Add(category);
                this.db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(category);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Category category = this.db.Categories
                .Include(t => t.Author)
                .Include(t => t.Topics)
                .ThenInclude(c => c.Author)
                .SingleOrDefault(c => c.Id == id);

            if (category == null)
            {
                return RedirectToAction("Index", "Home");
            }

            List<Category> categories = this.db.Categories
                .Include(c => c.Topics)
                .ToList();

            ViewData["Categories"] = categories;
            return View(category);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Category category = this.db.Categories.Find(id);

            if (category == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(category);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(Category edittedCategory)
        {
            if (ModelState.IsValid)
            {
                Category categoryToEdit = this.db.Categories.SingleOrDefault(c => c.Id == edittedCategory.Id);
                if (categoryToEdit == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                categoryToEdit.Name = edittedCategory.Name;
                this.db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(edittedCategory);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Category categoryToDelete = this.db.Categories.SingleOrDefault(c => c.Id == id);

            if (categoryToDelete == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(categoryToDelete);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Delete(int id)
        {
            Category categoryToDelete = this.db.Categories.SingleOrDefault(c => c.Id == id);
            if (categoryToDelete != null)
            {
                this.db.Categories.Remove(categoryToDelete);
                this.db.SaveChanges();
            }

            return RedirectPermanent("/");
        }
    }
}