using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelWebApi.Context
{
    public class SirketContext:DbContext
    {
        public SirketContext(DbContextOptions<SirketContext> option):base(option)
        {

        }
        public DbSet<Categories> categories { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Employees> employees { get; set; }
        public DbSet<Customers> customers { get; set; }
        public DbSet<Suppliers> suppliers { get; set; }
        public DbSet<Roles> roles { get; set; }
        public class Categories
        {
            [Key]
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
            public ICollection<Products> Plist { get; set; }
        }
        public class Products
        {
            [Key]
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
            public string  SupplierId { get; set; }
            public int CategoryId { get; set; }
             [ForeignKey("CategoryId")]

            public Categories Categories { get; set; }
            [ForeignKey("SupplierId")]
            public Suppliers Suppliers { get; set; }

        }
        public class Users
        {
            [Key]
            public string UserId { get; set; }
            public string UserName { get; set; }
            public string UserPassword { get; set; }
            public string RoleId { get; set; }
             [ForeignKey("RoleId")]
            public Roles Roles { get; set; }
           
            public Customers Customers { get; set; }
            
            public Employees Employees { get; set; }
           
            public Suppliers Suppliers { get; set; }
        }
        public class Customers
        {
            [Key]
            public string CustomerId { get; set; }
            public string VD { get; set; }
            [ForeignKey("CustomerId")]
            public Users Users { get; set; }
        }
        public class Suppliers
        {
            [Key]
            public string SupplierId{ get; set; }
            public string VD { get; set; }
            [ForeignKey("SupplierId")]
            public Users  Users { get; set; }
            public ICollection<Products > Plist { get; set; }
        }

        public class Employees
        {
            [Key]
            public string EmployeeId { get; set; }
            public long TRIdentity { get; set; }
            [ForeignKey("EmployeeId")]
            public Users Users { get; set; }
        }
        public class Roles
        {
            [Key]
            public string RoleId { get; set; }
            public string RoleName { get; set; }
             public ICollection<Users> Ulist { get; set; }

        }

    }
}
