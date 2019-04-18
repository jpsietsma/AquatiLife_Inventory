using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ext
{
    public static class UserTankExt
    {
        public static char RunCompatabilityTest_WaterType( int _tank, string _plant)
        {
            char _final = 'P';

            

            return _final;
        }

        public static char RunCompatabilityTest_Temperature(this UserTanks _tank, UserLivePlants _plant)
        {
            char _final = 'P';



            return _final;
        }

        public static char RunCompatabilityTest_TankSize(this UserTanks _tank, UserLivePlants _plant)
        {
            char _final = 'F';



            return _final;
        }

        public static char RunCompatabilityTest_Lighting(this UserTanks _tank, UserLivePlants _plant)
        {
            char _final = 'F';



            return _final;
        }

        public static char RunCompatabilityTest_Substrate(this UserTanks _tank, UserLivePlants _plant)
        {
            char _final = 'F';



            return _final;
        }
    }
}
