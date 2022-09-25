using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2
{
    
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int Price { get; set; }
        public int YearPublished { get; set; }

        
        
    }
}
