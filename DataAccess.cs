using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Library_Management_System
{
    class DataAccess
    {
        public int InsertIntoBookIssuanceTable(string Student_Name, string Department, string Roll_No, string Category, string Book_Name, DateTime Issuance_Date, DateTime Due_Date)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbConnectionString")))
            {
                int value = connection.Execute("insert into BookIssuanceTable values('" + Student_Name + "', '" + Department + "', '" + Roll_No + "', '" + Category + "', '" + Book_Name + "' , '" + Issuance_Date + "', '" + Due_Date + "')");

                return value;
            }
        }
        public List<IssuanceClass> GetAllData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbConnectionString")))
            {
                var value = connection.Query<IssuanceClass>("select * from BookIssuanceTable").ToList();

                return value;
            }
        }
    }
}
