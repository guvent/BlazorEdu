using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorEdu.Models;

namespace BlazorEdu.Services
{
    public class CategoryService:ICategoryService
    {
        private HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CategoryListViewModel[]> GetCategories()
        {
            return await _httpClient.GetFromJsonAsync<CategoryListViewModel[]>("get_category_url");
        }
    }
}
