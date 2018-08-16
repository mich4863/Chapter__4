using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._4._10
{
    class Student
    {
        private string id;
        private string name;
        private decimal score1;
        private decimal score2;
        private decimal score3;

        public Student(string id, string name, decimal score1, decimal score2, decimal score3)
        {
            Id = id;
            Name = name;
            Score1 = score1;
            Score2 = score2;
            Score3 = score3;
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public decimal Score1
        {
            get
            {
                return score1;
            }

            set
            {
                if(value > 0.0m)
                {
                    score1 = value;
                }
            }
        }

        public decimal Score2
        {
            get
            {
                return score2;
            }

            set
            {
                if(value > 0.0m)
                {
                    score2 = value;
                }
            }
        }

        public decimal Score3
        {
            get
            {
                return score3;
            }

            set
            {
                if(value > 0.0m)
                {
                    score3 = value;
                }
            }
        }

        public decimal GetAggregate()
        {
            decimal aggregate = Score1 + Score2 + Score3;
            return aggregate;
        }

        public decimal GetPercentage()
        {
            decimal sum = Score1 + Score2 + Score3;
            decimal percentage = sum / 50 * 100;
            return percentage;
        }
    }
}
