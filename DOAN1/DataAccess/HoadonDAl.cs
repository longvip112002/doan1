using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using DOAN1.Entities;
using DOAN1.DataAccessLayer.Services;

namespace DOAN1.DataAccessLayer
{
    class HoadonDAL : IHoadonDAL
    {
        private string txtfile = "Data/Hoadon.txt";
        public List<Hoadon> GetAllData()
        {
            List<Hoadon> list = new List<Hoadon>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    s = DOAN1.Utility.Congcu.CatXau(s);
                    string[] a = s.Split('#');
                    list.Add(new Hoadon(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]), int.Parse(a[3]), int.Parse(a[4])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Lấy mã học sinh của bản ghi cuối cùng phục vụ cho đánh mã tự động
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
        //Chèn một bản ghi học sinh vào tệp
        public void Insert(Hoadon p)
        {
            int mahs = Getmaphong() + 1;
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write( + p.Maphong + "#" + p.Mant + "#" + p.Sotd + "#" + p.Sotn + "#" + p.Sotp);
            fwrite.Close();
        }
        //Xóa một học sinh khi biết mã
        public void Delete(int Maphong)
        {
            List<Hoadon> list = GetAllData();
            StreamWriter fwrite = File.CreateText(txtfile);
            foreach (Hoadon p in list)
                if (p.Maphong != Maphong)
                    fwrite.WriteLine(p + "#" + p.Maphong + "#" + p.Mant + "#" + p.Sotd + "#" + p.Sotn + "#" + p.Sotp);
            fwrite.Close();
        }
    }
}
