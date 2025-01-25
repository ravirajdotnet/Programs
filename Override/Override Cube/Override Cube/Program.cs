using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Cube
{
    class Square
    {
        int Length, Perimeter;
        protected int Area;
        public virtual void AccetpData()
        {
            Console.WriteLine("Enter the Length of the Square");
            this.Length = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Calculate()
        {
            this.Area = this.Length * this.Length;
            this.Perimeter = 4 * this.Area;
        }

        public override string ToString()
        {
            string Output = "Area of Square = " + this.Area;
            return Output;

        }
    }
    class Cube : Square
    {
        int Volume;
        public override void AccetpData()
        {
            base.AccetpData();
            Console.WriteLine("Enter the Height of the Square");
            this.Volume = Convert.ToInt32(Console.ReadLine());
        }

        public override void Calculate()
        {
            base.Calculate();
            this.Volume = base.Area * 4;
        }

        public override string ToString()
        {
            string Output = "Volume of the Cube = " + this.Volume;
            return Output;

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Square S1 = new Square();
                S1.AccetpData();
                S1.Calculate();
                Console.WriteLine(S1);

                Cube C1 = new Cube();
                C1.AccetpData();
                C1.Calculate();
                Console.WriteLine(C1);

                Console.ReadKey();


            }
        }
    }
}
