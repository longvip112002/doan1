using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1.Entities
{
    class Hoadon
    {
        private int maphong;
        private int mant;
        private int sotd;
        private int sotn;
        private int sotp;
        public Hoadon() { }

        public Hoadon(int maphong, int mant, int sotd, int sotn, int sotp)
        {
            this.maphong = maphong;
            this.mant = mant;
            this.sotd = sotd;
            this.sotn = sotn;
            this.sotp = sotp;
        }

        public int Maphong { get => maphong; set => maphong = value; }
        public int Mant { get => mant; set => mant = value; }
        public int Sotd { get => sotd; set => sotd = value; }
        public int Sotn { get => sotn; set => sotn = value; }
        public int Sotp { get => sotp; set => sotp = value; }
    }
}
