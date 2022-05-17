using RestApiCat.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestApiCat.Services
{
    public class EntryManager
    {
		IRestService restService;

		public EntryManager(IRestService service)
		{
			restService = service;
		}

		public Task<List<EntryModel>> GetTasksAsync()
		{
			return restService.GetDataAsync();
		}
		public Task DeleteTodoAsync(EntryModel item)
		{
			return restService.DeleteTodoItemAsync(item);
		}
		public Task SaveItemAsync(EntryModel todoItem, bool isNewItem = false)
		{
			return restService.SaveTodoItemAsync(todoItem, isNewItem);
		}
	}
}
