using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.enums.FishProperties
{
    /// <summary>
    /// Represents the method of giving birth for the fish
    /// </summary>
    public enum FishBirthType
    {
        /// <summary>
        /// Fish gives birth to live fry
        /// </summary>
        LIVE_BEARING = 0,

        /// <summary>
        /// Fish lays eggs and then those eggs hatch
        /// </summary>
        EGG_LAYING = 1,

        /// <summary>
        /// Any method of birth excluding live bearing and egg laying
        /// </summary>
        OTHER = 2
    }
}
