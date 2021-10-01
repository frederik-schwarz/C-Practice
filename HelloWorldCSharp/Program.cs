using System;

namespace HelloWorldCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               var key = "true";
               var j = Convert.ToBoolean(key);
                Console.WriteLine(j);
            }
            catch (Exception ex)
            {
                Console.WriteLine("there was as erro");
            }
            var number = 293;
            var i = Convert.ToString(number);
            Console.WriteLine(i);

        }

    }
}
