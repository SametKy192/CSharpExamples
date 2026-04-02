using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace E_Okul_Proje
{
    internal class Sql_bgl
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-P7S931M\\SQLEXPRESS;Initial Catalog=E_Okul_Proje;Integrated Security=True;Encrypt=False");

            baglan.Open();
            return baglan;
        }
    }
}
