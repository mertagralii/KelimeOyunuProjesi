using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace KelimeOyunuProjesi
{
    public class Entity
    {
      
        public string getirKelime() 
        {
            string _kelime = "";

            SqlConnection _connection = new SqlConnection(@"Data Source=MERT;Initial Catalog=KelimeOyunu;Integrated Security=True");
            _connection.Open();
            SqlCommand _sqlCommand = new SqlCommand("KelimeGetir",_connection);
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            DataTable dt = new DataTable();
            _sqlDataAdapter.Fill(dt);
            _connection.Close();


            if (dt.Rows.Count > 0)
            {
                _kelime = dt.Rows[0]["KELİME"].ToString();
            }


            return _kelime;
        }

    }
}
