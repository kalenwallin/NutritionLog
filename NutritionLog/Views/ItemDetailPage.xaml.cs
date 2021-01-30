using System.ComponentModel;
using NutritionLog.ViewModels;
using Xamarin.Forms;

namespace NutritionLog.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}