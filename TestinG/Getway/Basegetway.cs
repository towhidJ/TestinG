using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace TestinG
{
    public class Basegetway
    {
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }
        public Basegetway()
        {
            string conn = WebConfigurationManager.ConnectionStrings["DbContext"].ConnectionString;
            Connection = new SqlConnection(conn);
        }
    }
}