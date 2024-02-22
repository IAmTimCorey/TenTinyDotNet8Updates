using MinimalApiDemo.DataAccess;

namespace MinimalApiDemo;

public class OtherDemo([FromKeyedServices("SQL")] ISql db)
{
    private readonly ISql db = db;

    public string PrintMessage()
    {
        return $"This is from the other demo. The connection string is '{db.OpenConnection()}'";
    }
}
