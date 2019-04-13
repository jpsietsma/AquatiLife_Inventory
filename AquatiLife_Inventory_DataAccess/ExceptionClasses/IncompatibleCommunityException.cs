using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ExceptionClasses
{
    public class IncompatibleCommunityException : Exception
    {
        public IncompatibleCommunityException() : base(message: "Fish Community Incompatible")
        {
            throw new Exception("Fish Agression or Territorial levels prevent adding to this tank.", this);
        }
    }
}
