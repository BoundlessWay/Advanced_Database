using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLNC_05
{
    class DbConn
    {
        static private string hostname = Environment.MachineName;
        // Thuan: @"Data Source=REVISION-PC;Initial Catalog=CQ_CSDLNC_05;Integrated Security=True"

        ////private string strConn = @"Data Source=DESKTOP-C9KCKLM;Initial Catalog=CQ_CSDLNC_05;Integrated Security=True";
        private string strConn = @"Data Source=" + hostname + "\\SQLSERVER;Initial Catalog=CQ_CSDLNC_05;Integrated Security=True";

        public SqlConnection conn { get; } = null;

        public DbConn()
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(strConn);
                }

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
