using AquaModClasses.BaseClassModels;
using AquaModClasses.PurchaseOptions;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.Fish
{
    public static class FishExt
    { 
        public static List<LiveFish> GetUserFish()
        {
            List<LiveFish> finalList = new List<LiveFish>();

            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var _data = conn.UserFish.Where(x => x.IsAlive == "True").ToList();
                List<Stores> _locations = conn.Stores.ToList();
                //List<Locations> _locationOptions = Locations.CREATURE_COMFORTS;

                foreach (UserFish _item in _data)
                {
                    bool.TryParse(_item.IsAlive, out bool isAlive);

                    finalList.Add(new LiveFish { AgressionLevel = AquaModClasses.FishProperties.FishTemperament.PEACEFUL
                                                    , BirthingMethod = AquaModClasses.FishProperties.FishBirthType.OTHER
                                                    , IsAlive = isAlive
                                                    , PurchaseDate = _item.PurchaseDate
                                                    , PurchasePrice = _item.PurchasePrice });
                }
            }

            return finalList;
        }

    }
}
