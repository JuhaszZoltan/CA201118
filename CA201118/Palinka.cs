using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201118
{
    class Palinka
    {
        private int _alkoholFok;
        private string _gyumolcs;
        private int _mennyiseg;
        private int _keszitesEve;
        private int _ar;
        public int AlkoholFok
        {
            get { return _alkoholFok; }
            set
            {
                if (value < 30 || value > 87)
                    throw new Exception("nem leht ennyi fokos egy pálinka");
                _alkoholFok = value;
            }
        }
        public string Gyumolcs
        {
            get { return _gyumolcs; }
            set
            {
                if (value is null)
                    throw new Exception("nem lehet null");
                if (value.Length < 3 || value.Length > 20)
                    throw new Exception("nem lehet ilyen hosszú nevű gyümölcsből");
                _gyumolcs = value;
            }
        }
        public int Mennyiseg
        {
            get { return _mennyiseg; }
            set
            {
                if (value < 0 || value > 50)
                    throw new Exception("nem lehet ennyi pálinkád");
                _mennyiseg = value;
            }
        }
        public int KeszitesEve
        {
            get => _keszitesEve;
            set
            {
                if (value < 2000 || value > DateTime.Now.Year)
                    throw new Exception("nem lehet ez a készítés éve");
                _keszitesEve = value;
            }
        }
        public int Ar
        {
            get => _ar;
            set
            {
                if (value < 50 || value > 1000)
                    throw new Exception("nem kerülhet ennyibe");
                _ar = value;
            }
        }
    }
}
