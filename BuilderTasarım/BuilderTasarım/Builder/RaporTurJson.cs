using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderTasarım.Builder
{
    class RaporTurJson:RaporOlusturAbstract
    {
        public RaporTurJson(BilgiStok bilgi) : base(bilgi)
        {
        }
        public override string BuildAd()
        {

            return "JSon türünde  : " + bilgi.ad;
        }

        public override string BuildNo()
        {
            return "JSon türünde : " + bilgi.no;
        }
    }
}
