using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgretmen
    {
        private int ogrtId;
        private int ogrtAd;
        private int ogrtBrans;

        public int OgrtId { get => ogrtId; set => ogrtId = value; }
        public int OgrtAd { get => ogrtAd; set => ogrtAd = value; }
        public int OgrtBrans { get => ogrtBrans; set => ogrtBrans = value; }
    }
}
