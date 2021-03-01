
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCatererApp.Models;

namespace EntityLayerModel.DataAccess
{
   public class CatererDbContext: DbContext
    {

        public CatererDbContext(DbContextOptions<CatererDbContext> options) : base(options)
        {

        }
        

        public DbSet <Caterer> Caterers { get; set; }
        public DbSet <CatererDetails> CatererDetails { get; set; }
        public DbSet <Menu> Menus { get; set; }
        public DbSet <Dish> Dishes { get; set; }
        public DbSet <Customer> Customers { get; set; }
        public DbSet <Chat> Chats { get; set; }
    }
}
