using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.DataAccessLayer;
using DOAN1.Entities;
namespace DOAN1.DataAccessLayer.Services
{
    interface IPhongtroDAL
    {
        List<Phongtro> GetAllData();
        void Insert(Phongtro v);
        void Delete(int maphong);
    }
}
