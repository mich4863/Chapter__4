using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._4._12
{
    class Coaching
    {
        public Coaching(string type, int numberOfPlayers, string classTimings, decimal charges)
        {
            Type = type;
            NumberOfPlayers = numberOfPlayers;
            ClassTimings = classTimings;
            Charges = charges;
        }

        public string Type
        {
            get;
            set;
        }

        public int NumberOfPlayers
        {
            get;
            set;
        }

        public string ClassTimings
        {
            get;
            set;
        }

        public decimal Charges
        {
            get;
            set;
        }

        public void DisplayDetails(Coaching coaching)
        {
            Console.WriteLine($"Type: {Type} \nNumber of players: {NumberOfPlayers} \nClasstiming: {ClassTimings} \nCharges: {Charges:C}");
        }  
    }
}
