using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.DataAccessLayer;
using DOAN1.Entities;
namespace DOAN1.DataAccessLayer.Services
{
    interface ITiensinhhoatDAL
    {
        List<Tiensinhhoat> GetAllData();
        void Insert(Tiensinhhoat h);
        void Delete(int maphong);
    }
}
