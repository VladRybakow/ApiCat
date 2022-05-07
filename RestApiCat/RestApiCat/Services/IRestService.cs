using RestApiCat.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestApiCat.Services
{
    public interface IRestService
    {
        Task<List<EntryModel>> GetDataAsync();
    }
}
