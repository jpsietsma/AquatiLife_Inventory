using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory
{
    namespace Enums
    {
        /// <summary>
        /// Represents what feeding category of fish
        /// </summary>
        public enum FishFeederType
        {
            /// <summary>
            /// Algae eater, janitors of the tank
            /// </summary>
            BOTTOM_FEEDER = 1,

            /// <summary>
            /// Eat flaked food like a normal fish
            /// </summary>
            NORMAL_FEEDER = 2,

            /// <summary>
            /// Eats other fish or some form of live meat food.
            /// </summary>
            CARNIVEROUS = 3,

            /// <summary>
            /// Other Feeder types, plants consume light for example
            /// </summary>
            OTHER_FEEDER = 4
        }
    }   
}
