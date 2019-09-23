using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ext
{
    /// <summary>
    /// Class to handle extension methods for Live Plant classes
    /// </summary>
    public static class LivePlantExt
    {

        /// <summary>
        /// Get additional plant type information
        /// </summary>
        /// <param name="_plant">ILivePlantType representing type of plant to get information on</param>
        /// <returns>Dictionary of string key and values with additional information on the specified plant type</returns>
        public static Dictionary<string, string> GetPlantTypeInfo(this ILivePlantType _plant)
        {
            Dictionary<string, string> _final = new Dictionary<string, string>();

            using (DatabaseEntities conn = new DatabaseEntities())
            {
                //var a = conn.vw_PlantDictionary.Where(x => x.TypeID =_plant.pk_PlantID).ToList();

                //_final.Add("", Convert.ToString(_plant.PlantIdealTemp));
                //_final.Add("", Convert.ToString(_plant.CanFloat));
                //_final.Add("", _plant.List_PlantSizeClasses.PlantSizeClassName);
                //_final.Add("", _plant.PlantImage);
                //_final.Add("", Convert.ToString(_plant.NeedsFertilizer));
                //_final.Add("", Convert.ToString(_plant.PlantMaxTemp));
                //_final.Add("", _plant.List_PlantSizeClasses.PlantSizeClassName);

            }

            return _final;
        }

        /// <summary>
        /// Get a complete dictionary of plant types and their properties in Dictionary string>, Dictionary string, string>() format
        /// <code>
        /// example: 
        /// var _plants = GetPlantDictionary();
        /// string plantName = _plants["AmazonSword"]["PlantType"];
        /// int idealTemp = _plants["Wisteria"]["IdealTemp"];
        /// </code
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, Dictionary<string, string>> GetPlantDictionary()
        {
            Dictionary<string, Dictionary<string, string>> _final = new Dictionary<string, Dictionary<string, string>>();

            List<vw_PlantDictionary> plants = new List<vw_PlantDictionary>();

            using (DatabaseEntities conn = new DatabaseEntities())
            {
                List<vw_PlantDictionary> a = conn.vw_PlantDictionary.ToList();

                plants = a;

                foreach (vw_PlantDictionary _plant in plants)
                {
                    Dictionary<string, string> _properties = new Dictionary<string, string>();

                    foreach (PropertyInfo _property in typeof(vw_PlantDictionary).GetProperties())
                    {
                        _properties.Add(_property.Name, _property.GetValue(_plant).ToString());
                    }

                    _final.Add(_plant.PlantType, _properties);
                }
            }

            return _final;         
        }
    }
}
