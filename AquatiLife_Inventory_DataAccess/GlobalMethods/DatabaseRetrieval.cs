using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.GlobalMethods
{

    /// <summary>
    /// Static methods for getting database entities using various parameters
    /// </summary>
    public static class DatabaseRetrieval
    {
        /// <summary>
        /// Get User Entity from primary key
        /// </summary>
        /// <param name="pk">PK to search Entities</param>
        /// <returns>Users object with matching primary key</returns>
        public static Users GetUserByPK(int pk)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                return conn.Users.Where(x => x.pk_UserID == pk).First();
            }
        }

        /// <summary>
        /// Get User Entity from userName
        /// </summary>
        /// <param name="userName">userName to search Entities</param>
        /// <returns>Users object with matching userName</returns>
        public static Users GetUserByUserName(string userName)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                return conn.Users.Where(x => x.UserName == userName).First();
            }
        }

        /// <summary>
        /// Get Water Type PK from Type Name
        /// </summary>
        /// <param name="waterType">Water Type Name to use to seach PKs</param>
        /// <returns></returns>
        public static int GetWaterTypeIDByName(string waterType)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                return conn.List_WaterTypes.Where(x => x.WaterTypeName == waterType).Select(x => x.pk_WaterTypeID).FirstOrDefault();
            }
        }

        

        /// <summary>
        /// Get User Tanks from primary key
        /// </summary>
        /// <param name="pk">primary key to search Entities</param>
        /// <returns>Entity maching provided primary key</returns>
        public static UserTanks GetTankByPK(int pk)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.UserTanks.Where(x => x.pk_UserTankID == pk);

                if (a.Count() > 0)
                {
                    return a.First();
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Get User Tanks Entity from tank name
        /// </summary>
        /// <param name="tankName">name of the tank to search Entities</param>
        /// <returns>UserTank matching provided tank name</returns>
        public static UserTanks GetTankByName(string tankName)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.UserTanks.Where(x => x.TankDisplayName == tankName);

                if (a.Count() > 0)
                {
                    return a.First();
                }
                else
                {
                    return null;
                }
            }
        }



        /// <summary>
        /// Get User Fish Entity from primary key
        /// </summary>
        /// <param name="pk">primary key to search Entities</param>
        /// <returns>UserFish matching primary key</returns>
        public static UserFish GetFishByPK(int pk)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.UserFish.Where(x => x.pk_UserFishID == pk);

                if (a.Count() > 0)
                {
                    return a.First();
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Get a list of UserFish in a tank based on tank primary key
        /// </summary>
        /// <param name="tankPK">primary key of tank to search Entities</param>
        /// <returns>List of UserFish in tank matching primary key</returns>
        public static List<UserFishInventory> GetFishByTankPK(int tankPK)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.UserFishInventory.Where(x => x.fk_UserTank == tankPK);

                if (a.Count() > 0)
                {
                    return a.ToList();
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Get a list of UserFish which are alive and not assigned to a tank
        /// </summary>
        /// <returns>list of unassigned user fish</returns>
        public static List<UserFishInventory> GetUnassignedFish()
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.UserFishInventory.Where(x => x.fk_UserTank == 0);

                if (a.Count() > 0)
                {
                    return a.ToList();
                }
                else
                {
                    return null;
                }
            }
        }

    }
}
