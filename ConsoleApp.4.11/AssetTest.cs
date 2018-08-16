using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._4._11
{
    class AssetTest
    {
        static void Main(string[] args)
        {
            Asset asset1 = new Asset("name1", 23.99m, 42.89m);
            Asset asset2 = new Asset("name2", 10.00m, 20.00m);

            Console.WriteLine($"Asset1 value: {asset1.Asset_value} Rate: {asset1.Depreciation_rate}");
            Console.WriteLine($"Asset2 value: {asset2.Asset_value} Rate: {asset2.Depreciation_rate}");
            Console.ReadLine();

            
            Console.WriteLine($"Asset1 increase by 5 percentage: {asset1.IncreaseBy5Percentage()}");
            Console.WriteLine($"Asset2 increase by 5 percentage: {asset2.IncreaseBy5Percentage()}");
            Console.ReadLine();
        }
    }
}
