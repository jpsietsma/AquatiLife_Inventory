using AquaModClasses.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaModClasses.ext
{
    /// <summary>
    /// Extension class to help support and add additional functionality to processing UserSession data
    /// </summary>
    public static class UserExt
    {

        /// <summary>
        /// Convert Session TimeSpan into absolute values for total days, hours, minutes, and seconds of the timespan
        /// </summary>
        /// <param name="_userSession">Session to use when evaluating session timespan</param>
        /// <param name="RoundedSeconds">final seconds of total timestamp</param>
        /// <param name="RoundedMinutes">final minutes of total timestamp</param>
        /// <param name="RoundedHours">final hours of total timestamp</param>
        /// <param name="RoundedDays">final days of total timestamp</param>
        public static bool ConvertSessionTimespan(this UserSession _userSession, out int RoundedSeconds, out int RoundedMinutes, out int RoundedHours, out int RoundedDays)
        {
            int.TryParse((_userSession.SessionBegin - _userSession.SessionEnd.Value).Duration().TotalSeconds.ToString(), out RoundedSeconds);
            int.TryParse((_userSession.SessionBegin - _userSession.SessionEnd.Value).Duration().TotalSeconds.ToString(), out RoundedMinutes);
            int.TryParse((_userSession.SessionBegin - _userSession.SessionEnd.Value).Duration().TotalSeconds.ToString(), out RoundedHours);
            int.TryParse((_userSession.SessionBegin - _userSession.SessionEnd.Value).Duration().TotalSeconds.ToString(), out RoundedDays);

            return true;
        }
    }
}
