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
	}
}
