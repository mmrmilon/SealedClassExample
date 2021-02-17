using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    //public class Program : SealedClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.ReadLine();
    //    }
    //}
    //Error -> CS0509:'Program':cannot derive from sealed type 'SealedClass'

    public class Program
    {
        static void Main(string[] args)
        {
            //Create object of sealed class
            var obj = new SealedClass();
            int total = obj.Add(5, 3);
            Console.WriteLine("SealedClass Add -> " + total);
            int multiple = obj.Multiplication(2,3);
            Console.WriteLine("SealedClass -> CanBeInherited Multiplication -> " + multiple);

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Sealed class
    /// </summary>
    sealed class SealedClass : CanBeInherited
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public override int Multiplication(int x, int y)
        {
            return base.Multiplication(x, y) - 2;
        }
    }

    public class CanBeInherited 
    {
        public virtual int Multiplication(int x, int y)
        {
            return x * y;
        }
    }

    /// <summary>
    /// When you try to derive a class from sealed class compiler witll throw an error
    /// will throw an error CS0509:'WantToInheritSealedClass':cannot derive from sealed type 'SealedClass'
    /// </summary>
    //public class WantToInheritSealedClass : SealedClass
    //{ 
    //}
}
