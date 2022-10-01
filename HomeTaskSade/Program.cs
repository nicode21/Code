using System;

namespace HomeTaskSade
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 24;

            int count = 0;

            

            for (int i = 1; i <= n; i++)
            {
                if (n%i==0) {
                    count++;
                }
                
            }
            //if (count == 2) { Console.WriteLine("Sade ededdir");
            //}
            //else { Console.WriteLine("Murekkeb ededdir"); 
            //}

           string result =count == 2 ? "sade ededdir" : "murekkeb ededdir";

            Console.WriteLine(result);
        }
    }
}
