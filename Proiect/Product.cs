using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }

        public string toString()
        {
            return id.ToString() + " | " + name + " | Descriere: " + description + " Pret: " + price.ToString() + " lei";
        }
    }
}
