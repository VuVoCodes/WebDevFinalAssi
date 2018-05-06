using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assi_Final_Web.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescrip { get; set; }
        public string LongDescrip { get; set; }
        public int Price { get; set; }
        public string Manufacturor { get; set; }
        public Category Category { get; set; }
    }
}