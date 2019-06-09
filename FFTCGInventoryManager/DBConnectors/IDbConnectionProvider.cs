using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.DBConnectors
{
    public interface IDbConnectionProvider
    {
        DbConnection GetConnection();
    }
}
