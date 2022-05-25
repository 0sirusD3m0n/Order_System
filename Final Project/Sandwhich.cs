using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Sandwhich
    {
        // constructors
        public Sandwhich()
        {

        }
        public Sandwhich(string iName, string iMeat, string iCheese, char iLettuce, char iTomato, char iOnion)
        {
            name = iName;
            meat = iMeat;
            cheese = iCheese;
            lettuce = iLettuce;
            tomato = iTomato;
            onion = iOnion;
        }
        // properties
        public string name { get; set; }
        public string meat { get; set; } // type of meat
        public string cheese { get; set; } // type of cheese
        public char lettuce { get; set; } // must be either N or Y
        public char tomato { get; set; } // must be either N or Y
        public char onion { get; set; } // must be either N or Y
    }
}
