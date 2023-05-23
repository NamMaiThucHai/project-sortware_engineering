using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GUI_STORE
{
    public class modify
    {

    public DataTable data()
    {
        DataTable dataTable = new DataTable();
        string query = "SELECT * FROM CTHD";
        using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-63V9GUIC;Initial Catalog=QLCHMN;Integrated Security=True")) 
        {
            conn.Open();
            SqlDataAdapter adap = new SqlDataAdapter(query, conn);
            adap.Fill(dataTable);
            conn.Close();
        }
        return dataTable;
    } 

    }

    
}
