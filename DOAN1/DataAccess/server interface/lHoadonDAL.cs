using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.DataAccessLayer;
using DOAN1.Entities;
namespace DOAN1.DataAccessLayer.Services
{
    interface IHoadonDAL
    {
        List<Hoadon> GetAllData();
        void Insert(Hoadon p);
        void Delete(int maphong);
    }
}