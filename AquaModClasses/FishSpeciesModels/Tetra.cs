using AquaModClasses.BaseClassModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaModClasses.FishSpeciesModels
{
    /// <summary>
    /// Represents tetra fish
    /// </summary>
    public class Tetra : LiveFish
    {

        /// <summary>
        /// Instantiate new Tetra fish object
        /// </summary>
        public Tetra()
        {
            FishMinPH = 5.0;
            FishMaxPH = 7.5;
            FishMinTemp = 73;
            FishMaxTemp = 78;
        }
    }
}
