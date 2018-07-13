using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ImgShare.Domain;

namespace ImgShare.Service.Data
{
    public class ImgShareContext : DbContext
    {
        public ImgShareContext(DbContextOptions<ImgShareContext> options)
            : base(options)
        {
        }

        public DbSet<ImgShare.Domain.Photo> Photo { get; set; }

        public static void Initialize(ImgShareContext context)
        {
            context.Database.EnsureCreated();
        }

        public DbSet<ImgShare.Domain.User> User { get; set; }
    }
}
