using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonelWebApi.DTOs;
using PersonelWebApi.Context;
using static PersonelWebApi.Repositories.BusinessRepository;

namespace PersonelWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        RepCategories _repCat;
        public CategoriesController(RepCategories repCat)
        {
            _repCat = repCat;
        }
        [HttpGet]
       public async Task<ICollection<CategoriesDTO>> GetCategories()
        {
            return await _repCat.Doldur();
        }
    }
}