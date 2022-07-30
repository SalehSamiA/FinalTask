using Core.Data;
using Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
  public  interface Imassegeservice
    {
        public string insertMasseges(massege_Api mas);
        public string updateMasseges(massege_Api mas);

        public string deleteMasseges(int id);

        public List<massege_Api> getallMasseges();

        public massege_Api getbyidMasseges(int id);

        public massege_Api getbydate(massege_date mas);

    }
}
