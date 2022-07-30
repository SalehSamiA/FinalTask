using Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repoisitory
{
   public interface serviceuserrepoisitory
    {
        public string updateService_user(service_user_api back);
        public string insertService_user(service_user_api back);

        public string deleteService_user(int id);

        public List<service_user_api> getallService_user();

        public service_user_api getbyidserviceuservice_user(int id);



    }
}
