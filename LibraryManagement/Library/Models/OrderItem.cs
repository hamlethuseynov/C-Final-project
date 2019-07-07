using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    class OrderItem
    {
        public int Id { get; set; }

        
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
        
        
        public int Count { get; set; }

        
        public decimal Price { get; set; }

        
        public DateTime ReturnDate { get; set; }

        
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
