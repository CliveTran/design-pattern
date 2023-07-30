internal interface IDatabaseConnection
{
    void Connect();
    void Query(string Query);
}