using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AquatiLife_Inventory_DataAccess.ViewModels.Authentication;

namespace AquatiLife_Test_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //FishTank tank = new FishTank("Rocky's Home", 29.99, DateTime.Now, Locations.LIVINGSTON_ANIMAL_KINGDOM, 55.00);           

            //Lobster fish = new Lobster("Rocky", 19.99, DateTime.Now, Locations.PETCO);
            //    fish.Size = 12.5;
            //    fish.PrimaryColor = Colors.White;
            //    fish.SecondaryColor = Colors.White;

            //Lobster fish1 = new Lobster("Shelly", 19.99, DateTime.Now, Locations.PETCO);
            //    fish.Size = 12.5;
            //    fish.PrimaryColor = Colors.Black;
            //    fish.SecondaryColor = Colors.Orange;

            //Lobster fish2 = new Lobster("Numbskull", 19.99, DateTime.Now, Locations.PETCO);
            //    fish.Size = 12.5;
            //    fish.PrimaryColor = Colors.Red;
            //    fish.SecondaryColor = Colors.White;

            //tank.AddLiveFish(fish);
            //tank.AddLiveFish(fish1);
            //tank.AddLiveFish(fish2);

            //Console.WriteLine("Tank Info {" + tank.DisplayName + "}");
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("- Purchase Date: " + tank.PurchaseDate);
            //Console.WriteLine("- Purchase Store: " + tank.PurchaseLocation);
            //Console.WriteLine("- Purchase Price: " + tank.PurchasePrice);
            //Console.WriteLine();
            //Console.WriteLine("\t Tank Health");
            //Console.WriteLine("\t ---------------------------------");
            //Console.WriteLine("\t - pH Level: " + tank.pHLevel);
            //Console.WriteLine("\t - General Hardness Level: " + tank.GeneralHardnessLevel);
            //Console.WriteLine("\t - Carbonate Hardness Level: " + tank.CarbonateHardnessLevel);
            //Console.WriteLine("\t - Nitrite Level: " + tank.NitriteLevel);
            //Console.WriteLine("\t - Nitrate Level: " + tank.NitrateLevel);
            //Console.WriteLine();
            //Console.WriteLine("\t Fish Inventory: ");
            //Console.WriteLine("\t --------------------------------------");

            //foreach (ILiveFish tankFish in tank.TankFishInventory)
            //{
            //    Console.WriteLine("\t\t" + tankFish.CommonName + " (" + tankFish.ScientificName + ")");
            //    Console.WriteLine("\t\t ---------------------------------");
            //    Console.WriteLine("\t\t - Fish Name: " + tankFish.Name);
            //    Console.WriteLine("\t\t - Primary Color: " + tankFish.PrimaryColor.ToString());
            //    Console.WriteLine("\t\t - Secondary Color: " + tankFish.SecondaryColor.ToString());
            //    Console.WriteLine("\t\t - Purchased At: " + tankFish.PurchaseLocation);
            //    Console.WriteLine("\t\t - Max Safe Temp: " + tankFish.FishMaxTemp + "°c");
            //    Console.WriteLine("\t\t - Min Safe Temp: " + tankFish.FishMinTemp + "°c");
            //    Console.WriteLine("\t\t - Max Safe pH level: " + tankFish.FishMaxPH);
            //    Console.WriteLine("\t\t - Min Safe pH Level: " + tankFish.FishMinPH);
            //    Console.WriteLine("\t\t - Max Size: " + tankFish.GetMaxSizeCM() + "cm (" + tankFish.GetMaxSizeInch() + "in)");
            //    Console.WriteLine();
            //}

            //Console.ReadLine();

            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine(UserLoginAccess.CheckUserPass("jpsietsma", @"A!12@lop^6"));

            //AuthenticatedUserSession _session = new AuthenticatedUserSession("jpsietsma");
            //List<string> perms = _session.GetUserPermissions();

            UserSession _test = new UserSession() { SessionBegin = DateTime.Now.Subtract(new TimeSpan(0, 2, 45, 0)) };
            var testtest = _test.ToString();
            Console.WriteLine("Length: " + _test.GetSessionLength());
            Console.ReadLine();

        }
    }
}
