using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SOLID
{
    public interface ISweety
    {
        public bool IsEatable();
        public bool IsDrinkable();
    }
    public interface IMeal
    {
        public bool IsSalty();
        public bool IsDrinkable();
    }
    public abstract class Food
    {
        public string? Name { get; set; }
    }
    public class Chocolate : Food, ISweety
    {
        public bool IsDrinkable()
        {
            throw new NotImplementedException();
        }

        public bool IsEatable()
        {
            throw new NotImplementedException();
        }
    }
    public class Pizza : Food, IMeal
    {
        public bool IsDrinkable()
        {
            throw new NotImplementedException();
        }

        public bool IsSalty()
        {
            throw new NotImplementedException();
        }
    }
}
