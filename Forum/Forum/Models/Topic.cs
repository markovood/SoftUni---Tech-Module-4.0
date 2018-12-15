namespace Forum.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Topic
    {
        public Topic()
        {
            this.Comments = new List<Comment>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public string Description { get; set; }

        [Display(Name = "Date created")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Last updated date")]
        public DateTime LastUpdatedDate { get; set; }

        [ForeignKey("Author")]
        public string AuthorId { get; set; }
        public virtual ApplicationUser Author { get; set; }

        public List<Comment> Comments { get; set; }

        [NotMapped]
        [Display(Name = "Comments")]
        public int NumberComments => this.Comments.Count;

        public bool IsAuthor(string id)
        {
            return this.Author.UserName.Equals(id);
        }
    }
}
