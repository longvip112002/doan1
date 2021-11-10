using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.DataAccessLayer;
using DOAN1.Entities;
namespace DOAN1.DataAccessLayer.Services
{
    public interface INguoithueDAL
    {
        List<Nguoithue> GetAllData();
        void Insert(Nguoithue t);
        void Delete(int mant);
    }
}
