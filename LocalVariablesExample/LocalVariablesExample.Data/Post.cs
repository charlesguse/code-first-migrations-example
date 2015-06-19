using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LocalVariablesExample.Data
{
    public class Post
    {
        public int Id { get; set; }
        [Required, MaxLength(4, ErrorMessage = "Too long")]
        public string Body { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        [Required]
        public string Title { get; set; }

        public Post()
        {
            // ReSharper disable once DoNotCallOverridableMethodsInConstructor
            Comments = new List<Comment>();
        }
    }
}
