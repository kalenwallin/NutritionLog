using System;
using System.Collections.Generic;
using System.ComponentModel;
using NutritionLog.Models;
using NutritionLog.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NutritionLog.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}