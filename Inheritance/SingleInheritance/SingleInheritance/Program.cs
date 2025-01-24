using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_single // B --> A
{
    public class A
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
    public class B : A
    {
        public void Bark()
        {
            Console.WriteLine("Barking");
        }
        static void Main(string[] args)
        {
            B obj = new B();
            obj.Bark();
            obj.Eat();
        }
    }
}
// Output: Eating Barking