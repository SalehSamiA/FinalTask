using Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repoisitory
{
   public interface converapirep
    {
        public string updateConvers(conver_Api back);
        public string insertConvers(conver_Api back);

        public string deleteConvers(int id);

        public List<conver_Api> getallConvers();

        public conver_Api getbyidConvers(int id);



    }
}
