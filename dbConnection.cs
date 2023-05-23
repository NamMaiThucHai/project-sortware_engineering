using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QLBH
{
    public class dbConnection
    {
        protected SqlConnection conn = new SqlConnection("Data Source=LAPTOP-63V9GUIC;Initial Catalog=QLCHMN;Integrated Security=True");
    }
}
