using AquatiLife_Inventory_DataAccess.ViewModels.BaseClasses.Documents;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ext
{

    /// <summary>
    /// Class for handling files for care sheets
    /// </summary>
    public static class CareSheetExt
    {
        /// <summary>
        /// Get a dictionary of caresheets available returning dictionary of fishname => caresheet file path
        /// </summary>
        /// <returns>Dictionary with key being fish name, value care sheet file path</returns>
        public static Dictionary<string, string> GetMasterCaresheetDictionary()
        {
            Dictionary<string, string> _final = new Dictionary<string, string>();

            DirectoryInfo _caresheetsDir = new DirectoryInfo(ConfigurationManager.AppSettings["CareSheetsDirectory"]);
            DirectoryInfo _userguidesDir = new DirectoryInfo(ConfigurationManager.AppSettings["UserGuidesDirectory"]);

            foreach (var _file in _caresheetsDir.GetFiles().ToList())
            {
                string _FishName = _file.Name.Replace("caresheet-", "").Replace(".pdf", "").Replace(" ", "").Replace("-", " ");

                if (_FishName.StartsWith(" "))
                {
                    _FishName.Remove(0, 1);
                }


                _final.Add(_FishName, _file.FullName);
            }

            return _final;
        }
        
        /// <summary>
        /// Determine if caresheet exists for specified fish
        /// </summary>
        /// <param name="_caresheet">FishCareSheet search object</param>
        /// <returns>true if care sheet pdf file exists</returns>
        public static bool Exists(this FishCareSheet _caresheet)
        {
            bool _final = false;

            if (GetMasterCaresheetDictionary().Keys.Contains(_caresheet.FishName))
            {
                _final = true;
            }

            return _final;
        }

        /// <summary>
        /// Save the current care sheet as PDF file
        /// </summary>
        /// <param name="_caresheet">FishCareSheet object to check</param>
        /// <param name="FishType">string representing the fish type to check</param>
        /// <returns>true if care sheet path is found</returns>
        public static bool SaveAsPDF(this FishCareSheet _caresheet, string FishType)
        {
            bool _final;

            if (String.IsNullOrEmpty(FishType))
            {
                _final = false;
            }
            else
            {
                try
                {
                    System.Diagnostics.Process.Start(_caresheet.FilePath);

                    _final = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    _final = false;
                }
            }            

            return _final;
        }

        /// <summary>
        /// Save the current care sheet as PDF file
        /// </summary>
        /// <param name="_caresheet">FishCareSheet object to search filepath for</param>
        /// <returns>true if care sheet found</returns>
        public static bool SaveAsPDF(this FishCareSheet _caresheet)
        {
            bool _final;

            try
            {
                System.Diagnostics.Process.Start(_caresheet.FilePath);

                _final = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                _final = false;
            }

            return _final;
        }

    }
}
