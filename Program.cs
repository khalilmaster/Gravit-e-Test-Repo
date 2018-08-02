using System;

namespace gravit_e_test
{
    class Program
    {
        static void Main()
        {

            for (int i = 1; i <= 75; i++)
            {
                string s = (i % 5 == 0) ? "HelloWorld" : "Hello";
                Console.WriteLine((i % 3 == 0) ? s : ((i % 5 == 0) ? "World" : i.ToString()));
            }

            Console.WriteLine("Press to any key to terminate de program");
            Console.ReadKey();
        }
    }
}
