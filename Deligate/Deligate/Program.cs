using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligate
{
    public delegate int Add(int a, int b);
    public delegate int Add1(int a, int b, int c);
    // Creating Delegate - AccessModifier Delegate ReturnType MethodName (Paramenters)
    internal class Program
    {
        public int Arthemetic(int a, int b) 
        {
            return a + b;
        }
        public int Plus(int a, int b, int c)
        {
            return a + b + c;
        }

        public delegate string GreethingsDelegate(string name);
        public delegate int AddDelegate(int a, int b);

        static void Main(string[] args)
        {
            Program P = new Program();
            Add Obj = new Add(P.Arthemetic); // Creating Delegate Object - DelegateName DelegateObjectName = new DelegateName (Obj.Funtion Pointer);
            Add1 Obj1 = new Add1(P.Plus);
            int d = Obj1(5, 6, 8);
            int c = Obj(4, 6); // Invoking the Object - DelegateObject(Parameters);
            Console.WriteLine(c);
            Console.WriteLine(d);

                        //***************   Annonymous Methids      ***********//

            GreethingsDelegate Dobj = delegate (string name) // using delegate keyword passing parameters
            {
                return "Hello " + name + " Good Morning";
            };
                string str = Dobj("Ravi");
                Console.WriteLine(str);
            
            AddDelegate Dobj1 = delegate (int a, int b) // using delegate keyword passing parameters
            {
                return a + b; // logic 
            };
            int e = Dobj1(4, 5);
            Console.WriteLine(e);

            //***************     Lamda Expressions   ***********//

            GreethingsDelegate Obj3 = (name) => 
            //removing delegate keyword & parameter type as they were defined while creating delegate
            { 
                return "Hello " + name + " Good Morning ";
            };
            string st = Obj3(" Amma ");
            Console.WriteLine(st);

            AddDelegate obj4 = (a,b) =>
            {
                return a + b;
            };
            int f = obj4(8,12);
            Console.WriteLine(f);
        }
    }
}
