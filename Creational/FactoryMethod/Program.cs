internal class Program
{
    private static void Main(string[] args)
    {
        DatabaseProvider provider = CreateProvider("SQLServer");
        Connection connection = provider.CreateConnection();
        connection.Connect();
        connection.Query("query");
    }

    private static DatabaseProvider CreateProvider(string dbType)
    {
        switch (dbType)
        {
            case "SQLServer":
                return new SqlServerProvider();
            case "DWH":
                return new DataWarehouseProvider();
            default:
                throw new Exception("Provider was not found.");
        }
    }
}

