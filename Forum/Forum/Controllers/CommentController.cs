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
    public class CommentController : Controller
    {
        private readonly ForumDbContext db;

        public CommentController(ForumDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        [Authorize]
        [Route("/Topic/Details/{id}/Comment/Create")]
        public IActionResult Create(int id)
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        [Route("/Topic/Details/{TopicId}/Comment/Create")]
        public IActionResult Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                comment.CreatedDate = DateTime.Now;
                comment.LastUpdatedDate = DateTime.Now;

                string authorId = this.db.Users
                    .SingleOrDefault(u => u.UserName == User.Identity.Name)
                    .Id;

                comment.AuthorId = authorId;

                Topic topic = this.db.Topics.Find(comment.TopicId);
                topic.LastUpdatedDate = DateTime.Now;

                this.db.Comments.Add(comment);
                this.db.SaveChanges();

                return Redirect($"/Topic/Details/{comment.TopicId}");
            }

            return View(comment);
        }

        [HttpGet]
        [Authorize]
        [Route("/Topic/Details/{TopicId}/Comment/Edit/{id}")]
        public IActionResult Edit(int? topicId, int? id)
        {
            if (id == null)
            {
                return RedirectPermanent($"/Topic/Details/{topicId}");
            }

            Comment comment = this.db.Comments
                .Include(c => c.Author)
                .Include(c => c.Topic)
                .ThenInclude(t => t.Author)
                .SingleOrDefault(c => c.CommentId == id);

            if (comment == null)
            {
                return RedirectPermanent($"/Topic/Details/{topicId}");
            }

            return View(comment);
        }

        [HttpPost]
        [Authorize]
        [Route("/Topic/Details/{TopicId}/Comment/Edit/{id}")]
        public IActionResult Edit(Comment edittedComment)
        {
            if (ModelState.IsValid)
            {
                Comment commentToEdit = this.db.Comments
                    .Include(c => c.Author)
                    .SingleOrDefault(c => c.CommentId == edittedComment.CommentId);

                if (edittedComment == null)
                {
                    return RedirectPermanent($"/Topic/Details/{edittedComment.TopicId}");
                }

                commentToEdit.Description = edittedComment.Description;
                commentToEdit.LastUpdatedDate = DateTime.Now;

                Topic topic = this.db.Topics.Find(edittedComment.TopicId);
                topic.LastUpdatedDate = DateTime.Now;

                this.db.SaveChanges();

                return RedirectPermanent($"/Topic/Details/{edittedComment.TopicId}");
            }

            return View(edittedComment);
        }

        [HttpGet]
        [Authorize]
        [Route("/Topic/Details/{TopicId}/Comment/Delete/{id}")]
        public IActionResult Delete(int topicId, int? id)
        {
            if (id == null)
            {
                return RedirectPermanent($"/Topic/Details/{topicId}");
            }

            Comment comment = this.db.Comments
                .Include(c => c.Author)
                .Include(c => c.Topic)
                .ThenInclude(t => t.Author)
                .SingleOrDefault(c => c.CommentId == id);

            if (comment == null)
            {
                return RedirectPermanent($"/Topic/Details/{topicId}");
            }

            return View(comment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Topic/Details/{TopicId}/Comment/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            Comment commentToDelete = this.db.Comments.Find(id);

            if (commentToDelete != null)
            {
                Topic topic = this.db.Topics.Find(commentToDelete.TopicId);
                topic.LastUpdatedDate = DateTime.Now;

                this.db.Comments.Remove(commentToDelete);
                this.db.SaveChanges();
            }

            return Redirect($"/Topic/Details/{commentToDelete.TopicId}");
        }
    }
}