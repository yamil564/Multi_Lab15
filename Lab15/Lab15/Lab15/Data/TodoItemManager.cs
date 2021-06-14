using Lab15.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Data
{
    public class TodoItemManager
    {
        IRestService restService;

        public TodoItemManager(IRestService service)
        {
            restService = service;
        }

        public Task<List<TodItem>> GetTaskAsync()
        {
            return restService.RefreshDataAsync();
        }

        public Task SaveTaskAsync (TodItem item, bool isNewItem = false)
        {
            return restService.SaveTodoItemAsync(item, isNewItem);
        }

        public Task DeleteTaskAsync (TodItem item)
        {
            return restService.DeleteTodoItemAsync(item.ID);
        }
    }
}
