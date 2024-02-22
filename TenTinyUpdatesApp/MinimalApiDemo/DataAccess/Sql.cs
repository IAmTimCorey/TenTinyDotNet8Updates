namespace MinimalApiDemo.DataAccess;

public class Sql(IConfiguration config) : ISql
{
    private readonly IConfiguration config = config;

    public string OpenConnection()
    {
        return config.GetConnectionString("SQL") ?? "";
    }
}
