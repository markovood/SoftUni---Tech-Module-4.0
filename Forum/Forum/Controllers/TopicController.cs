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
    public class TopicController : Controller
    {
        private readonly ForumDbContext db;

        public TopicController(ForumDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var topic = db.Topics
                .Include(t => t.Author)
                .Include(t => t.Category)
                .Include(t => t.Comments)
                .ThenInclude(c => c.Author)
                .Where(t => t.Id == id)
                .FirstOrDefault();

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            List<string> categoryNames = this.db.Categories.Select(c => c.Name).ToList();

            ViewData["CategoryNames"] = categoryNames;

            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(string categoryName, Topic topic)
        {
            if (ModelState.IsValid)
            {
                topic.CreatedDate = DateTime.Now;
                topic.LastUpdatedDate = DateTime.Now;

                string authorId = this.db.Users
                    .Where(u => u.UserName == User.Identity.Name)
                    .First()
                    .Id;
                topic.AuthorId = authorId;

                if (!this.db.Categories.Any(c => c.Name == categoryName))
                {
                    return View(topic);
                }

                int categoryId = this.db.Categories.SingleOrDefault(c => c.Name == categoryName).Id;
                topic.CategoryId = categoryId;

                this.db.Topics.Add(topic);
                this.db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var topic = this.db.Topics
                .Include(t => t.Author)
                .SingleOrDefault(t => t.Id == id);

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Delete(int id)
        {
            var topic = this.db.Topics
                .Include(t => t.Author)
                .SingleOrDefault(t => t.Id == id);

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            this.db.Topics.Remove(topic);
            this.db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var topic = this.db.Topics
                .Include(t => t.Author)
                .Include(t => t.Category)
                .SingleOrDefault(t => t.Id == id);

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (!topic.IsAuthor(User.Identity.Name))
            {
                return Forbid();
            }

            List<string> categoryNames = this.db.Categories.Select(c => c.Name).ToList();
            ViewData["CategoryNames"] = categoryNames;

            return View(topic);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(string categoryName, Topic edittedTopic)
        {
            if (ModelState.IsValid)
            {
                var topicToEdit = this.db.Topics
                        .Include(t => t.Author)
                        .SingleOrDefault(t => t.Id == edittedTopic.Id);

                if (topicToEdit == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                topicToEdit.Title = edittedTopic.Title;
                topicToEdit.Description = edittedTopic.Description;

                int categoryId = this.db.Categories.SingleOrDefault(c => c.Name == categoryName).Id;
                topicToEdit.CategoryId = categoryId;

                topicToEdit.LastUpdatedDate = DateTime.Now;

                this.db.SaveChanges();

                return RedirectToAction("Index", "Home"); 
            }

            return View(edittedTopic);
        }
    }
}