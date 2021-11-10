using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1.Entities
{
    class Tiensinhhoat
    {
        private int maphong;
        private int thangnam;
        private int sodien;
        private int sonuoc;
        public Tiensinhhoat() { }

        public Tiensinhhoat(int maphong, int thangnam, int sodien, int sonuoc)
        {
            this.maphong = maphong;
            this.thangnam = thangnam;
            this.sodien = sodien;
            this.sonuoc = sonuoc;
        }

        public int Maphong { get => maphong; set => maphong = value; }
        public int Thangnam { get => thangnam; set => thangnam = value; }
        public int Sodien { get => sodien; set => sodien = value; }
        public int Sonuoc { get => sonuoc; set => sonuoc = value; }
    }
}

