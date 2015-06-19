using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalVariablesExample.Data
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Body { get; set; }

        [Required]
        public virtual ICollection<Post> Posts { get; set; }

        public Comment()
        {
            Posts = new List<Post>();
        }
    }
}
