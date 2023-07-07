using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Functions
    {
        // private SqlConnection Con;
        //  private SqlCommand cmd;
        //  private DataTable dt;
        //  private SqlDataAdapter sda;
        //  private string ConStr;

                                                                    // 01)
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-LCD211ID\\SQLEXPRESS;Initial Catalog=EmpDb;Integrated Security=True");
        public Functions()
        {
            /* ConStr = "Data Source=LAPTOP-LCD211ID\\SQLEXPRESS;Initial Catalog=EmpDb;Integrated Security=True";
             Con = new SqlConnection(ConStr);
             cmd = new SqlCommand();
             cmd.Connection = Con; */

            
         SqlCommand cmd = new SqlCommand( "",con);                  // 02)

        }

        public DataTable GetData(string Query)
        {
           SqlDataAdapter sda = new SqlDataAdapter(Query, con);     // 03)
            DataTable dt = new DataTable();                         // 04)
            sda.Fill(dt);                                           // 05)
            return dt;
        }


        /* public int SetData (string Query)
         {
             int cnt = 0;
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             cmd.CommandText = Query;
             cnt = cmd.ExecuteNonQuery();
             return cnt;
         } */

        public int SetData(string Query)
        {
            int cnt = 0;
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-LCD211ID\\SQLEXPRESS;Initial Catalog=EmpDb;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cnt = cmd.ExecuteNonQuery();
                }
            }
            return cnt;
        }


    }
}
