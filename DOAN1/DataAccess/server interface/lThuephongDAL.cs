using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.DataAccessLayer;
using DOAN1.Entities;
namespace DOAN1.DataAccessLayer.Services
{
    interface IThuephongDAL
    {
        List<Thuephong> GetAllData();
        void Insert(Thuephong n);
        void Delete(int mant);
    }
}