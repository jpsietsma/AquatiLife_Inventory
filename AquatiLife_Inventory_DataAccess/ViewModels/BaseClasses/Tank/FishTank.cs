using AquatiLife_Inventory_DataAccess.DatabaseContext;
using AquatiLife_Inventory_DataAccess.enums.AccessoryOptions;
using AquatiLife_Inventory_DataAccess.enums.PurchaseOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ViewModels.BaseClasses
{
    /// <summary>
    /// Represents a fish tank
    /// </summary>
    public class FishTank : TankAccessory
    {

        /// <summary>
        /// Human-readable description of the tank
        /// </summary>
        public string TankDescription { get; set; }

        /// <summary>
        /// Describes the accessory type: FishTank is the default type for this class
        /// </summary>
        public AccessoryType AccessoryType { get; set; } = AccessoryType.FishTank;

        /// <summary>
        /// Describes the capacity of the tank in gallons
        /// </summary>
        public double TankSize { get; set; }

        /// <summary>
        /// Represents a list of Tank tests that have been performed
        /// </summary>
        public List<TankTest> TestHistory { get; set; } = new List<TankTest>();

        /// <summary>
        /// Represents a list of Fish that live in the tank
        /// </summary>
        public List<LiveFish> TankFishInventory { get; set; } = new List<LiveFish>();

        /// <summary>
        /// Represents a list of accessories that are associated with the tank
        /// </summary>
        public List<TankAccessory> TankAccessoryInventory { get; set; } = new List<TankAccessory>();

        /// <summary>
        /// Get the size of the tank in Gallons
        /// </summary>
        /// <returns>double representing tank capacity in gallons</returns>
        public double GetSizeGallons()
        {
            return TankSize;
        }

        /// <summary>
        /// Get the size of the tank in liters
        /// </summary>
        /// <returns>double representing tank capacity in liters</returns>
        public double GetSizeLiters()
        {
            return TankSize * 3.785;
        }

        /// <summary>
        /// Add an accessory to the list of items associated with the tank
        /// </summary>
        /// <param name="accessory">TankAccessory object representing accessory to add to the tank's list</param>
        public void AddAccessory(TankAccessory accessory)
        {
            TankAccessoryInventory.Add(accessory);
        }

        /// <summary>
        /// Add a Live fish to the tank's inventory
        /// </summary>
        /// <param name="fish">Object representing the fish to add to the tank</param>
        public void AddLiveFish(LiveFish fish)
        {
            TankFishInventory.Add(fish);
        }

        /// <summary>
        /// Represents a fish tank
        /// </summary>
        /// <param name="tankDescription">Human-readable description of the tank</param>
        /// <param name="tankCost">double representing cost of the tank</param>
        /// <param name="purchaseDate">DateTime representing date of purchase</param>
        /// <param name="purchaseLocation">PurchaseLocation representing the place purchased</param>
        /// <param name="tankSize">double representing capacity of the tank in gallons</param>
        public FishTank(string tankDescription, double tankCost, DateTime purchaseDate, Stores purchaseLocation, double tankSize = 0.00)
        {
            TankDescription = tankDescription;
            PurchasePrice = tankCost;
            PurchaseDate = purchaseDate;
            PurchaseLocation = purchaseLocation;
            TankSize = tankSize;
        }


    }
}
