using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Telerik.Windows.Controls;
using WFP_AquatiLife_Inventory_UI.UserControls;

namespace WFP_AquatiLife_Inventory_UI.Screens
{
    /// <summary>
    /// Interaction logic for PurchaseHistory.xaml
    /// </summary>
    public partial class PurchaseHistory : Window
    {
        public PurchaseHistory()
        {            
            InitializeComponent();

            Title = $@"User Purchase History";

        }
    }
}
