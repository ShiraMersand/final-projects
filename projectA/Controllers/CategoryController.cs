using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace projectA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryBL _iCategoryBl;
        public CategoryController(ICategoryBL iCategoryBL)
        {
            _iCategoryBl = iCategoryBL;
        }

        [HttpGet("{id}")]
        public async  Task<Category> GetCategory(int id)
        {
            return await _iCategoryBl.GetCategory(id);
        }

        [HttpGet]
        public async Task<List<Category>> GetAllCategory()
        {
            return await _iCategoryBl.GetAllCategory();
        }




    }
}