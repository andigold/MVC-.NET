using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserRestaurnats3.Entities;

namespace UserRestaurnats3.Database
{
    public class DataStorage : DbContext
    {
        public DataStorage(DbContextOptions<DataStorage> options)
                : base(options)
        { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Food> Foods { get; set; }

    }
}
