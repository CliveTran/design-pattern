internal class SqlServerProvider : DatabaseProvider
{
    public override Connection CreateConnection()
    {
        return new SqlServerConnection();
    }
}
