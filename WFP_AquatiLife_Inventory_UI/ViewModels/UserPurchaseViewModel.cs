using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFP_AquatiLife_Inventory_UI.ViewModels
{
    public class UserPurchaseViewModel : UserPurchases
    {
        #region View Model properties...
            /// <summary>
            /// Name of the store where purchase was made.
            /// </summary>
            public string StoreName { get; }

            /// <summary>
            /// Username of the user who purchased the item.
            /// </summary>
            public string UserName { get; }

            /// <summary>
            /// Total cost of the purchase.
            /// </summary>
            new public decimal Cost { get; }

            /// <summary>
            /// Date purchase was made.
            /// </summary>
            new public string Date { get; }

            /// <summary>
            /// Description of the purchase record.
            /// </summary>
            new public string Description { get; }

            /// <summary>
            /// Quantity of the item purchased.
            /// </summary>
            new public int Quantity { get; }

            /// <summary>
            /// Details that go along with the purchase if it's a Live animal purchase.
            /// </summary>
            public UserFish FishDetails { get; }
        #endregion

        #region View Model constructors...
            /// <summary>
            /// Generate view model populated with result data from stored procedure, optionally add a FishID to get fish details.
            /// </summary>
            /// <param name="_data">Result data returned from GetUserPurchases() SQL stored procedure.</param>
            /// <param name="fishID">PK of the UserFish record which associates with the purchase record.</param>
            public UserPurchaseViewModel(GetUserPurchases_Result _data, int fishID = 0)
            {
                pk_PurchaseID = _data.pk_PurchaseID;
                Description = _data.Description;
                Date = _data.Date;
                Cost = Convert.ToDecimal(_data.Cost);
                fk_StoreID = _data.fk_StoreID;
                fk_UserID = _data.fk_UserID;
                fk_PurchaseCategory = _data.fk_PurchaseCategory;
                Quantity = _data.Quantity;

                StoreName = GetStoreName();
                UserName = GetUserName();

                if (fishID != 0)
                {
                    using (DatabaseEntities conn = new DatabaseEntities())
                    {
                        FishDetails = conn.UserFish.Where(x => x.pk_UserFishID == fishID).First();
                    }
                }
            }
        #endregion

        #region View Model private methods...
            /// <summary>
            /// Retrieve store name from purchase record and populate view model.
            /// </summary>
            /// <returns>string representing store name.</returns>
            private string GetStoreName()
            {
                using (DatabaseEntities conn = new DatabaseEntities())
                {
                    return conn.Stores.Where(x => x.pk_StoreID == fk_StoreID).Select(y => y.StoreName).First();
                }
            }

            /// <summary>
            /// Retrieve user name from purchase record and populate view model.
            /// </summary>
            /// <returns>string representing user name of purchaser.</returns>
            private string GetUserName()
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                return conn.Users.Where(x => x.pk_UserID == fk_UserID).Select(y => y.UserName).First();
            }
        }
        #endregion

    }
}
