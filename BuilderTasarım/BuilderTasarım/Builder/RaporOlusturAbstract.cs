using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderTasarım.Builder
{
  abstract class RaporOlusturAbstract
    {
        protected BilgiStok bilgi;
       
        public RaporOlusturAbstract(BilgiStok bilgi)
        {
            this.bilgi = bilgi;
        }
        public string BuildOut()
        {
            string sonuc = BuildAd();
             sonuc += BuildNo();
            return sonuc;
        }
       public abstract string BuildAd();
       public abstract string BuildNo();

    }
}
