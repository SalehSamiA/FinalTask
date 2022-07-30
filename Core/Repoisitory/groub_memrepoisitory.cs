using Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repoisitory
{
   public interface groub_memrepoisitory
    {
        public string updateGroub_mems(groub_mem_Api back);
        public string insertGroub_mems(groub_mem_Api back);

        public string deleteGroub_mems(int id);

        public List<groub_mem_Api> getallGroub_mems();

        public groub_mem_Api getbyidGroub_mems(int id);



    }
}
