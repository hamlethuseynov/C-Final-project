﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    class Book
    {
        public Book()
        {
            orderitems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }

        
        public int Count { get; set; }

       
        public string Name { get; set; }


        public decimal Price { get; set; }

        public ICollection<OrderItem> orderitems { get; set; }
    }
}
