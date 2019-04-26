using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ViewModels.Authentication
{

    /// <summary>
    /// Represents a logged in user session
    /// </summary>
    public class UserSession
    {
        /// <summary>
        /// Unique ID to identify the session in the database
        /// </summary>
        public string SessionID { get; set; }

        /// <summary>
        /// UserID of the account logged into the session
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// UserName of the account logged into the session
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// UserAccessLevel permissions for the session
        /// </summary>
        public string PermissionLevels { get; set; }

        /// <summary>
        /// Indicates if the session is active
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// DateTime of the beginning of the session
        /// </summary>
        public DateTime SessionBegin { get; set; }

        /// <summary>
        /// DateTime of the end of the session
        /// </summary>
        public DateTime? SessionEnd { get; set; }

        /// <summary>
        /// Readable string representation of the session length
        /// </summary>
        public string SessionLength { get; set; }

        /// <summary>
        /// Does user have administrator permissions?
        /// </summary>
        public bool IsAdminUser
        {
            get
            {
                bool final = false;

                foreach (string permission in PermissionLevels.Split(';').ToList())
                {
                    if (permission.Contains("Admin"))
                    {
                        final = true;
                    }
                }

                return final;
            }
        }


        /// <summary>
        /// Return the length of time of the session in a readable string
        /// </summary>
        /// <returns>string readable length of the session</returns>
        public string GetSessionLength(bool asOfNow = true)
        {
            if (asOfNow || SessionEnd.Value == null)
            {
                SessionEnd = DateTime.Now;
            }

            string finalLength = string.Empty;               
            double? totalSeconds = Math.Floor((SessionBegin.Subtract(SessionEnd.Value)).Duration().TotalSeconds);
            double? totalDays = null;
            double? totalHours = null;
            double? totalMinutes = null;

            if (totalSeconds > 86400)
            {
                totalDays = Math.Floor(totalSeconds.Value / 86400);
                totalSeconds = totalSeconds - (totalDays.Value * 86400);
            }

            if (totalSeconds > 3600)
            {
                totalHours = Math.Floor(totalSeconds.Value / 3600);
                totalSeconds = totalSeconds - (totalHours.Value * 3600);
            }

            if (totalSeconds > 60)
            {
                totalMinutes = Math.Floor(totalSeconds.Value / 60);
                totalSeconds = totalSeconds - (totalMinutes.Value * 60);
            }

            //build response string
            if (totalDays != null)
            {
                finalLength += $@"{totalDays } Days; ";
            }

            if (totalHours != null)
            {
                finalLength += $@"{totalHours } Hours; ";
            }

            if (totalMinutes != null)
            {
                finalLength += $@"{totalMinutes } Minutes; ";
            }

            if (totalSeconds != null)
            {
                finalLength += $@"{totalSeconds } Seconds; ";
            }

            return finalLength;
        }

    }
}
