using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Project
{
    public class Hamburger : Sandwhich
    {
        public Hamburger()
        {

        }

        public Hamburger(string name, string iMeat, string iCheese, char iLettuce, char iTomato, char iOnion, char iBacon, char iKetchup, char iMustard, char iMayo) 
            : base(name, iMeat, iCheese, iLettuce, iTomato, iOnion)
        {
            bacon = iBacon;
            ketchup = iKetchup;
            mustard = iMustard;
            mayo = iMayo;
        }

        public char bacon { get; set; }
        public char ketchup { get; set; }
        public char mustard { get; set; }
        public char mayo { get; set; }
    }
}
