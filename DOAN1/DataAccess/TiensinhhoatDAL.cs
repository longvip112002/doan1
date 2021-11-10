using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using DOAN1.Entities;
using DOAN1.DataAccessLayer.Services;

namespace DOAN1.DataAccessLayer
{
    class TiensinhhoatDAL : ITiensinhhoatDAL
    {
        private string txtfile = "Data/Tiensinhhoat.txt";
        public List<Tiensinhhoat> GetAllData()
        {
            List<Tiensinhhoat> list = new List<Tiensinhhoat>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    s = DOAN1.Utility.Congcu.CatXau(s);
                    string[] a = s.Split('#');
                    list.Add(new Tiensinhhoat(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]), int.Parse(a[3])));
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
        public void Insert(Tiensinhhoat h)
        {
            int mant = Getmaphong() + 1;
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write( h.Maphong + "#" + h.Thangnam + "#" + h.Sodien + "#" + h.Sonuoc);
            fwrite.Close();
        }
        public void Delete(int Maphong)
        {
            List<Tiensinhhoat> list = GetAllData();
            StreamWriter fwrite = File.CreateText(txtfile);
            foreach (Tiensinhhoat h in list)
                if (h.Maphong != Maphong)
                    fwrite.WriteLine(Maphong + "#" + h.Maphong + "#" + h.Thangnam + "#" + h.Sodien + "#" + h.Sonuoc);
            fwrite.Close();
        }
    }
}
