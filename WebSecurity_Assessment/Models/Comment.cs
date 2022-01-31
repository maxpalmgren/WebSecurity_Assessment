using System.ComponentModel.DataAnnotations;

namespace WebSecurity_Assessment.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
    }
}
