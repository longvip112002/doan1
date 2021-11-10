using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1.Entities
{
    class Thuephong
    {
        private int mant;
        private int maphong;
        private int ngayvp;
        private int ngaytp;
        public Thuephong() { }
        public int Mant { get => mant; set => mant = value; }
        public int Maphong { get => maphong; set => maphong = value; }
        public int Ngayvp1 { get => ngayvp; set => ngayvp = value; }
        public int Ngaytp1 { get => ngaytp; set => ngaytp = value; }
        public Thuephong(int mant, int maphong, int ngayvp, int ngaytp)
        {
            this.mant = mant;
            this.maphong = maphong;
            this.ngayvp = ngayvp;
            this.ngaytp = ngaytp;
        }
    }
}
