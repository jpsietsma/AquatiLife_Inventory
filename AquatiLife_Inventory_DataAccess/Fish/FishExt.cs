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
        public static List<ILiveFish> GetUserFish()
        {
            List<ILiveFish> finalList = new List<ILiveFish>();

            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var _data = conn.UserFish.Where(x => x.IsAlive == "True").ToList();
                List<PurchaseLocations> _locations = conn.PurchaseLocations.ToList();
                //List<Locations> _locationOptions = Locations.CREATURE_COMFORTS;

                foreach (UserFish _item in _data)
                {
                    bool.TryParse(_item.IsAlive, out bool isAlive);

                    finalList.Add(new LiveFish { AgressionLevel = AquaModClasses.FishProperties.FishTemperament.PEACEFUL
                                                    , BirthingMethod = AquaModClasses.FishProperties.FishBirthType.OTHER
                                                    , IsAlive = isAlive
                                                    , PurchaseDate = _item.PurchaseDate
                                                    , PurchasePrice = _item.PurchasePrice
                                                    , PurchaseLocation = _item.PurchaseLocations.StoreName.sel});
                }
            }

            return finalList;
        }

    }
}
