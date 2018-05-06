using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assi_Final_Web.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Address { get; set; }
        public string UserType { get; set; }
        public string Email { get; set; }
        public int PhoneNo { get; set; }
    }
}