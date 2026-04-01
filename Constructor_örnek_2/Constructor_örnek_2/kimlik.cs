using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_örnek_2
{
    internal class kimlik
    {
        string ad;
        string soyad;
        int yas;
       

       public string AD
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }

        }

      public int YAS
        {
            get { return yas;}

            set { yas = Math.Abs(value); }
        
        }

        public kimlik() //constructor class adı ıle aynı olmak zorunda
        {
            ad = " ";
            soyad = " ";
            yas = 18;

        }





    }
}