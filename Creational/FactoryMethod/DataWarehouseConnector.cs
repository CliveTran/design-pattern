internal class DataWarehouseConnector : IDatabaseConnector
{
    public IDatabaseConnection CreateConnection()
    {
        return new DataWarehouseConnection();
    }
}
