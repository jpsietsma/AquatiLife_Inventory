﻿using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.BaseClasses.Fish
{
    /// <summary>
    /// Represents a live lobster
    /// </summary>
    public class Lobster : LiveFish
    {

        /// <summary>
        /// Represents a live lobster
        /// </summary>
        /// <param name="displayName">Human-Friendly name of lobster</param>
        /// <param name="fishCost">Cost of the lobster</param>
        /// <param name="time">DateTime the lobster was purchased</param>
        /// <param name="purchasedAt">PurchaseOptions.Location location where lobster was purchased</param>
        public Lobster(string displayName, double fishCost, DateTime time, Stores purchasedAt)
        {
            Name = displayName;
            PurchasePrice = fishCost;
            PurchaseDate = time;
            PurchaseLocation = purchasedAt;
            CommonName = "Lobster";
            ScientificName = "Procambarus clarkii";
            FishMinPH = 6.5;
            FishMaxPH = 7.2;

        }
    }
}
