using System;

namespace HelloWorldCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.loop();

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
        public void loop()
        {
            for ( int i = 0; i < 100; i++ )
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("superbang");
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("super");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("bang");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
