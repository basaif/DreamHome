using System.Data;

namespace DreamHome
{
    interface IDBConnection
    {
        void connectDB();
        void Insert_Update_deleteDB(string Query);
        DataSet SelectDB(string Query, string TableName);
    }
}