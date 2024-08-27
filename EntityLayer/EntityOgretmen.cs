using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityOgretmen
    {
        private int ogrtid;

        public int ID
        {
            get { return ogrtid; }
            set { ogrtid = value; }
        }

        private string ogrtad;

        public string ADSOYAD
        {
            get { return ogrtad; }
            set { ogrtad = value; }
        }

        private string ogrtbrans;

        public string BRANS
        {
            get { return ogrtbrans; }
            set { ogrtbrans = value; }
        }


    }
}
