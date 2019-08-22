using AquatiLife_Inventory_DataAccess.DatabaseContext;
using AquatiLife_Inventory_DataAccess.ViewModels.DictionaryEntryViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ext
{
    public static class FishExt
    {
        public static List<List_FishSicknessTypes> GetFishTypeDiseases(int fishPK)
        {
            List<List_FishSicknessTypes> _final = new List<List_FishSicknessTypes>();

            using (DatabaseEntities conn = new DatabaseEntities())
            {
                List<List_FishSicknessTypes> a = conn.List_FishSicknessTypes.Where(x => x.fk_AffectedTypes.ToString().Contains(fishPK.ToString())).ToList();

                if (a.Count() > 0)
                {
                    _final = a;
                }
            }

            return _final;
        }

        public static List<List_FishSicknessTypes> GetFishTypeDiseases(this UserFish _fish)
        {
                List<List_FishSicknessTypes> _final = new List<List_FishSicknessTypes>();

                using (DatabaseEntities conn = new DatabaseEntities())
                {
                    List<List_FishSicknessTypes> a = conn.List_FishSicknessTypes.Where(x => x.fk_AffectedTypes.ToString().Contains(_fish.pk_UserFishID.ToString())).ToList();

                    if (a.Count() > 0)
                    {
                        _final = a;
                    }
                }

                return _final;
        }

        /// <summary>
        /// Return the path to the dictionary image for the specified fish type
        /// </summary>
        /// <param name="_fish">fishtype to get image for</param>
        /// <returns>string path to the image file</returns>
        public static string GetFishImagePath (this IFishTypes _fish)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                return conn.FishTypes.Where(x => x.pk_FishTypeID == _fish.pk_FishTypeID).First().FishTypeImagePath;
            }
        }
    }
}
