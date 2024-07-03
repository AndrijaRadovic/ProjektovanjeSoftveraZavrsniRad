using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IEntity
    {
        string TableName { get; }
        string DisplayValue { get; }
        string PrimaryKey { get; }
        object IdColumn { get; }

        List<IEntity> GetReaderList(SqlDataReader reader);
        IEntity GetReaderResult(SqlDataReader reader);
        string GetParameters(bool parent = false);
        void PrepareCommand(SqlCommand command, bool parent = false);
        string UpdateQuery(string field = "");
        string JoinQuery();
        string GetByIdQuery(string use = "");
        string GetSearchAttributes();
        string GetFilterQuery(string filter);
        List<IEntity> ReadAllSearch(SqlDataReader reader);
        //string LoginQuery();
        string GetTableName(bool parent = false);

    }
}
