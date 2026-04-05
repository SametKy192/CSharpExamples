using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_layer;
using DataAcces_Layer;
namespace Logic_Layer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }
        public static int LLPersonel(EntityPersonel p)
        {
            if(p.Ad!="" && p.Soyad != "" && p.Maas >=0 && p.Gorev != "" && p.Sehir != "" )
            {
                return DALPersonel.PersonelEkle(p);
            }
            else { return -1; }
        }

        public static bool LLPersonelSil(int per)
        {
            if(per>=1)
            {
                return DALPersonel.PersonelSil(per);
            }
            else { return false; }
        }
    }
}
