using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Inheritance_in_Class
{
    class Rectangle
    {
        int Length, Breadth, Perimeter;
        protected int Area;
        public virtual void AcceptData()
        {
            Console.WriteLine("Enter the Length of a Rectangle = ");
            this.Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of a Rectangle = ");
            this.Breadth = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void Calculate()
        {
            this.Area = this.Length * this.Breadth;
            this.Perimeter = 2 * (this.Length + this.Breadth);
        }
        public override string ToString()
        {
            string Output = "The Area of the Rectangle = " + this.Area + "\nThe Perimeter of the Rectangle = " +
            this.Perimeter;
            return Output;
        }
        class Cuboid : Rectangle
        {
            int Height, volume;
            public override void AcceptData()
            {
                base.AcceptData();
                Console.WriteLine("Enter the Height of the Cuboid = ");
                this.Height = Convert.ToInt32(Console.ReadLine());
            }
            public override void Calculate()
            {
                base.Calculate();
                this.volume = base.Area * this.Height;
            }
            public override string ToString()
            {
                string Output = "The volume of the Cuboid is = " + this.volume;
                return Output;
            }
        }

        class Example_04
        {
            static void Main()
            {
                Cuboid C1 = new Cuboid();
                C1.AcceptData();
                C1.Calculate();

                Console.WriteLine(C1);
                Console.ReadKey();

                //Rectangle R1 = new Rectangle();
                //R1.AcceptData();
                //R1.Calculate();

                //Console.WriteLine(R1);
                //Console.ReadKey();
            }
        }
    }
}
