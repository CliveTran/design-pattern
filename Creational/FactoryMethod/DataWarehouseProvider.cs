internal class DataWarehouseProvider : DatabaseProvider
{
    public override Connection CreateConnection()
    {
        return new DataWarehouseConnection();
    }
}