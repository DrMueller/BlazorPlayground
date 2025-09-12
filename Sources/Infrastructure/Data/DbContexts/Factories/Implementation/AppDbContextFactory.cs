using System.Diagnostics;
using BlazorPlayground.Infrastructure.Data.DbContexts.Contexts.Implementation;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace BlazorPlayground.Infrastructure.Data.DbContexts.Factories.Implementation;

public static class AppDbContextFactory
{
    public static AppDbContext Create()
    {
        var connectionString = "Filename=:memory:";

        var connection = new SqliteConnection(connectionString);
        connection.Open();
        connection.CreateFunction("newid", Guid.NewGuid);
        var options = new DbContextOptionsBuilder<AppDbContext>().UseSqlite(connection)
            .LogTo(f => { Debug.Write(f); }, LogLevel.Information)
            .EnableSensitiveDataLogging()
            .Options;

        var context = new AppDbContext(options);
        context.Database.EnsureCreated();

        return context;
    }
}