using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderTasarım.Builder
{
    class RaporTurHtml : RaporOlusturAbstract
    {
        public RaporTurHtml(BilgiStok bilgi) : base(bilgi)
        {
        }
        public override string BuildAd()
        {

            return "Html türünde  : " + bilgi.ad;
        }

        public override string BuildNo()
        {
            return "Html türünde : " + bilgi.no;
        }


    }
}
