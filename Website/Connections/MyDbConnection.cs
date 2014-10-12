using System.Data;

namespace Website.Connections
{
    public class MyDbConnection : PostgreSqlConnectionBase
    {
        public override IDbConnection Open()
        {
            return OpenDatabase("MyDb");
        }
    }
}