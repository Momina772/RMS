using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RMS_FYP
{
    class Insertion
    {
        public static void insertRole(string role)
        {
            /*try
            {
                SqlCommand cmd = new SqlCommand("st_insertRoles", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", role);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showmsg(role + " added successfully into the System","Role added!", "Success");
                }
            }
            catch(Exception exp)
            {
                MainClass.con.Close();
                MainClass.showmsg(exp.Message, "Role added!", "Error");

            }*/
        }
    }
}
