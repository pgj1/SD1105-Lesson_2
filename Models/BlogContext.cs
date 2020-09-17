using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson2_DailyBlogger.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson2_DailyBlogger.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<BlogPost> blogPost { get; set; }
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }
    }
}
