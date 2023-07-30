internal class SqlServerConnection : IDatabaseConnection
{
    public void Connect()
    {
        System.Console.WriteLine("Connected to SQL Server.");
    }

    public void Query(string Query)
    {
        System.Console.WriteLine("Executing SQL Server query...");
        System.Console.WriteLine("SQL Server query executed successfully.");
    }
}