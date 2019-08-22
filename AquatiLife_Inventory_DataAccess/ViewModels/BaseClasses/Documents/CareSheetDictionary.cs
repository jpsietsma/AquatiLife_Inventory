using AquatiLife_Inventory_DataAccess.DatabaseContext;
using AquatiLife_Inventory_DataAccess.ext;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ViewModels.BaseClasses.Documents
{
    /// <summary>
    /// Class represents one aquatic animal caresheet document
    /// </summary>
    public class CareSheetDictionary
    {
        public List<string> FishNames { get; set; }
        public List<string> CareSheetPaths { get; set; }
        private Dictionary<string, string> _final { get; set; }

        /// <summary>
        /// Create a new CareSheet dictionary item
        /// </summary>
        public CareSheetDictionary()
        {
             _final = CareSheetExt.GetMasterCaresheetDictionary();
            FishNames = _final.Keys.ToList();
            CareSheetPaths = _final.Values.ToList();

        }
        
        /// <summary>
        /// Check for fish name in CareSheetDictionary
        /// </summary>
        /// <param name="key">fish type name</param>
        /// <returns>true if fish found</returns>
        public bool ContainsKey(string key)
        {
            if (_final.ContainsKey(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks for caresheet file path in CareSheetDictionary
        /// </summary>
        /// <param name="value">filepath to look for</param>
        /// <returns>true if filepath is found in dictionary</returns>
        public bool ContainsValue(string value)
        {
            if (_final.ContainsValue(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Return a list of keys in the dictionary, fish names
        /// </summary>
        /// <returns>List of string of fish names in the dictionary</returns>
        public List<string> GetListKeys()
        {
            return this._final.Keys.ToList();
        }

        /// <summary>
        /// Return a list of values in the dictionary, care sheet filepaths
        /// </summary>
        /// <returns>List of string of care sheet filepaths</returns>
        public List<string> GetListValues()
        {
            return this._final.Values.ToList();
        }

        /// <summary>
        /// Add care sheet to the dictionary by key and value
        /// </summary>
        /// <param name="key">key to add to the dictionary, fish name</param>
        /// <param name="value">value to add to the dictionary, path to care sheet</param>
        public void Add(string key, string value)
        {
            _final.Add(key, value);

            using (DatabaseEntities conn = new DatabaseEntities())
            {
                try
                {
                    conn.FishCareGuides.Add(new FishCareGuides { DocumentPath = value, fk_AnimalType = 1, fk_FishType = 1});
                    conn.SaveChanges();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// Remove care sheet from the dictionary by key
        /// </summary>
        /// <param name="key">Key to remove from dictionary</param>
        public void Remove(string key)
        {
            _final.Remove(key);
        }

    }
}
