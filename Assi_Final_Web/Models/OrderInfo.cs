using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assi_Final_Web.Models
{
    public class OrderInfo
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Cart Cart { get; set; }
    }
}