using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModelClasses.Users.Permissions;

namespace ViewModelClasses.Users
{
    public class NewUserAccountViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PreferredName { get; set; }

        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public string ProfileImageUrl { get; set; }

        public UserPermissionsViewModel UserPermissions { get; set; }
    }
}
