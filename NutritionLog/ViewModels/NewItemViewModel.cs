using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using NutritionLog.Models;
using Xamarin.Forms;

namespace NutritionLog.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string date;
        private string weight;
        private string calories;
        private string protein;
        private string carbs;
        private string fat;

        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(date);
        }

        public string Date
        {
            get => date;
            set => SetProperty(ref date, value);
        }

        public string Weight
        {
            get => weight;
            set => SetProperty(ref weight, value);
        }

        public string Calories
        {
            get => calories;
            set => SetProperty(ref calories, value);
        }

        public string Protein
        {
            get => protein;
            set => SetProperty(ref protein, value);
        }

        public string Carbs
        {
            get => carbs;
            set => SetProperty(ref carbs, value);
        }
        public string Fat
        {
            get => fat;
            set => SetProperty(ref fat, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Item newItem = new Item()
            {
                Id = Guid.NewGuid().ToString(),
                Date = Date,
                Weight = Weight,
                Calories = Calories,
                Protein = Protein,
                Carbs = Carbs,
                Fat = Fat
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
