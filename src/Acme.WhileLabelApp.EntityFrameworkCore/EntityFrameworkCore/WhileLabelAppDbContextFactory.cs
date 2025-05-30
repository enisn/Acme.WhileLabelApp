using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.WhileLabelApp.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class WhileLabelAppDbContextFactory : IDesignTimeDbContextFactory<WhileLabelAppDbContext>
{
    public WhileLabelAppDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        WhileLabelAppEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<WhileLabelAppDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new WhileLabelAppDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.WhileLabelApp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
