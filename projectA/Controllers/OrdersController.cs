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
    public class OrdersController : ControllerBase
    {
        IOrderBL _iOrderBL;
        public OrdersController(IOrderBL iOrderBL)
        {
            _iOrderBL = iOrderBL;
        }

        [HttpGet("{id}")]
        public async Task< Orders> GetOrder(int id)
        {
            return await _iOrderBL.Getorders(id);
        }

        [HttpPost]
        public async Task<int> PostOrder([FromBody]Orders orders)
        {
             await _iOrderBL.PostOrder(orders);
            return orders.orderId;
        }

    }
}