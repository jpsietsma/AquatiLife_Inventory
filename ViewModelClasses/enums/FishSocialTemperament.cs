using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelClasses.enums
{

    /// <summary>
    /// Describes the type of communityism associated with the fish
    /// </summary>
    public enum FishSocialTemperament
    {
        /// <summary>
        /// Fish is good with all other types
        /// </summary>
        COMMUNITY = 0,

        /// <summary>
        /// Fish may be territorial with its own kind, but ok with everyone else
        /// </summary>
        SEMI_TERRITORIAL = 1,

        /// <summary>
        /// Fish may be territorial to all other fish
        /// </summary>
        TERRITORIAL = 2,

        /// <summary>
        /// Tank should only contain ONE male, as many females as desired
        /// </summary>
        TERRITORIAL_SINGLE_MALE = 3,

        /// <summary>
        /// Tank should only contain ONE female, as many males as desired
        /// </summary>
        TERRITORIAL_SINGLE_FEMALE = 4,

        /// <summary>
        /// Tank should contain ONLY THIS ONE fish, can be either male or female
        /// </summary>
        TERRITORIAL_SINGLE = 5
           
    }
}
