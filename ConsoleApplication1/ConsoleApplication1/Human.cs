using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Akshay Patel
 * Date: 11th July, 2017
 * Description: THis is the Abstract Human Class.
 */

namespace Week09
{
    /// <summary>
    /// This is the Human Abstract Class.
    /// </summary>
    public abstract class Human
    {
        //Private Fields (Instance Variables)
        private string _name;

        //Public Properties
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        } 

        // Constructor ----------------------------------

        /// <summary>
        /// This is the cunstructor for the Human Abstract Class.
        /// </summary>
        public Human(string name)
        {
            this.Name = name;
        }
    }
}
