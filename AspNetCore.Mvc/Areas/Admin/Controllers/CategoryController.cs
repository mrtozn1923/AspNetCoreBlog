﻿using AspNetCoreBlog.Services.Abstract;
using AspNetCoreBlog.Shared.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var result=await _categoryService.GetAll();
            
            return View(result.Data);
        }
    }
}
