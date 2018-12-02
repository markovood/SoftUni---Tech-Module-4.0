using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new LibraryDbContext())
            {
                var books = db.Books.ToList();

                return View(books);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                using (var db = new LibraryDbContext())
                {
                    db.Books.Add(book);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            else
            {
                // Log error
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToEdit = db.Books.FirstOrDefault(b => b.Id == id);
                if (bookToEdit != null)
                {
                    return View(bookToEdit);
                }
                else
                {
                    // Log error message
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                using (var db = new LibraryDbContext())
                {
                    var bookToEdit = db.Books.FirstOrDefault(b => b.Id == book.Id);
                    bookToEdit.Author = book.Author;
                    bookToEdit.Title = book.Title;
                    bookToEdit.Price = book.Price;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            else
            {
                // Log error message
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToDelete = db.Books.FirstOrDefault(b => b.Id == id);
                if (bookToDelete != null)
                {
                    return View(bookToDelete);
                }
                else
                {
                    // Log error message
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToRemove = db.Books.FirstOrDefault(b => b.Id == book.Id);
                if (bookToRemove != null)
                {
                    db.Books.Remove(bookToRemove);
                    db.SaveChanges();
                }
                else
                {
                    // Log error message
                }
            }

            return RedirectToAction("Index");
        }
    }
}