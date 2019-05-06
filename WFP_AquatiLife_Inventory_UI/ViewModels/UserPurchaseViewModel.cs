using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFP_AquatiLife_Inventory_UI.ViewModels
{
    public class UserPurchaseViewModel : UserPurchases
    {
        ObservableCollection<GetUserPurchases_Result> _data = new ObservableCollection<GetUserPurchases_Result>();

        public UserPurchaseViewModel(int purchaseID, AuthenticatedUserSession _session)
        {

        }
    }
}
