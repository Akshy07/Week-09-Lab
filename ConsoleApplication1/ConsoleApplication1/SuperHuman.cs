using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Akshay Patel
 * Date: 11th July, 2017
 * Description: THis is the SuperHuman sub Class.
 * Added Private Initialize Method.
 * Added Public AddPower Method.
 */

namespace Week09
{
    /// <summary>
    /// This is the SuperHuman Sub Class.
    /// It is inherited from the Human SuperClass. 
    /// </summary>
    public class SuperHuman : Human
    {
        //Private Fields
        private List<Power> _powers;

        //Public Properties
        public List<Power> Powers
        {
            get
            {
                return this._powers;
            }
        }

        //Constructor
        public SuperHuman(string name) : base(name)
        {
            this._initialize();
        }
        
        //Private Method

        /// <summary>
        /// THis method initializes and assigns default values of Class Fields.
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();
        }

        //Public Method

        ///<summary>
        ///This method adds a Power to the Power List
        ///</summary>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
    }
}
