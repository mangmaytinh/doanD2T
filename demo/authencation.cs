using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace demo
{
    public class authencation
    {

        public static string user, pass, otp,tell;
        public static bool uasmsotp = false;
        public static SqlConnection con = null;
        public static SqlDataReader rd;
        public static SqlCommand cmd;
        public static SqlConnection getcon()
        {
            string strcon = ConfigurationManager.ConnectionStrings["con"].ToString();
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            return con;
        }

        public static string gettell(string user)
        {
            cmd = new SqlCommand("gettell", getcon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", user);
            tell  = (string)cmd.ExecuteScalar();
            return tell;
        }

        public static bool login(string username, string password)
        {
            bool id = false;
            cmd = new SqlCommand("userlogin", getcon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);
            rd = cmd.ExecuteReader();
            id = rd.Read();
            return id;
        }
        public static string getotp(string username)
        {
            string otp = "";
            cmd = new SqlCommand("getotp", getcon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", username);
            otp = (string)cmd.ExecuteScalar();

            return otp;
        }

        public static bool checkotp(string username, string otp)
        {
            bool authen = false;
            cmd = new SqlCommand("checkotp", getcon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@otp", otp);
            rd = cmd.ExecuteReader();
            authen = rd.Read();
            return authen;
        }
    }
}