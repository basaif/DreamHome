using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;



namespace DreamHome
{
    class DBConnection : IDBConnection
    {
        SqlConnection con;
        string path = Application.StartupPath;
        DataSet ds;

        public void connectDB()
        {
            try
            {
                string connectionString = $@"Data Source=(localdb)\mssqllocaldb;AttachDbFilename={AppDomain.CurrentDomain.BaseDirectory}DreamHomeDatabase.mdf;Initial Catalog=DreamHomeDatabase;Integrated Security=True";
                string Sub_path = path.Substring(0, path.LastIndexOf(@"\bin") + 1);
                //TxtName.Text = path;
                con = new SqlConnection(connectionString);
            }
            catch (Exception Error)
            {

                MessageBox.Show(Error.Message);

            }
        }
        public DataSet SelectDB(string Query, string TableName)
        {
            try
            {
                SqlDataAdapter adpat = new SqlDataAdapter(Query, con);

                ds = new DataSet();

                con.Open();
                adpat.Fill(ds, TableName);

                con.Close();

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            return ds;
        }
        public void Insert_Update_deleteDB(string Query)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandType = CommandType.Text;
                comm.CommandText = Query;
                con.Open();
                comm.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
    }
}
