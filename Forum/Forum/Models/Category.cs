using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Category
    {
        public Category()
        {
            this.Topics = new List<Topic>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category name")]
        public string Name { get; set; }

        [ForeignKey("Author")]
        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }

        public List<Topic> Topics { get; set; }

        [NotMapped]
        public int NumberTopics => this.Topics.Count;

        public bool IsAuthor(string id)
        {
            return this.Author.UserName.Equals(id);
        }
    }
}
