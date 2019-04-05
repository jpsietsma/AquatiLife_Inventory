﻿using System;
using AquaModClasses.PurchaseOptions;

namespace AquaModClasses.BaseClassModels
{
    /// <summary>
    /// Tank Accessory Interface
    /// </summary>
    public interface ITankAccessory
    {
        /// <summary>
        /// 
        /// </summary>
        int AccessoryID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        DateTime PurchaseDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Locations PurchaseLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        double PurchasePrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string Purchaser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int TankID { get; set; }
    }
}