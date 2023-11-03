using System;
using Oracle.ManagedDataAccess.Client;
using Tmds.DBus.Protocol;

namespace Kvetinarstvi.Models;

public class DatabaseConnector {
    
    public static OracleConnection Connect() 
    { 
        string connectionString = "User Id=st67009;Password=xHeslo123;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fei-sql3.upceucebny.cz)(PORT=1521))(CONNECT_DATA=(SID=BDAS)(SERVER=DEDICATED)))";
        OracleConnection con = new(connectionString);
        con.Open();
        
        Console.WriteLine("Connected to " + con.DatabaseName);
        return con;
    }

    public void Close()
    {
        OracleConnection connection = Connect();
        connection.Close();
    }
    
}