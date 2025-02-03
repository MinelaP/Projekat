using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Projekat.MVVM.Models
{
 
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }  // Nova svojstva
        
  
            public override bool Equals(object obj)
            {
                if (obj is Product other)
                {
                    return Name == other.Name && Price == other.Price && ImageUrl == other.ImageUrl;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Name, Price, ImageUrl);
            }
        }
    }

