using System;
using Microsoft.EntityFrameworkCore;

namespace Kvetinarstvi.Models;

public class DatabaseContext : DbContext { 
    private static string ConnectionString = "User Id=st67009;Password=xHeslo123;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fei-sql3.upceucebny.cz)(PORT=1521))(CONNECT_DATA=(SID=BDAS)(SERVER=DEDICATED)))";

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        
    }
    
    public DbSet<Zakaznik
}