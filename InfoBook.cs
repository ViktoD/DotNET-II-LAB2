using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2
{
   [Keyless]
    public class InfoBook
    {
        
        public int BookID { get; set; }
        public int TicketID { get; set; }
        public DateTime DateTakeBook { get; set; }
        public DateTime? DateReturnBook { get; set; }

        public Ticket Ticket { get; set; } = null!;

        public Book Book { get; set; } = null!;
    }
}
