using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BBP201_210111409_Muhammed_Eren_Dibek
{
    class Veritabanı
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=personel_takip_programı;Persist Security Info=True;User ID=sa;Password=123456");
            baglan.Open();
            return baglan;
        }
    }
}
