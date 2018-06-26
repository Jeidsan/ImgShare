using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ImgShareWebServices.Models
{
    public class ImgShareContext : DbContext
    {
        public ImgShareContext (DbContextOptions<ImgShareContext> options)
            : base(options)
        {
        }

        public DbSet<ImgShareWebServices.Models.Photo> Photo { get; set; }
        public DbSet<ImgShareWebServices.Models.User> User { get; set; }
    }
}
