using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.enums.FishProperties
{

    /// <summary>
    /// Determines whether the fish is peaceful or agressive
    /// </summary>
    public enum FishTemperament
    {
        /// <summary>
        /// Peaceful - Perfect Community Fish
        /// </summary>
        PEACEFUL = 0,

        /// <summary>
        /// Semi-Agressive - Fish may be agressive to its own kind or if bothered
        /// </summary>
        SEMI_AGRESSIVE = 1,

        /// <summary>
        /// Agressive - Fish will actively seek out fights, and/or bully other fish
        /// </summary>
        AGRESSIVE = 2
    }
}
