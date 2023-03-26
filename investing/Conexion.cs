using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System. Data.SqlClient;

namespace investing
{
    internal class Conexion
    {
        public static string conect()
        {
            string con = @"Data Source=INSPIRON-ELLO\SQLEXPRESS;Initial Catalog=VENTAS;Integrated Security=True";
            return con;
        }

    }
}
