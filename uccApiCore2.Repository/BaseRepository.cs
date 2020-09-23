using System;
using System.Data;
using System.Data.SqlClient;


namespace uccApiCore2.Repository
{
    public abstract class BaseRepository : IDisposable
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            //string connectionString = "Data Source=148.72.232.166;Initial Catalog=Ecomm;User ID=sonu;Password=password_1234;";

            //string connectionString = "Data Source=iZa2d33r7fn1r1Z\\SQLEXPRESS;Initial Catalog=EcommChair;User ID=sa;Password=password_1234;";

            string connectionString = "Data Source=148.72.232.168;Initial Catalog=EcommChair;User ID=EcommChair;Password=password_1234;";

            con = new SqlConnection(connectionString);
        }


        public void Dispose()
        {
            con.Close();
            //throw new NotImplementedException();
        }
    }
}
