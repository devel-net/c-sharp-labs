using System;

namespace ConsoleApps
{
    class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Метод Display у базовому класі");
        }
    }

    sealed class SealedClass : BaseClass
    {
        public override void Display()
        {
            Console.WriteLine("Метод Display у запечатаному класі");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Display()
        {
            Console.WriteLine("Метод Display у похідному класі");
        }
    }

    class Program2
    {
        static void Main()
        {
            BaseClass baseObj = new BaseClass();
            BaseClass derivedObj1 = new DerivedClass();
            BaseClass derivedObj2 = new SealedClass();

            baseObj.Display();
            derivedObj1.Display();
            derivedObj2.Display();

            Console.ReadLine();
        }
    }
}