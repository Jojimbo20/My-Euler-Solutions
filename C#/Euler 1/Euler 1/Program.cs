using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Euler1
{
    public static void Main(string[] args)
    {
        int max = 1000;
        int sum = 0;

        //Looper that counts up to 1000
        for (int i = 0; i < max; i++)
        {
            //Check to see if it's divisible by 3 or 5
            if (i % 3 == 0 || i % 5 == 0)
            {
                Console.WriteLine("{0}", i);
                sum = (sum + i);
            }
        }
        Console.WriteLine("Solution reached: {0}", sum);
        Console.ReadLine();
    }
}