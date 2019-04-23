using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFP_AquatiLife_Inventory_UI.ViewModels
{
    public class PlantDictionaryEntryViewModel : LivePlantTypes
    {
        [Display(Name = "Plant Name")]
        public new string PlantName { get; set; }

        [Display(Name = "Ideal Temperature")]
        public new int PlantIdealTemp { get; set; }

        [Display(Name = "Minimum Temperature")]
        public new int PlantMinTemp { get; set; }

        [Display(Name = "Maximum Temperature")]
        public new int PlantMaxTemp { get; set; }

        [Display(Name = "Can Float?")]
        public new bool CanFloat { get; set; }

        [Display(Name = "Plant Image")]
        public new string PlantImage { get; set; }

        public string TankLightingLevel { get; set; }

        public string PlantSizeClass { get; set; }

        public string PlantMaxSize { get; set; }

        public PlantDictionaryEntryViewModel(vw_PlantDictionary _data)
        {
            PlantName = _data.PlantType;
            PlantIdealTemp = _data.IdealTemp.Value;
            PlantMinTemp = _data.MinTemp;
            PlantMaxTemp = _data.MaxTemp;
            CanFloat = _data.Floatable;
            PlantImage = _data.Image;
            TankLightingLevel = _data.Lighting;
            PlantSizeClass = _data.PlantSize;
            PlantMaxHeight = _data.MaxInches;

        }

    }
}
