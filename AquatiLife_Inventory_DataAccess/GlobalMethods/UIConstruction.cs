using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace AquatiLife_Inventory_DataAccess.GlobalMethods
{
    public static class UIConstruction
    {
        /// <summary>
        /// Populate grid with all purchase data
        /// </summary>
        /// <param name="_grid">Grid to populate with data</param>
        public static void PopulatePurchaseGrid(RadGridView _grid, AuthenticatedUserSession _session)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                _grid.ItemsSource = conn.UserPurchases.Where(x => x.fk_UserID == _session.UserID).ToList();
            }
        }

        /// <summary>
        /// Populate grid with live animal purchase data
        /// </summary>
        /// <param name="_grid">Grid to populate with data</param>
        public static void PopulateLiveAnimalPurchasesGrid(RadGridView _grid, AuthenticatedUserSession _session)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.vw_MasterFishView.Where(y => y.UserName == _session.UserName).ToList();              
                _grid.ItemsSource = a;
                
            }            
        }

        /// <summary>
        /// Populate grid with decoration purchase data
        /// </summary>
        /// <param name="_grid">Grid to populate with data</param>
        public static void PopulateDecorationPurchasesGrid(RadGridView _grid, AuthenticatedUserSession _session)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.UserPurchases.Where(x => x.fk_PurchaseCategory == 3
                                                && x.fk_UserID == _session.UserID
                                                ).ToList();

                _grid.ItemsSource = a;
            }
        }

        /// <summary>
        /// Populate grid with supply purchase data
        /// </summary>
        /// <param name="_grid">Grid to populate with data</param>
        public static void PopulateSupplyPurchasesGrid(RadGridView _grid, AuthenticatedUserSession _session)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                _grid.ItemsSource = conn.vw_UserSupplies.Where(x => x.Owner == _session.UserName).ToList();
            }
        }

        /// <summary>
        /// Populate grid with live animal purchase data
        /// </summary>
        /// <param name="_grid">Grid to populate with data</param>
        public static void PopulateLivePlantPurchasesGrid(RadGridView _grid, AuthenticatedUserSession _session)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.UserPurchases.Where(x => x.fk_PurchaseCategory == 2
                                                && x.fk_UserID == _session.UserID
                                                ).ToList();

                _grid.ItemsSource = a;
            }
        }

    }
}
