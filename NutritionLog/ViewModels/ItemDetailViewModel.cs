using System;
using System.Diagnostics;
using System.Threading.Tasks;
using NutritionLog.Models;
using Xamarin.Forms;

namespace NutritionLog.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string date;
        private string weight;
        private string calories;
        private string protein;
        private string carbs;
        private string fat;
        public string Id { get; set; }

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

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Date = item.Date;
                Weight = item.Weight;
                Calories = item.Calories;
                Protein = item.Protein;
                Carbs = item.Carbs;
                Fat = item.Fat;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
