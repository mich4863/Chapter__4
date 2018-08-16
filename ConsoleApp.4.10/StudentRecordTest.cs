using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._4._10
{
    class StudentRecordTest
    {
        static void Main(string[] args)
        {
            Student student = new Student("1", "Finn", 7, 10, 4);

            decimal test = student.GetAggregate();
            decimal test2 = student.GetPercentage();

            Console.WriteLine(test);
            Console.WriteLine(test2);
            Console.ReadLine();
        }
    }
}
