using System;
using AquaModClasses.PurchaseOptions;

namespace AquaModClasses.BaseClassModels
{
    public interface ITankAccessory
    {
        int AccessoryID { get; set; }
        string DisplayName { get; set; }
        DateTime PurchaseDate { get; set; }
        Locations PurchaseLocation { get; set; }
        double PurchasePrice { get; set; }
        string Purchaser { get; set; }
        int TankID { get; set; }
    }
}