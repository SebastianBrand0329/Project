using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public abstract class Products
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public float Tax { get; set; }

        public abstract decimal ValueToPay();

        public override string ToString()
        {
            return $"{Id}  {Description}" +
                $"\n\tPrice.....: {$"{Price}",18}" +
                $"\n\tTax.......: {$"{Tax}",18}";
        }
    }
}
