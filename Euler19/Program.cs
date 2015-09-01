using System;

namespace Euler19
{
    class Program
    {
        static void Main(string[] args)
        {
            uint count = 0;
            for(int y =  1901; y <= 2000; y++)
            {
                for(int m = 1; m <= 12; m++)
                {
                    DateTime d = new DateTime(y, m, 01);
                    if(d.DayOfWeek == DayOfWeek.Sunday)
                        count++;
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();  
        }
    }
}
