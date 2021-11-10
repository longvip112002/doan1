using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1.Entities
{
    class Phongtro
    {
        private int maphong;
        private string tenphong;
        public Phongtro() { }

        public int Maphong1 { get => maphong; set => maphong = value; }
        public string Tenphong1 { get => tenphong; set => tenphong = value; }

        public Phongtro(int maphong, string tenphong)
        {
            this.maphong = maphong;
            this.tenphong = tenphong;
        }
    }
}
