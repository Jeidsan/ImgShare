using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ImgShareWebServices.Models;

namespace ImgShareWebServices.Models
{
    public class PhotoContext : DbContext
    {
        public PhotoContext (DbContextOptions<PhotoContext> options)
            : base(options)
        {
        }

        public DbSet<ImgShareWebServices.Models.Photo> Photo { get; set; }
    }
}
