using Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
   public interface Ipostservice
    {
        public string updatePost(post_Api back);
        public string insertPost(post_Api back);

        public string deletePost(int id);

        public List<post_Api> getallPost();

        public post_Api getbyidserviceupost(int id);


    }
}
