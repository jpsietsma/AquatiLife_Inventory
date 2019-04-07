using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.enums.PurchaseOptions
{
    
    /// <summary>
    /// Represents the stores where fish were purchased from, or if was a gift
    /// </summary>
    public enum Locations
    {
        /// <summary>
        /// Petco - Oneonta, NY
        /// </summary>
        PETCO = 0,

        /// <summary>
        /// Petsmart - Binghamton, NY
        /// </summary>
        PET_SMART = 1,

        /// <summary>
        /// Sagamore (Gail) - Walton, NY
        /// </summary>
        SAGAMORE_PETS = 2,

        /// <summary>
        /// Livingston Animal Kingdom - Binghamton, NY
        /// </summary>
        LIVINGSTON_ANIMAL_KINGDOM = 3,

        /// <summary>
        /// Creature Comforts - Binghamton, NY
        /// </summary>
        CREATURE_COMFORTS = 4,

        /// <summary>
        /// Fish was gifted from someone for a birthday or holiday
        /// </summary>
        GIFT = 5
    }  
}
