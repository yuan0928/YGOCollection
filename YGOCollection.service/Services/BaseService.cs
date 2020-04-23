using System.Data;
using YGOCollection.library.Model;

namespace YGOCollection.service.Services
{
    public class BaseService : IDbConnection
    {
        /// <summary>
        /// 資料庫連線
        /// </summary>
        protected YGOCardInfoEntities Db;
        /// <summary>
        /// 建構子
        /// </summary>
        protected BaseService()
        {
            Db = YGOCardInfoEntities.CreateDbContext();

            Db.Database.CommandTimeout = 120;
        }

        public string ConnectionString { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public int ConnectionTimeout => throw new System.NotImplementedException();

        public string Database => throw new System.NotImplementedException();

        public ConnectionState State => throw new System.NotImplementedException();

        public IDbTransaction BeginTransaction()
        {
            throw new System.NotImplementedException();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeDatabase(string databaseName)
        {
            throw new System.NotImplementedException();
        }

        public void Close()
        {
            throw new System.NotImplementedException();
        }

        public IDbCommand CreateCommand()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void Open()
        {
            throw new System.NotImplementedException();
        }
    }
}
