﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.BaseClasses.Fish
{
    /// <summary>
    /// Freshwater Catfish - 
    /// </summary>
    public class Catfish : LiveFish
    {
        /// <summary>
        /// Create new instance of a Live Catfish
        /// </summary>
        public Catfish()
        {
            ScientificName = "";
            CommonName = "Catfish";
        }
    }
}
