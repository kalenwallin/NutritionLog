using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NutritionLog.Models;

namespace NutritionLog.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Date = "Date", Weight="Weight", Calories="Calories", Protein="Protein", Carbs="Carbs", Fat="Fat"},
                new Item { Id = Guid.NewGuid().ToString(), Date = "Date 2", Weight="Weight 2", Calories="Calories 2", Protein="Protein 2", Carbs="Carbs 2", Fat="Fat 2" },
                new Item { Id = Guid.NewGuid().ToString(), Date = "Date 3", Weight="Weight 3", Calories="Calories 3", Protein="Protein 3", Carbs="Carbs 3", Fat="Fat 3" },
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}