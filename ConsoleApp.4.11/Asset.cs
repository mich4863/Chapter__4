using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._4._11
{
    class Asset
    {
        private string asset_name;
        private decimal asset_value;
        private decimal depreciation_rate;

        public Asset(string asset_name, decimal asset_value, decimal depreciation_rate)
        {
            Asset_name = asset_name;
            Asset_value = asset_value;
            Depreciation_rate = depreciation_rate;
        }

        public string Asset_name
        {
            get
            {
                return asset_name;
            }

            set
            {
                asset_name = value;
            }
        }

        public decimal Asset_value
        {
            get
            {
                return asset_value;
            }

            set
            {
                if(value > 0.0m)
                {
                    asset_value = value;
                }
            }
        }

        public decimal Depreciation_rate
        {
            get
            {
                return depreciation_rate;
            }

            set
            {
                if(value > 0.0m)
                {
                    depreciation_rate = value;
                }
            }
        }

        public decimal IncreaseBy5Percentage()
        {
            decimal result = Asset_value * 1.05m;
            return result;
        }
        
    }
}
