using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory.PurchaseOptions
{

    /// <summary>
    /// enum that holds purchase types for accessories.
    /// </summary>
    public enum Type
    {
        /// <summary>
        /// Item was purchased at a store
        /// </summary>
        STORE_LOCATION = 1,

        /// <summary>
        /// Item was purchased from a website on the internet
        /// </summary>
        INTERNET_PURCHASE = 2,

        /// <summary>
        /// Accessory was received as a gift
        /// </summary>
        GIFT = 3,

        /// <summary>
        /// Accessory was received from an unknown source
        /// </summary>
        OTHER = 4
    }
    
}
