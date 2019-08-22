using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.DatabaseContext
{
    public partial class UserPurchases : IDisposable
    {
        public void Dispose()
        {
            foreach (PropertyInfo _property in GetType().GetProperties())
            {
                _property.SetValue(this, null);
            }
        }


    }
}
