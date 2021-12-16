using System;

namespace First_Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int x = 10;
            int age = 33;
            double height = 5.7;
            String name = "Jeyhun";
            Boolean flag = true;
            char gender = 'm';
            long number = 12345678;
            short stairs = 3;
            char sign = '@';


            Console.WriteLine(x);
            Console.WriteLine(x + 10);

            Console.WriteLine("my age is: " + age);
            Console.WriteLine("my height is: " + height);
            Console.WriteLine("my name is: " + name);
            Console.WriteLine(flag);
            Console.WriteLine("gender: " + gender);
            Console.WriteLine("number " + number);
            Console.WriteLine("number of stairs = " + stairs);

            Console.WriteLine("hey");

            Console.WriteLine(sign + "" + name);
            //-----------------------------------------------------------------------

            /**
             * constants immutable values which are known at compile time
             * and do not change 
             * people cannot change the value of that 
             */

            const int a = 40;
            const int b = 50;

            Console.WriteLine(a + b + " constant value");
            //------------------------------------------------------------------------

            /**
             * type casting = converting a value to a different data type 
             *                useful when we accept user input (string)
             *                Different data type can do different things
             * 
             */

            //here if double value 3.6 it will convert to 6
            //3.4 will convert to 3
            double d = 3.4;
            int b1 = Convert.ToInt32(d);
            Console.WriteLine(b1);

            int a1 = 22;
            double dd = Convert.ToDouble(a1);

            int e = 5758;
            string e1 = Convert.ToString(e);

            string s1 = "true";
            Boolean bb = Convert.ToBoolean(s1);

            //get type method will tell you exactly data type 
            Console.WriteLine(d.GetType());
            Console.WriteLine(b1.GetType());
            Console.WriteLine(stairs.GetType());
            Console.WriteLine(dd);
            Console.WriteLine("converted from int to string " + e1);
            Console.WriteLine(e1.GetType());
            Console.WriteLine(bb);
            Console.WriteLine(bb.GetType());


            Console.WriteLine("Hello World!");
            Console.WriteLine("solved git repo issues");
        }
    }
}
