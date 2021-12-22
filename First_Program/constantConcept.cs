using System;

namespace First_Program
{
    public class ConstantConcept
    {
        public static void Main(string[] args) {


            /**
              * constants immutable values which are known at compile time
              * and do not change 
              * people cannot change the value of that 
              */


            int a = 22;
            String a1 = Convert.ToString(a);
            Console.WriteLine(a1.GetType());
            Console.WriteLine(a.GetType());


        }
    }
}
