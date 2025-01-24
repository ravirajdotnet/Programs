using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inheritance //B-->A, C-->A 
{
    internal class A
    {
        public void Kakinada()
        {
            Console.WriteLine("Welcome To Kakinada");
        }
    }
    class B : A
    {
        public void Samalkota()
        {
            Console.WriteLine("Welcome to Samalkot");
        }
    }
    class C : A
    {
        public void Rajahmundry()
        {
            Console.WriteLine("Welcome to Rajahmundry");
        }
     
        static void Main(string[] args)
        {
            B obj = new B();
            C obj1 = new C();
            obj1.Kakinada();
            obj.Samalkota();
            obj.Kakinada();
            obj1.Rajahmundry();
        }

    }
}
