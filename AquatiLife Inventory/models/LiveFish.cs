using AquatiLife_Inventory.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AquatiLife_Inventory.models
{
    /// <summary>
    /// Represents a live fish
    /// </summary>
    public class LiveFish
    {
        /// <summary>
        /// Represents the type of object, "LiveFish" has an "AccessoryType" of "Fish"
        /// </summary>
        public AccessoryType EntityType { get; set; } = AccessoryType.Fish;

        /// <summary>
        /// Human-Friendly pet name of the fish
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Describes the primary color of the fish
        /// </summary>
        public Color PrimaryColor { get; set; }

        /// <summary>
        /// Describes the secondary color of the fish
        /// </summary>
        public Color SecondaryColor { get; set; }

        /// <summary>
        /// Represents category of feeder type that fish falls into
        /// </summary>
        public FishFeederType FeederType { get; set; }

        /// <summary>
        /// Location where fish was purchased
        /// </summary>
        public PurchaseOptions PurchaseLocation { get; set; }

        /// <summary>
        /// Date fish was purchased or received
        /// </summary>
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// Whether or not fish is still living
        /// </summary>
        public bool IsAlive { get; set; }




    }
}
