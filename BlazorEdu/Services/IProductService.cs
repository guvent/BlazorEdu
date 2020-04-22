using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorEdu.Models;
using BlazorEdu.Pages;

namespace BlazorEdu.Services
{
    public interface IProductService
    {
        Task<ProductListViewModel[]> GetProducts();
        Task Add(ProductViewModel productListView);
        Task Save(ProductViewModel productListView);
        Task<ProductViewModel> GetProductsById(int productId);
    }
}
