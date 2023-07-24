using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Sentence.Construction.Repository
{
    public class BaseRepository
    {
        public IDbConnection DapperConnection
        {
            get { return new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ToString()); }
        }
    }
}
