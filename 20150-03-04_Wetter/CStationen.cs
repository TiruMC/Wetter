using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150_03_04_Wetter
{
    class CStationen
    {

        int iStationsindex;
        public int IStationsindex
        {
            get { return iStationsindex; }
            set { iStationsindex = value; }
        }
        double dHoehe; // in m;
        public double DHoehe
        {
            get { return dHoehe; }
            set { dHoehe = value; }
        }
        double dGPSBreite;
        public double DGPSBreite
        {
            get { return dGPSBreite; }
            set { dGPSBreite = value; }
        }
        double dGPSLaenge;
        public double DGPSLaenge
        {
            get { return dGPSLaenge; }
            set { dGPSLaenge = value; }
        }
        string strName;
        public string StrName
        {
            get { return strName; }
            set { strName = value; }
        }
        string strBundesland;
        public string StrBundesland
        {
            get { return strBundesland; }
            set { strBundesland = value; }
        }



    }
}
