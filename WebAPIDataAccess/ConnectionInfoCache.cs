using System.Collections.Generic;
using System.Data;
using WebAPIDataAccess.WireSecurity;

namespace WebAPIDataAccess
{
    public static class ConnectionInfoCache
    {
        private static readonly object cacheLock = new object();
        private static readonly Dictionary<string, DataTable> connectionInfoCache = new Dictionary<string, DataTable>();

        public static DataTable GetOrAddToCache(string dbName, int environmentId, int appId)
        {
            string cacheKey = $"{dbName}_{environmentId}_{appId}";

            lock (cacheLock)
            {
                if (connectionInfoCache.TryGetValue(cacheKey, out DataTable cachedDataTable))
                {
                    return cachedDataTable;
                }

                DataTable dt = new DAConfigParam().GetConnectionInformation(dbName, environmentId, appId);

                if (dt.Rows.Count > 0)
                {
                    connectionInfoCache[cacheKey] = dt;
                    return dt;
                }

                return null;
            }
        }
    }
}
