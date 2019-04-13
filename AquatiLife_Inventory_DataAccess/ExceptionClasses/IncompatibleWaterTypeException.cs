using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ExceptionClasses
{
    public class IncompatibleWaterTypeException : Exception
    {
        public IncompatibleWaterTypeException() : base(message: "Fish is not compatible with watertype.")
        {
            throw new Exception("A fish addition was attempted on a tank not matching the required water type.", this);
        }
    }
}
