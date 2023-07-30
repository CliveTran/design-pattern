internal class DataWarehouseConnection : IDatabaseConnection
{
    public void Connect()
    {
        System.Console.WriteLine("Connected to Data Warehouse.");
    }

    public void Query(string Query)
    {
        System.Console.WriteLine("Executing Data Warehouse query...");
        System.Console.WriteLine("Data Warehouse query executed successfully.");
    }
}