using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barsovan_Narcisa_Lab5.Models
{
    public class Class
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
