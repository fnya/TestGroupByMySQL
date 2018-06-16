using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace TestGroupByMySQL.Models
{
    public class MyContext : DbContext
    {
        public MyContext() 
        {

        }
        public MyContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Result> Result { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLoggerFactory(MyLoggerFactory)
                    .UseMySQL("server=localhost;userid=root;password=password;database=consolegroupby;");
            }
        }

        public static readonly LoggerFactory MyLoggerFactory
            = new LoggerFactory(new[]
            {
                new ConsoleLoggerProvider((category, level)
                    => category == DbLoggerCategory.Database.Command.Name
                    && level == LogLevel.Information, true)
            });

    }

        public class GroupByContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySQL("server=localhost;userid=root;password=password;database=consolegroupby;");
            

            return new MyContext(optionsBuilder.Options);
        }
    }
}