using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory.models
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
        public double PurchaseCost { get; set; }

        /// <summary>
        /// Date the accessory was purchased
        /// </summary>
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// Store or location where accessory was purchased
        /// </summary>
        public string PurchaseLocation { get; set; }

        /// <summary>
        /// Base class for a new accessory for a tank which includes plants, ornaments, decorations, leds, fish, filter, heater, air pump, bubble decorations, gravel, food, and chemicals
        /// </summary>
        /// <param name="accessoryName">Name of the accessory as displayed to the user</param>
        /// <param name="accessoryCost">Cost of the accessory when purchased in $USD</param>
        /// <param name="accessoryPurchaseDate">Date of the purchase</param>
        public TankAccessory(string accessoryName, double accessoryCost, DateTime accessoryPurchaseDate)
        {
            DisplayName = accessoryName;
            PurchaseCost = accessoryCost;
            PurchaseDate = accessoryPurchaseDate;
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
            PurchaseCost = accessoryCost;
            PurchaseDate = accessoryPurchaseDate;
        }

        /// <summary>
        /// Base class for a new accessory for a tank which includes plants, ornaments, decorations, leds, fish, filter, heater, air pump, bubble decorations, gravel, food, and chemicals
        /// </summary>
        /// <param name="accessoryName">Name of the accessory as displayed to the user</param>
        /// <param name="accessoryCost">Cost of the accessory when purchased in $USD</param>
        /// <param name="accessoryPurchaseDate">Date of the purchase</param>
        /// <param name="accessoryPurchaseLocation">Store location where accessory was purchased</param>
        public TankAccessory(string accessoryName, double accessoryCost, DateTime accessoryPurchaseDate, string accessoryPurchaseLocation)
        {
            DisplayName = accessoryName;
            PurchaseCost = accessoryCost;
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
        public TankAccessory(string accessoryName, int accessoryTankID, double accessoryCost, DateTime accessoryPurchaseDate, string accessoryPurchaseLocation)
        {
            DisplayName = accessoryName;
            TankID = accessoryTankID;
            PurchaseCost = accessoryCost;
            PurchaseDate = accessoryPurchaseDate;
            PurchaseLocation = accessoryPurchaseLocation;
        }
    }
}
