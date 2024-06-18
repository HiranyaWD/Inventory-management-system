using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HHCO
{
    class Database
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;

        public Database()
        {
            con = new SqlConnection("Data Source=DESKTOP-PBQ3S51;Initial Catalog=HHCO;Integrated Security=True");
        }
        public void openConnection()
        {
            con.Open();
        }
        public void closeConnection()
        {
            con.Close();
        }
        public DataTable getData(string a)
        {

            openConnection();
            da = new SqlDataAdapter(a, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeConnection();
            return dt;

        }
        

       
    }
}
    
    
