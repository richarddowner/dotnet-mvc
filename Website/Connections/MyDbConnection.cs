using System.Data;

namespace Website.Connections
{
    public class MyDbConnection : BaseConnection
    {
        public override IDbConnection Open()
        {
            return OpenDatabase("MyDb");
        }
    }
}