﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Cadenaconexion
{
    internal class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("Data Source=OSWAL-PC\\SQLEXPRESS03;Initial Catalog=Northwind;Integrated Security=True;");
            cn .Open();
            return cn;
        }

    }
}
