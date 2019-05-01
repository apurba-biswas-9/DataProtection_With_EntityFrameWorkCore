using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DataProtection
{
    public class DataProtectionDbContextFactory : IDesignTimeDbContextFactory<MyKeysContext>
    {
        public MyKeysContext CreateDbContext(string[] args)
        {
            var deploymentType = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", EnvironmentVariableTarget.Machine);

            var currentDirectory = Directory.GetCurrentDirectory();

            var configuration = new ConfigurationBuilder()
                .AddJsonFile($"{currentDirectory}\\appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<MyKeysContext>();
            optionsBuilder.UseSqlite(connectionString);

            return new MyKeysContext(optionsBuilder.Options);
        }
    }
}
