using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaModClasses.Authentication
{
    public class UserSession
    {
        public int SessionID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PermissionLevels { get; set; }
        public bool IsActive { get; set; }
        public string SessionBegin { get; set; }
        public string SessionEnd { get; set; }


    }
}
