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
        public int PlantMinTemp { get; set; }

        [Display(Name = "Maximum Temperature")]
        public int PlantMaxTemp { get; set; }

        [Display(Name = "Can Float?")]
        public bool CanFloat { get; set; }

        [Display(Name = "Plant Image")]
        public string PlantImage { get; set; }

        public string TankLightingLevel { get; set; }

        public string PlantSizeClass { get; set; }

        public string PlantMaxHeight { get; set; }
        public bool NeedsFertilizer { get; set; }

    }
}
