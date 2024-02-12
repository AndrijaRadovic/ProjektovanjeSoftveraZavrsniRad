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
        List<IEntity> GetReaderList(SqlDataReader reader);
        IEntity GetReaderResult(SqlDataReader reader);
        string GetParameters();
        void PrepareCommand(SqlCommand command);
        string UpdateQuery();
        string JoinQuery();
        string GetByIdQuery();
        string GetSearchAttributes();
        string GetFilterQuery();
        List<IEntity> ReadAllSearch();
    }
}
