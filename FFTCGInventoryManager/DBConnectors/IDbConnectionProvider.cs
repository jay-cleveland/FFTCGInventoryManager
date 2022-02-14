using System.Data.Common;

namespace FFTCGInventoryManager.DBConnectors
{
    public interface IDbConnectionProvider
    {
        DbConnection GetConnection();
    }
}
