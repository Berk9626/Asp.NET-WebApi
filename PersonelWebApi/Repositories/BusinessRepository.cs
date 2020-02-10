using PersonelWebApi.Context;
using PersonelWebApi.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static PersonelWebApi.Context.SirketContext;

namespace PersonelWebApi.Repositories
{
    public class BusinessRepository
    {
        public class RepCategories : BaseRepository<Categories>
        {
            public RepCategories(SirketContext db) : base(db)
            {

            }

            public async Task<ICollection<CategoriesDTO>> Doldur()
            {
                return await Set().Select(x => new CategoriesDTO
                {
                    CategoryId = x.CategoryId,
                    CategoryName = x.CategoryName
                }).ToListAsync();
            }
        }
        public class RepProducts : BaseRepository<Products>
        {
            public RepProducts(SirketContext db) : base(db)
            {
               
            }
            public async Task<ICollection<ProductsDTO>> Doldur()
            {
                return await Set().Select(x => new ProductsDTO
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    CategoryId = x.CategoryId,
                    UnitPrice = x.UnitPrice
                }).ToListAsync();
            }
            public async Task<ICollection<ProductsDTO>> Doldur(int id)
            {
                return await Set().Select(x => new ProductsDTO
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    CategoryId = x.CategoryId,
                    UnitPrice = x.UnitPrice
                }).Where(x=> x.CategoryId == id).ToListAsync();
            }
        }
        public class RepUser : BaseRepository<Users>
        {
            public RepUser(SirketContext db):base (db)
            {
                
            }
            public UserDTO Login (string UserId, string password)
            {
                UserDTO userDTO = new UserDTO();
                Users user = Set().Find(UserId);
                if (user.UserPassword == password && user.UserId == UserId)
                {
                    userDTO.UserId = user.UserId;
                    userDTO.RoleId = user.RoleId;
                }
                return userDTO;

            }
        }
    }
}
