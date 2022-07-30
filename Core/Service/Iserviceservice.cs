using Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
   public interface Iserviceservice
    {
        public string updateService(service_Api back);
        public string insertService(service_Api back);

        public string deleteService(int id);

        public List<service_Api> getallService();

        public service_Api getbyidService(int id);

        public List<service_Api> getsale();

    }
}
