using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SOLID
{
    public abstract class Sweet
    {
        public string Name { get; set; }

        public double Price { get; set; }

        protected Sweet(string name, double price)
        {
            Name = name;
            Price=price;
        }

        public abstract bool IsTaste();
    }

    public class Cookie : Sweet
    {
        public Cookie(string name, double price) : base( name, price) { }

        public override bool IsTaste() => true;
    }

    public class Cake : Sweet
    {
        public Cake(string name, double price) : base(name, price) { }

        public override bool IsTaste() => true;
    }
}
