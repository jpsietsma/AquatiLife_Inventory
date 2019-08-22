using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFP_AquatiLife_Inventory_UI
{
    public partial class FishViewModel
    {
        public string FriendlyFishName { get; set; }
        public DateTime FishOwnershipAge { get; set; }
        public FishTypes FishType { get; set; }
    }
}
