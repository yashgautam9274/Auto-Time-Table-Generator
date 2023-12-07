using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BTPTT
{
    public class DatabaseLayer
    {
        public static SqlConnection conn;

        public static SqlConnection ConOpen()
        {
            try
            {
                if (conn == null)
                {
                    // give path inside SqlConnection
                    conn = new SqlConnection(@"Data Source=LAPTOP-TLV15M2F\SQLEXPRESS;Initial Catalog=abc;Integrated Security=True");
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                Console.WriteLine("connection is done");
                return conn;
            }
            catch (Exception)
            {
                Console.WriteLine("connection is not done");
                throw;
            }
        }

        public static bool Insert(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query,ConOpen());
                int rowaffected = cmd.ExecuteNonQuery();
                if(rowaffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing query: " + query);
                Console.WriteLine("Exception details: " + ex.Message);
                return false;
            }
        }

        public static bool Update(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, ConOpen());
                int rowaffected = cmd.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, ConOpen());
                int rowaffected = cmd.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static DataTable Retrive(string query)
        {
            
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query,ConOpen());
                da.Fill(dt);
                Console.WriteLine("Columns:");
                foreach (DataColumn column in dt.Columns)
                {
                    Console.Write(column.ColumnName + "\t");
                }
                Console.WriteLine();

                // Print data
                Console.WriteLine("Data:");
                foreach (DataRow row in dt.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine();
                }

                if (dt != null)
                {
                    if(dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                }
                return null;
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);
                return null;
            }
        }

    }
}
