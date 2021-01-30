using System;
using System.Collections.Generic;
using NutritionLog.ViewModels;
using NutritionLog.Views;
using Xamarin.Forms;

namespace NutritionLog
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(ItemsPage), typeof(ItemsPage));
        }

    }
}
