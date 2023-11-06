using System.Data.SqlClient;


namespace DZ3.Model
{
    
    internal class DBManager
    {
        public SqlConnection OpenDbConnection(){
            string connectionString =@"
             Data Source=DESKTOP-AIP99RQ\SQLEXPRESS;
             Initial Catalog=VegetablesAndFruits;
             Integrated Security=SSPI;
            ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            return sqlConnection;
          
        }
        
    }
}

