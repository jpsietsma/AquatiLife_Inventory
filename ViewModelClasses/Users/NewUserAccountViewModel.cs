using AquatiLife_Inventory_DataAccess.DatabaseContext;
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

        public string PhoneNumber { get; set; }
        public string AltEmail { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public bool receivingNewsletter { get; set; }
        public string Website { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public string ProfileImageUrl { get; set; }
        public int fk_userPermissionsID { get; set; }

        public UserPermissions UserPermissions { get; set; }
    }
}
