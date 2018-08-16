using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._4._12
{
    class CoachingTest
    {
        static void Main(string[] args)
        {
            Coaching coaching1 = new Coaching("Defence", 21, "ejeje", 200.00m);

            coaching1.DisplayDetails(coaching1);
            Console.ReadLine();           
        }
    }
}
