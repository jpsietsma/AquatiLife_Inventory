using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ViewModelClasses.Fish
{
    public class UserFishViewModel
    {
        public string FriendlyName { get; set; }
        public string ImagePath { get; set; }
        public string TankName { get; set; }

        public BitmapImage FishImage { get { return new BitmapImage(new Uri(@"..\" + ImagePath, UriKind.Relative)); } }

    }
}
