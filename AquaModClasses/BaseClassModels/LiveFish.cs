using AquaModClasses.AccessoryOptions;
using AquaModClasses.FishProperties;
using AquaModClasses.PurchaseOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AquaModClasses.BaseClassModels
{

    /// <summary>
    /// Represents a live fish
    /// </summary>
    public class LiveFish : ILiveFish
    {
        /// <summary>
        /// Represents the type of object, "LiveFish" has an "AccessoryType" of "Fish"
        /// </summary>
        public AccessoryType EntityType { get; set; } = AccessoryType.Fish;

        #region Purchase Properties...

            /// <summary>
            /// Cost of the fish when purchased
            /// </summary>
            public double? PurchasePrice { get; set; }

            /// <summary>
            /// Refers to the data the fish was purchased from a store and added to a tank
            /// </summary>
            public DateTime? PurchaseDate { get; set; }

            /// <summary>
            /// Store where fish was purchased
            /// </summary>
            public Locations PurchaseLocation { get; set; }

        #endregion

        #region Fish Descriptive Properties...

            /// <summary>
            /// Pet Fish's Friendly Name
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Represents how big the fish can grow (centimeters)
            /// </summary>
            public double? Size { get; set; }

            /// <summary>
            /// Describes the primary color of the fish
            /// </summary>
            public Color PrimaryColor { get; set; }

            /// <summary>
            /// Describes the secondary color of the fish
            /// </summary>
            public Color SecondaryColor { get; set; }

            /// <summary>
            /// Whether or not fish is still living
            /// </summary>
            public bool IsAlive { get; set; } = true;

        #endregion

        #region Fish Species Properties...

            /// <summary>
            /// Method which fish uses to give birth
            /// </summary>
            public FishBirthType BirthingMethod { get; set; }

            /// <summary>
            /// Represents category of feeder type that fish falls into
            /// </summary>
            public FishFeederType FeederType { get; set; }

            /// <summary>
            /// Describes the type of temperament of the fish
            /// </summary>
            public FishTemperament AgressionLevel { get; set; }

            /// <summary>
            /// Describes the level of social interaction of the fish
            /// </summary>
            public FishSocialTemperament SocialLevel { get; set; }

            /// <summary>
            /// Describes the species of the fish
            /// </summary>
            public string CommonName { get; set; }

            /// <summary>
            /// Describes the genus of the fish
            /// </summary>
            public string ScientificName { get; set; }

            /// <summary>
            /// Maximum water temperature in which the fish can comfortably live (celcius)
            /// </summary>
            public int FishMaxTemp { get; set; } = 26;

            /// <summary>
            /// Minimum water temperature in which the fish can comfortably live (celcius)
            /// </summary>
            public int FishMinTemp { get; set; } = 22;

            /// <summary>
            /// Maximum PH level in which the fish can comfortably live
            /// </summary>
            public double FishMaxPH { get; set; } = 0;

            /// <summary>
            /// Minimum PH level in which the fish can comfortably live
            /// </summary>
            public double FishMinPH { get; set; } = 0;


        #endregion

        #region Fish Data Methods...

            /// <summary>
            /// Return the fish max size in centimeters
            /// </summary>
            /// <returns>Max size of type double in centimeters</returns>
            public double? GetMaxSizeCM()
            {
                if (Size.HasValue)
                {
                    return Size;
                }

                return 0;
            }

            /// <summary>
            /// Return the max fish size in inches
            /// </summary>
            /// <returns>Max size of type double in inches</returns>
            public double? GetMaxSizeInch()
            {
                if (Size.HasValue)
                {
                    Double.TryParse((Size / 2.54).ToString(), out double finalSize);

                    return finalSize;
                }

                return 0;
            }

        #endregion

    }
}
