using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace HastaneApp
{
    class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=MRYMERGN; Initial Catalog=HastaneDB; Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
} 
