using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using DOAN1.Entities;
using DOAN1.DataAccessLayer.Services;

namespace DOAN1.DataAccessLayer
{
    class NguoithueDAL : INguoithueDAL
    {
        private string txtfile = "Data/Nguoithue.txt";
        public List<Nguoithue> GetAllData()
        {
            List<Nguoithue> list = new List<Nguoithue>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    s = DOAN1.Utility.Congcu.CatXau(s);
                    string[] a = s.Split('#');
                    list.Add(new Nguoithue(int.Parse(a[0]), (a[1]), int.Parse(a[2]), (a[3]), int.Parse(a[4]), (a[5]), int.Parse(a[6])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        public int Getnt()
        {
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            string tmp = "";
            while (s != null)
            {
                if (s != "") tmp = s;
                s = fread.ReadLine();
            }
            fread.Close();
            if (tmp == "") return 0;
            else
            {
                tmp = DOAN1.Utility.Congcu.ChuanHoaXau(tmp);
                string[] a = tmp.Split('#');
                return int.Parse(a[0]);
            }
        }
        public void Insert(Nguoithue t)
        {
            int mant = Getnt() + 1;
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(t.Mant1 + "#" + t.Tent + "#" + t.Namsinh1 + "#" + t.Gioitinh1 + "#" + t.Sdt1 + "#" + t.Quequan1 + "#" + t.CMND1);
            fwrite.Close();
        }
        public void Delete(int Mant1)
        {
            List<Nguoithue> list = GetAllData();
            StreamWriter fwrite = File.CreateText(txtfile);
            foreach (Nguoithue t in list)
                if (t.Mant1 != Mant1)
                    fwrite.WriteLine(Mant1 + "#" + t.Mant1 + "#" + t.Tent + "#" + t.Namsinh1 + "#" + t.Gioitinh1 + "#" + t.Sdt1 + "#" + t.Quequan1 + "#" + t.CMND1);
            fwrite.Close();
        }
    }
}