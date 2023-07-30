internal class SqlServerConnector : IDatabaseConnector
{
    public IDatabaseConnection CreateConnection()
    {
        return new SqlServerConnection();
    }
}
