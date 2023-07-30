internal class Program
{
    private static void Main(string[] args)
    {
        IDatabaseConnector connector = CreateConnector("SQLServer");
        IDatabaseConnection connection = connector.CreateConnection();
        connection.Connect();
        connection.Query("query");
    }

    private static IDatabaseConnector CreateConnector(string dbType)
    {
        switch (dbType)
        {
            case "SQLServer":
                return new SqlServerConnector();
            case "DWH":
                return new DataWarehouseConnector();
            default:
                throw new Exception("Connector was not found.");
        }
    }
}

