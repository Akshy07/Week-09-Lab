using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09

/* Name: Akshay Patel
* Date: 11th July, 2017
* Description: THis is the driver class.
* Instantiated an object of type SuperHuman.
* Added a power to the superHuman object and displayed it.
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Captain America");
            superHuman.Powers.Add(new Power("Shield", 50));
            superHuman.DisplayPowers();
        }
    }
}
