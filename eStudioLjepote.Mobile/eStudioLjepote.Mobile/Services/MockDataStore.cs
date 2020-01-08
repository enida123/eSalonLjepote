using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eStudioLjepote.Mobile.Models;

namespace eStudioLjepote.Mobile.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dobro došli u Beauty Salon Allure Sarajevo", Description=" Naša inspiracija je ljepota a ljepota se čuva i njeguje. Nasa misija je u revitalizirati i očuvati vase ljepotu i vitalnost. Beauty salon Allure na usluzi je damama kroz  tretmane za njegu ženske ljepote  ali i za gospodu tretmanima osmišlljenim samo za njih         Beauty salon Allure na usluzi je damama kroz  tretmane za njegu ženske ljepote  ali i za gospodu tretmanima osmišlljenim samo za njih." },
                
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
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