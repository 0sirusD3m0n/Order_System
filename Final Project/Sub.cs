using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
     public class Sub : Sandwhich
    {
        public Sub()
        {

        }

        public Sub(string name, string iMeat, string iCheese, char iLettuce, char iTomato, char iOnion, char iPickle, char iMayo, char iMustard, char iVinaigrette)
            : base(name, iMeat, iCheese, iLettuce, iTomato, iOnion)
        {
            pickle = iPickle;
            mayo = iMayo;
            mustard = iMustard;
            vinaigrette = iVinaigrette;
        }

        public char pickle { get; set; }
        public char mayo { get; set; }
        public char mustard { get; set; }
        public char vinaigrette { get; set; }
    }
}
