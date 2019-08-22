using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.PopulateUI
{
    public static class PopulateUI_View_PlantInfo
    {
        /// <summary>
        /// Get the vw_plantDictionary entry for the selected plant.
        /// </summary>
        /// <param name="plantName">Name of the plant to display</param>
        public static vw_PlantDictionary PopulateView(string plantName)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                return conn.vw_PlantDictionary.Where(x => x.PlantType == plantName).First();                
            }
        }
    }
}
