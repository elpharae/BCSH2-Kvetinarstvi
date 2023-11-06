using Oracle.ManagedDataAccess.Client;

public class ApplicationDBContext 
{ 
    
    private static string ConnectionString = "User Id=st67009;Password=xHeslo123;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fei-sql3.upceucebny.cz)(PORT=1521))(CONNECT_DATA=(SID=BDAS)(SERVER=DEDICATED)))";

    public static OracleConnection Connect()
    {
        return new OracleConnection(ConnectionString);
    }
    
}