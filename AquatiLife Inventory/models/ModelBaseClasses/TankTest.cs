using AquatiLife_Inventory.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory.ModelBaseClasses
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
        public DateTime TestDate { get; set; }

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
        public TankTest(bool isBiWeeklyTest, string testReason, DateTime testDate, TankAccessory tank, bool isWaterChanged = false, double? waterChangeQty = 0.00)
        {
            if (isBiWeeklyTest)
            {
                TestDescription = "Bi-Weekly normal maintenance - 50% Water";
                TestDate = testDate;
                IsBiweeklyTest = isBiWeeklyTest;
                IsWaterChanged = true;
                WaterChangeQuantity = 10.00;
            }
            else
            {
                TestDescription = testReason;
                TestDate = testDate;
                IsBiweeklyTest = false;
                IsWaterChanged = isWaterChanged;
                WaterChangeQuantity = waterChangeQty;
            }
            
        }

        /// <summary>
        /// Represents a tank test performed
        /// </summary>
        /// <param name="testDate">Date the test was performed, defaults to now</param>
        public TankTest(DateTime? testDate)
        {
            TestDate = DateTime.Now;
        }

    }
}
