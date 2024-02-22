namespace MinimalApiDemo.DataAccess;

public class MySql(IConfiguration config) : ISql
{
    private readonly IConfiguration config = config;

    public string OpenConnection()
    {
        return config.GetConnectionString("MySQL") ?? "";
    }
}
