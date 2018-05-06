using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assi_Final_Web.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public List<Products>ProductList { get; set;}
    }
}