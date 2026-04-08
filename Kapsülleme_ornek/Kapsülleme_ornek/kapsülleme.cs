using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme_ornek
{
    internal class kapsülleme: kalitim
    {
        public string renk;
        public int hiz;
        public int motor;
        public int fiyat;
        public char durum;
        private int yil;
        private string marka;



        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }

        }

        public string Markasi
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }
        }


    }
