using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.BaseClasses.Tank
{
    /// <summary>
    /// Describes the results of testing a fish tank for various conditions
    /// </summary>
    public class TankTest
    {
        /// <summary>
        /// Description of reasoning displayed to user
        /// </summary>
        public string TestDescription { get; set; }

        /// <summary>
        /// Date when the test took place
        /// </summary>
        public DateTime TestTimestamp { get; set; }

        /// <summary>
        /// pH level of the water in double int form
        /// </summary>
        public double pHLevel { get; set; }

        /// <summary>
        /// Temperature of the water at the time of the test
        /// </summary>
        public double WaterTemperature { get; set; }

        /// <summary>
        /// Level of Nitrates in the water
        /// </summary>
        public double NitrateLevel { get; set; }

        /// <summary>
        /// Level of Nitrites in the water
        /// </summary>
        public double NitriteLevel { get; set; }

        /// <summary>
        /// General Hardness level of the water
        /// </summary>
        public double GeneralHardness { get; set; }

        /// <summary>
        /// Carbonate Hardness level of the water
        /// </summary>
        public double CarbonateHardness { get; set; }

        /// <summary>
        /// ID of the tank we're testing
        /// </summary>
        public FishTank TankID { get; set; }

        /// <summary>
        /// Is this a bi-weekly normal maintenance test?
        /// </summary>
        public bool IsBiweeklyTest { get; set; }

        /// <summary>
        /// Is any water being changed along with this test?
        /// </summary>
        public bool IsWaterChanged { get; set; }

        /// <summary>
        /// Quantity of water being changed
        /// </summary>
        public double? WaterChangeQuantity { get; set; }

        /// <summary>
        /// Represents a test run on a fish tank
        /// </summary>
        /// <param name="isBiWeeklyTest">boolean representing if this is a normal biweekly test</param>
        /// <param name="testReason">string representing if not maintenance, reason for testing</param>
        /// <param name="testDate">DateTime representing the date the test took place</param>
        /// <param name="tank">Tank which we're running the test on</param>
        /// <param name="isWaterChanged">boolean representing if there is water being changed</param>
        /// <param name="waterChangeQty">nullable double representing the amount, if any, of water being changed in gallons</param>
        public TankTest(bool isBiWeeklyTest, string testReason, DateTime testDate, FishTank tank, bool isWaterChanged = false, double? waterChangeQty = 0.00)
        {
            if (isBiWeeklyTest)
            {
                TestDescription = "Bi-Weekly normal maintenance - 50% Water";
                TestTimestamp = testDate;
                IsBiweeklyTest = isBiWeeklyTest;
                IsWaterChanged = true;
                WaterChangeQuantity = 10.00;
            }
            else
            {
                TestDescription = testReason;
                TestTimestamp = testDate;
                IsBiweeklyTest = false;
                IsWaterChanged = isWaterChanged;
                WaterChangeQuantity = waterChangeQty;
            }
            
        }

        /// <summary>
        /// Represents a tank test performed
        /// </summary>
        /// <param name="tank">Id of the tank we're testing</param>
        /// <param name="testDate">Date the tank test was performed</param>
        public TankTest(FishTank tank, DateTime? testDate)
        {
            TestTimestamp = DateTime.Now;
            TankID = tank;
        }

        /// <summary>
        /// Check whether the pH levels are safe for the fish currently in the tank
        /// </summary>
        /// <param name="phMeasuredLevel">double int measurement of the pH level in the tank water</param>
        /// <returns>true if safe levels, false if levels are unsafe</returns>
        public bool phTestLevel(int phMeasuredLevel)
        {
            if (phMeasuredLevel >= 8 || phMeasuredLevel <= 5)
            {
                return false;
            }

            return true;
        }

    }
}
