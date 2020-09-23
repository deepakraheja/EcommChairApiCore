﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using uccApiCore2.Entities;

namespace uccApiCore2.BAL.Interface
{
    public interface ICategoryBAL
    {
        Task<List<Category>> GetMainCategory(Category obj);
        Task<List<Category>> GetAllMainCategory(Category obj);
        Task<int> SaveMainCategory(Category obj);
        Task<List<Category>> GetCategory(Category obj);
        Task<List<Category>> GetAllCategory(Category obj);
        Task<int> SaveCategory(Category obj);
        Task<List<Category>> GetSubCategory(Category obj);
        Task<List<Category>> GetAllSubCategory(Category obj);
        Task<int> SaveSubCategory(Category obj);
        Task<List<MainCategoryJson>> SelecteMainCategoryforJson();

        Task<List<CategoryJson>> SelecteCategoryforJson(int MaincategoryId);
        Task<List<SubCategoryJson>> SelecteSubCategoryforJson(int CategoryId);
    }
}

