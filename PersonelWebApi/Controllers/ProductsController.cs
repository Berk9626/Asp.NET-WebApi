using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonelWebApi.DTOs;
using static PersonelWebApi.Repositories.BusinessRepository;

namespace PersonelWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        RepProducts _repProducts;
        public ProductsController(RepProducts repProducts)
        {
            _repProducts = repProducts;
        }
        [HttpGet]
        public async Task<ICollection<ProductsDTO>> GetProducts()
        {
            // sesiondan ROLe al  
            return await _repProducts.Doldur();

        }
        [HttpGet("{catid}")]
        public async Task<ICollection<ProductsDTO>> GetProducts(int catid)
        {
            return await _repProducts.Doldur(catid);
        }
       
        
    }
}