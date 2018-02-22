using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xamFormsApp
{
    public class User
    {
        private readonly string Url = "http://lorempixel.com/100/100/people/";
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get { return Url + Id; } }
    }
}
