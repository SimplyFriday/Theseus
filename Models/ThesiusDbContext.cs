using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class TheseusDbContext : DbContext
{
    // public DbSet<Blog> Blogs { get; set; }
    // public DbSet<Post> Posts { get; set; }

    public string DbPath { get; }

    public TheseusDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "thesius.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
