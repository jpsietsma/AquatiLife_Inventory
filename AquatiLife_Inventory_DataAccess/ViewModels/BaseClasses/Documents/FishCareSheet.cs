using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ViewModels.BaseClasses.Documents
{

    public class FishCareSheet
    {
        public string FishName { get; set; }
        public string FilePath { get; set; }

        public FishCareSheet(string _fishName, string _filePath)
        {
            FishName = _fishName;
            FilePath = _filePath;
        }
    }
}
