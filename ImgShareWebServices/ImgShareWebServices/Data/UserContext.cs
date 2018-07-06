using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ImgShareWebServices.Models;

namespace ImgShareWebServices.Models
{
    public class UserContext : DbContext
    {
        public UserContext (DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<ImgShareWebServices.Models.User> User { get; set; }
    }
}
