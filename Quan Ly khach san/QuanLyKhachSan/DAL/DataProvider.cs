using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
  public class DataProvider
    {

        private static readonly DataProvider instance;

        public static DataProvider Instance

        {
            get { if (instance == null) return new DataProvider(); return DataProvider.instance; }
        }

        private DataProvider()
        {
        }

        private readonly string strCon = @"SERVER=DESKTOP-4ICDD5V\SQLEXPRESS;Database=QLBH;User Id = test; pwd=0949238337";
        private void hasParameter(SqlCommand cmd, string query, object[] para = null)
        {
            int i = 0;
            foreach (string parameter in query.Split(' ').ToArray().Where(p => p.Contains('@')))
            {
                cmd.Parameters.AddWithValue(parameter, para[i]);

                i++;
            }


        }


        public DataTable ExcuteDataReader(string query, object[] para = null)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    DataTable data = new DataTable();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (para != null)
                    {

                        {
                            hasParameter(cmd, query, para);
                        }

                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                    return data;

                }
            }
            catch (Exception err)
            {
                throw err;
            }

        }
        public bool ExcuteNonQuery(string query, object[] para = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    int kq = 0;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (para != null)
                    {
                        hasParameter(cmd, query, para);
                    }
                    kq = cmd.ExecuteNonQuery();
                    return kq > 0;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public int ExcuteScalar(string query, object[] para = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    int count;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (para != null)
                    {

                        hasParameter(cmd, query, para);
                    }
                    count = (int)cmd.ExecuteScalar();
                    return count;

                }
            }

            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
