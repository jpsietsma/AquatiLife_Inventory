using AquatiLife_Inventory.PurchaseOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory.ModelBaseClasses
{

    /// <summary>
    /// Base class for all things, including living, added to a fish tank
    /// </summary>
    public class TankAccessory
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
        public Locations PurchaseLocation { get; set; }

        /// <summary>
        /// Name of the person who purchased the fish, usually self unless gifted.
        /// </summary>
        public string Purchaser { get; set; } = "Jimmy Sietsma";


        /// <summary>
        /// Base class for a new accessory for a tank which includes plants, ornaments, decorations, leds, fish, filter, heater, air pump, bubble decorations, gravel, food, and chemicals
        /// </summary>
        /// <param name="accessoryName">Name of the accessory as displayed to the user</param>
        /// <param name="accessoryCost">Cost of the accessory when purchased in $USD</param>
        /// <param name="accessoryPurchaseDate">Date of the purchase</param>
        /// <param name="accesoryPurchaser">Name of the person who purchased accessory</param>
        public TankAccessory(string accessoryName, double accessoryCost, DateTime accessoryPurchaseDate, string accesoryPurchaser = "Jimmy Sietsma")
        {
            DisplayName = accessoryName;
            PurchasePrice = accessoryCost;
            PurchaseDate = accessoryPurchaseDate;
            Purchaser = accesoryPurchaser;
        }

        /// <summary>
        /// Base class for a new accessory for a tank which includes plants, ornaments, decorations, leds, fish, filter, heater, air pump, bubble decorations, gravel, food, and chemicals
        /// </summary>
        /// <param name="accessoryName">Name of the accessory as displayed to the user</param>
        /// <param name="accessoryTankID">Tank which the accessory belongs to</param>
        /// <param name="accessoryCost">Cost of the accessory when purchased in $USD</param>
        /// <param name="accessoryPurchaseDate">Date of the purchase</param>
        public TankAccessory(string accessoryName, int accessoryTankID, double accessoryCost, DateTime accessoryPurchaseDate)
        {
            DisplayName = accessoryName;
            TankID = accessoryTankID;
            PurchasePrice = accessoryCost;
            PurchaseDate = accessoryPurchaseDate;
        }

        /// <summary>
        /// Base class for a new accessory for a tank which includes plants, ornaments, decorations, leds, fish, filter, heater, air pump, bubble decorations, gravel, food, and chemicals
        /// </summary>
        /// <param name="accessoryName">Name of the accessory as displayed to the user</param>
        /// <param name="accessoryCost">Cost of the accessory when purchased in $USD</param>
        /// <param name="accessoryPurchaseDate">Date of the purchase</param>
        /// <param name="accessoryPurchaseLocation">Store location where accessory was purchased</param>
        public TankAccessory(string accessoryName, double accessoryCost, DateTime accessoryPurchaseDate, Locations accessoryPurchaseLocation)
        {
            DisplayName = accessoryName;
            PurchasePrice = accessoryCost;
            PurchaseDate = accessoryPurchaseDate;
            PurchaseLocation = accessoryPurchaseLocation;
        }

        /// <summary>
        /// Base class for a new accessory for a tank which includes plants, ornaments, decorations, leds, fish, filter, heater, air pump, bubble decorations, gravel, food, and chemicals
        /// </summary>
        /// <param name="accessoryName">Name of the accessory as displayed to the user</param>
        /// <param name="accessoryTankID">Tank that the accesory belongs to</param>
        /// <param name="accessoryCost">Cost of the accessory when purchased in $USD</param>
        /// <param name="accessoryPurchaseDate">Date of the purchase</param>
        /// <param name="accessoryPurchaseLocation">Store location where accessory was purchased</param>
        public TankAccessory(string accessoryName, int accessoryTankID, double accessoryCost, DateTime accessoryPurchaseDate, Locations accessoryPurchaseLocation)
        {
            DisplayName = accessoryName;
            TankID = accessoryTankID;
            PurchasePrice = accessoryCost;
            PurchaseDate = accessoryPurchaseDate;
            PurchaseLocation = accessoryPurchaseLocation;
        }

    }
}
