using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ExceptionClasses
{
    public class InvalidUsernamePasswordException : Exception
    {
        public InvalidUsernamePasswordException() : base(message: "Unknown Username or Password")
        {
            throw new Exception("Username or password could not be verified with the database.  Check both and try again.", this);
        }
    }
}
