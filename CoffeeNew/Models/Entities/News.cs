using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace CoffeeNew.Models.Entities
{
    public class News
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }

        public string AuthorId { get; set; }

        public User Author { get; set; }
        public DateTime CreateDate { get; set; }

        public bool IsActive { get; set; }

    }
}
