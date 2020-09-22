using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace saadMehmood12.Models
{
    public class saad
    {
        public int ID { get; set; }
        public string title { get; set; }
        public DateTime realeaseDate { get; set; }
        public string theme { get; set; }
        public decimal price { get; set; }

     
    }

    public class saadDBContext : DbContext
    {
        public DbSet<saad> Movies { get; set; }
    }

    public class DbSet<T>
    {
    }

    public class DbContext
    {
    }
    public class index { }
}
}