using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Akshay Patel
 * Date: 11th July, 2017
 * Description: THis is the new Power Data Type.
 * Add a custom constructor to assign Name and Rank.
 */

namespace Week09
{
    /// <summary>
    /// The Power class contains the data and structure of the each Super Power.
    /// </summary>
    public class Power
    {
        //Public Properties
        public string Name { get; set; }
        public int Rank { get; set; }

        //Constructor ----------------------------------

        /// <summary>
        /// THis is the Power Constructor.
        /// Takes two parameters - name(string) - rank(int)
        /// </summary>
        
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
    }
}
