using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1.Entities
{
    public class Nguoithue
    {
        private int mant;
        private string tent;
        private int namsinh;
        private string gioitinh;
        private int sdt;
        private string quequan;
        private int CMND;
        public Nguoithue() { }

        public Nguoithue(int mant, string tent, int namsinh, string gioitinh, int sdt, string quequan, int cMND)
        {
            this.mant = mant;
            this.tent = tent;
            this.namsinh = namsinh;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.quequan = quequan;
            CMND = cMND;
        }

        public int Mant1 { get => mant; set => mant = value; }
        public string Tent { get => tent; set => tent = value; }
        public int Namsinh1 { get => namsinh; set => namsinh = value; }
        public string Gioitinh1 { get => gioitinh; set => gioitinh = value; }
        public int Sdt1 { get => sdt; set => sdt = value; }
        public string Quequan1 { get => quequan; set => quequan = value; }
        public int CMND1 { get => CMND; set => CMND = value; }

    }
}
