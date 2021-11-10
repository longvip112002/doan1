using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using DOAN1.Entities;
using DOAN1.DataAccessLayer.Services;

namespace DOAN1.DataAccessLayer
{
    class PhongtroDAL : IPhongtroDAL
    {
        private string txtfile = "Data/Phongtro.txt";
        public List<Phongtro> GetAllData()
        {
            List<Phongtro> list = new List<Phongtro>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    s = DOAN1.Utility.Congcu.CatXau(s);
                    string[] a = s.Split('#');
                    list.Add(new Phongtro(int.Parse(a[0]), (a[1])));
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
        public void Insert(Phongtro v)
        {
            int mav = Getmaphong() + 1;
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(mav + "#" + v.Maphong1 + "#" + v.Tenphong1);
            fwrite.Close();
        }
        public void Delete(int Maphong1)
        {
            List<Phongtro> list = GetAllData();
            StreamWriter fwrite = File.CreateText(txtfile);
            foreach (Phongtro v in list)
                if (v.Maphong1 != Maphong1)
                    fwrite.WriteLine(Maphong1 + "#" + v.Tenphong1);
            fwrite.Close();
        }
    }
}
