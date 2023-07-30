internal class DataWarehouseConnection : Connection
{
    public override void Connect()
    {
        System.Console.WriteLine("Connected to DWH Server.");
    }

    public override void Query(string Query)
    {
        System.Console.WriteLine("Executing DWH query...");
        System.Console.WriteLine("DWH query executed successfully.");
    }
}