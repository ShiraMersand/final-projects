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
    public class ProductController : ControllerBase
    {
        IProductBL _iProductBl;

        public ProductController(IProductBL iProductBl)
        {
            _iProductBl = iProductBl;
        }

        [HttpGet]
        public async Task< List<Products>> GetAllProduct()
        {
            return await _iProductBl.GetAllProduct();
        }


        [HttpGet("{id}/{name}")]
        public async Task< Products> GetProduct(int id , string name)
        {
            return await _iProductBl.GetProduct(id,name);
        }

        [HttpGet("{id}")]
        public async Task<List<Products>> GetProductsByCategoryId(int id)
        {
            return await _iProductBl.GetProductsByCategoryId(id);
        }
    }
}