using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace blog.Models
{
    public class TextContext : DbContext
    {
        public TextContext (DbContextOptions<TextContext> options)
            : base(options)
        {
        }

        public DbSet<blog.Models.Text> Text { get; set; }
    }
}
