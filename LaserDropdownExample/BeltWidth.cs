using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaserDropdownExample
{
    public class BeltWidth
    {
        //A dictionary was used here instead of a simple list so that the 'value'
        //of the 'key/value' pair can be used for the number of times the graphic needs to be repeated.
        public readonly Dictionary<string, int> BeltWidths = new Dictionary<string, int>()
        {
            {"24", 2 },
            {"36", 3 },
            {"42", 3 },
            {"48", 4 },
            {"54", 4 },
            {"60", 5 },
            {"66", 5 },
            {"72", 6 },
            {"84", 6 },
            {"90", 7 },
            {"96", 8 },
            {"102", 8 }
        };       
    }
}
