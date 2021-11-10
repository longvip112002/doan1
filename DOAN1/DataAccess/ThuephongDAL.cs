using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using DOAN1.Entities;
using DOAN1.DataAccessLayer.Services;

namespace DOAN1.DataAccessLayer
{
    class ThuephongDAL : IThuephongDAL
    {
        private string txtfile = "Data/Thuephong.txt"; 
        public List<Thuephong> GetAllData()
        {
            List<Thuephong> list = new List<Thuephong>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    s = DOAN1.Utility.Congcu.CatXau(s);
                    string[] a = s.Split('#');
                    list.Add(new Thuephong(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]), int.Parse(a[3])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        public int Getmaphong()
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
        public void Insert(Thuephong n)
        {
            int mant = Getmaphong() + 1;
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(n.Mant + "#" + n.Maphong + "#" + n.Ngayvp1 + "#" + n.Ngaytp1);
            fwrite.Close();
        }
        public void Delete(int Mant)
        {
            List<Thuephong> list = GetAllData();
            StreamWriter fwrite = File.CreateText(txtfile);
            foreach (Thuephong n in list)
                if (n.Mant != Mant)
                    fwrite.WriteLine(Mant + "#" + n.Mant + "#" + n.Maphong + "#" + n.Ngayvp1 + "#" + n.Ngaytp1);
            fwrite.Close();
        }
    }
}
