using Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
   public interface Ilikesservice
    {
        public string updateLikes(likes_Api back);
        public string insertLikes(likes_Api back);

        public string deleteLikes(int id);

        public List<likes_Api> getallLikes();

        public likes_Api getbyidserviceulikes(int id);


    }
}
