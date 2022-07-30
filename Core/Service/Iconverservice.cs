using Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
   public interface Iconverservice
    {
        public string updateConvers(conver_Api back);
        public string insertConvers(conver_Api back);

        public string deleteConvers(int id);

        public List<conver_Api> getallConvers();

        public conver_Api getbyidConvers(int id);

    }
}
