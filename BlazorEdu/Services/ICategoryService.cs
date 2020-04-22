using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorEdu.Models;

namespace BlazorEdu.Services
{
    public interface ICategoryService
    {
        Task<CategoryListViewModel[]> GetCategories();
    }
}
