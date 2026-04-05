using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAcces_Layer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-P7S931M\\SQLEXPRESS;Initial Catalog=oop_n_katmanli;Integrated Security=True;Encrypt=False");

    }
}
