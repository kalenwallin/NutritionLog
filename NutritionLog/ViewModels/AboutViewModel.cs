using System;
using System.Windows.Input;
using NutritionLog.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace NutritionLog.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Home";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            OnButtonPressedCommand = new Command(OnButtonPressed);
        }

        public ICommand OpenWebCommand { get; }
        public Command OnButtonPressedCommand { get; }

        private async void OnButtonPressed(object obj)
        {
            await Shell.Current.GoToAsync(nameof(ItemsPage));
        }
    }
}