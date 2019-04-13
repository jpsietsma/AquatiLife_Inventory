using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ExceptionClasses
{
    public class UnknownFishTypeException : Exception
    {
        public UnknownFishTypeException() : base(message: "Unknown FishType classification.")
        {
            throw new Exception("FishType classification does not math any in the database", this);
        }
    }
}
