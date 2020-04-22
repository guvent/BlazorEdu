using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorEdu.Models;
using BlazorEdu.Pages;

namespace BlazorEdu.Services
{
    public class ProductService:IProductService
    {
        private HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ProductListViewModel[]> GetProducts()
        {
            return await _httpClient.GetFromJsonAsync<ProductListViewModel[]>("get_url");
        }


        public async Task<ProductViewModel> GetProductsById(int productId)
        {
            return await _httpClient.GetFromJsonAsync<ProductViewModel>("get_url?productId="+productId.ToString());
        }

        public async Task Add(ProductViewModel productListView)
        {
            await _httpClient.PostAsJsonAsync("add_url", productListView);
        }

        public async Task Save(ProductViewModel productListView)
        {
            await _httpClient.PostAsJsonAsync("add_url", productListView);
        }

    }
}
