using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MultiLevelInheritance // C --> B --> A
{
    public class A
    {

        public void Kakinada()
        {
            Console.WriteLine("Welcome to Kakinada");
        }
        class B : A
        {
            public void Samalkot()
            {
                Console.WriteLine("Welcome to Samalkot");
            }
        }
        class C :B
        {
            public void Rajahmundry() 
            {
                Console.WriteLine("Welcome to Rajahmundry");
            }
        }

        static void Main()
        {
            C obj = new C();
            obj.Rajahmundry();
            obj.Samalkot();
            obj.Kakinada();
            Console.ReadLine();

        }

    }
}