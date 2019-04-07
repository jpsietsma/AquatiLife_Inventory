using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ViewModels.BaseClasses
{

    /// <summary>
    /// Base class for all things, including living, added to a fish tank
    /// </summary>
    public class TankAccessory : ITankAccessory
    {

        /// <summary>
        /// Database ID of the tank accessory
        /// </summary>
        public int AccessoryID { get; set; }

        /// <summary>
        /// Tank which the accessory belongs to
        /// </summary>
        public int TankID { get; set; }

        /// <summary>
        /// Name of the accessory as displayed to the user
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Cost of the accessory in double
        /// </summary>
        public double PurchasePrice { get; set; }

        /// <summary>
        /// Date the accessory was purchased
        /// </summary>
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// Store or location where accessory was purchased
        /// </summary>
        public Stores PurchaseLocation { get; set; }

        /// <summary>
        /// Name of the person who purchased the fish, usually self unless gifted.
        /// </summary>
        public string Purchaser { get; set; } = "Jimmy Sietsma";       

    }
}
