using System.ComponentModel.DataAnnotations;

namespace LocalVariablesExample.Data
{
    public class Post
    {
        public int Id { get; set; }
        [Required, MaxLength(4, ErrorMessage = "Too long")]
        public string Body { get; set; }

        public Post()
        {
        }
    }
}
