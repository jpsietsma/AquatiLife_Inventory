using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ViewModels.BaseClasses.Tank
{
    public abstract class FishTankTest
    {
        /// <summary>
        /// ID of the tank being tested
        /// </summary>
        public int UserTank { get; set; }

        /// <summary>
        /// Potential Hydrogen (pH) - Measures level of relative acidity to other substances based on the amount of hydrogen
        /// </summary>
        public double pHLevel { get; set; }

        /// <summary>
        /// Nitrite - Measures levels of Ammonia in water, toxic to fish in large amounts
        /// </summary>
        public double NitriteLevel { get; set; }

        /// <summary>
        /// Nitrate - Measures levels of Ammonia in water
        /// </summary>
        public double NitrateLevel { get; set; }

        /// <summary>
        /// Carbonate Hardness - Measures Alkalinity - Combination of measures of Carbonate and Bicarbonate.  Helps to stabalize pH.
        /// </summary>
        public double CarbonateHardnessLevel { get; set; }

        /// <summary>
        /// General Hardness - Overall measure of the concentration of calcium, magnesium, and other ions in water.  Measured in degree where 1 = 17.9mg/l.
        /// </summary>
        public double GeneralHardnessLevel { get; set; }

        /// <summary>
        /// Date the test was performed
        /// </summary>
        public DateTime TestDate { get; set; }

        public FishTankTest()
        {

        }

        /// <summary>
        /// Save the test results to the database
        /// </summary>
        public virtual void RecordResults(FishTankTest _test)
        {

        }
    }
}
