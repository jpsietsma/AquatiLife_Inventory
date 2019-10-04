using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelClasses.DictionaryEntries.Plants
{
    public class PlantDictionaryEntryViewModel
    {
        [Display(Name = "Plant Name")]
        public string PlantName { get; set; }

        [Display(Name = "Ideal Temperature")]
        public int PlantIdealTemp { get; set; }

        [Display(Name = "Minimum Temperature")]
        public int PlantMinTemp { get; set; } = 0;

        [Display(Name = "Maximum Temperature")]
        public int PlantMaxTemp { get; set; }

        [Display(Name = "Can Float?")]
        public bool CanFloat { get; set; }

        [Display(Name = "Plant Image")]
        public string PlantImage { get; set; }

        public string TankLightingLevel { get; set; }

        public string PlantSizeClass { get; set; }

        public string PlantMaxHeight { get; set; } = "00.00";
        public bool NeedsFertilizer { get; set; }

        public PlantDictionaryEntryViewModel(vw_PlantDictionary _dictionary)
        {
            PlantName = _dictionary.PlantType;
            PlantMinTemp = _dictionary.MinTemp;
            PlantMaxTemp = _dictionary.MaxTemp;
            CanFloat = _dictionary.Floatable;
            TankLightingLevel = _dictionary.Lighting;
            PlantSizeClass = _dictionary.PlantSize;
            NeedsFertilizer = _dictionary.Fertilizer;
            PlantImage = _dictionary.Image;

            if (_dictionary.IdealTemp.HasValue)
            {
                PlantIdealTemp = _dictionary.IdealTemp.Value;                
            }

            if (_dictionary.MaxInches.HasValue)
            {
                PlantMaxHeight = _dictionary.MaxInches.Value.ToString();
            }
            
        
        }

    }
}
