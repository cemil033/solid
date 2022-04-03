using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SOLID
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public static class IsTaste
    {
        public static bool Taste()
        {            
            return true;
        }
    }
    public static class EatKek
    {
        public static void Eat()
        {
            if (IsTaste.Taste())
                Console.WriteLine("Delicious");
            else
                Console.WriteLine("Tasteless");
        }
    }

}
