using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace LSBoard
{
    public class GlobalCS
    {
        public static bool CheckUser()
        {
            string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];            
            if (user == "ijung") return true;
            else return false;
        }
        public static void print_DataTable(DataTable dt, int header = 1)
        {
            // header = 1 -> Print header, header = 0 -> No print header
            int m = dt.Columns.Count; // number of column
            int n = dt.Rows.Count; // number of row

            string[] line = new string[m];
            string[] result = new string[n + header];
            if (header == 1)
            {
                //result[0] = "\t" + String.Join("\t", names(dt));
                List<String> list_col = new List<String>();
                foreach (DataColumn col in dt.Columns)
                {
                    list_col.Add(col.ColumnName);
                }
                result[0] = "\t" + String.Join("\t", list_col);

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    line[j] = dt.Rows[i][j].ToString();
                result[i + header] = i + "\t" + String.Join("\t", line);
            }
            foreach (var e in result)
            {
                Debug.WriteLine(e);
            }
        }
    }

    public class MySQL_Class
    {
        public MySqlConnection conn { get; set; }

        //SQL 연결        
        public void Connect(string ip, string db, string port, string id, string pw)
        {
            string strConn = $"Server={ip};Port={port};Database={db};Uid={id};Pwd={pw};Charset=utf8;";
            conn = new MySqlConnection(strConn);
            conn.Open();
        }

        //반환값 없는 SQL 실행
        public void SQLRun_NoReturn(string sql)
        {
            if (conn.State != System.Data.ConnectionState.Open) throw new Exception("NoSQLConnection");

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        //DataTable 반환하는 SQL 실행
        public DataTable SQLRun_ReturnDt(string sql)
        {
            if (conn.State != System.Data.ConnectionState.Open) throw new Exception("NoSQLConnection");

            DataTable dt = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(dt);

            return dt;
        }
    }

}