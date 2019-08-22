using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ViewModels.BaseClasses.Tank
{
    /// <summary>
    /// Class used to represent a fish tank water test and results
    /// </summary>
    public class WaterTest : FishTankTest
    {
        /// <summary>
        /// New tank water test
        /// </summary>
        /// <param name="dpH">Potential Hydrogen (pH) - Measures level of relative acidity to other substances based on the amount of hydrogen</param>
        /// <param name="dNitrate">Nitrate - Measures levels of Ammonia in water</param>
        /// <param name="dNitrite">Nitrite - Measures levels of Ammonia in water, toxic to fish in large amounts</param>
        /// <param name="dCarbonate">Carbonate Hardness - Measures Alkalinity - Combination of measures of Carbonate and Bicarbonate.  Helps to stabalize pH.</param>
        /// <param name="dGeneralHardness">General Hardness - Overall measure of the concentration of calcium, magnesium, and other ions in water.  Measured in degree where 1 = 17.9mg/l.</param>
        /// <param name="_tank">User Tank which is being tested</param>
        public WaterTest(double dpH, double dNitrate, double dNitrite, double dCarbonate, double dGeneralHardness, UserTanks _tank)
        {
            TestDate = DateTime.Now;
            pHLevel = dpH;
            NitrateLevel = dNitrate;
            NitriteLevel = dNitrite;
            CarbonateHardnessLevel = dCarbonate;
            GeneralHardnessLevel = dGeneralHardness;
        }

        /// <summary>
        /// New tank water test
        /// </summary>
        /// <param name="dpH">Potential Hydrogen (pH) - Measures level of relative acidity to other substances based on the amount of hydrogen</param>
        /// <param name="dNitrate">Nitrate - Measures levels of Ammonia in water</param>
        /// <param name="dNitrite">Nitrite - Measures levels of Ammonia in water, toxic to fish in large amounts</param>
        /// <param name="dCarbonate">Carbonate Hardness - Measures Alkalinity - Combination of measures of Carbonate and Bicarbonate.  Helps to stabalize pH.</param>
        /// <param name="dGeneralHardness">General Hardness - Overall measure of the concentration of calcium, magnesium, and other ions in water.  Measured in degree where 1 = 17.9mg/l.</param>
        /// <param name="_tank">User Tank which is being tested</param>
        /// <param name="_date">Date when the test was performed</param>
        public WaterTest(double dpH, double dNitrate, double dNitrite, double dCarbonate, double dGeneralHardness, UserTanks _tank, DateTime _date)
        {
            TestDate = _date;
            pHLevel = dpH;
            NitrateLevel = dNitrate;
            NitriteLevel = dNitrite;
            CarbonateHardnessLevel = dCarbonate;
            GeneralHardnessLevel = dGeneralHardness;
        }

        public override void RecordResults(FishTankTest _results)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.UserTankTests.Add(new UserTankTests { ActionsTaken = "Water Tested, Water Changed 80%", TestDate = _results.TestDate, fk_UserTank = _results.UserTank, fk_TestType = 2 });

                conn.SaveChanges();
            }
        }
    }
}
