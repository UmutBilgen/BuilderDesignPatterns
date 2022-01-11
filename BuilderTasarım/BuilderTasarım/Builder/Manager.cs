using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderTasarım.Builder
{
    class Manager
    {

       private RaporOlusturAbstract build;
        public Manager (RaporOlusturAbstract build)
        {
            this.build = build;
        }

        public string BuildN()
        {
            return build.BuildOut();
        }
        public string BuildUpsideDown()
        {
            string sonuc = build.BuildNo();
            sonuc +=build.BuildAd();
            return sonuc;
        }
    }
}
