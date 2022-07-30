using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data
{
 public   class groub_mem_Api
    {
        public int groubid { get; set; }
        public int userid { get; set; }
        public int conid { get; set; }
        public DateTime? joingrou { get; set; }
        public DateTime? leftgrou { get; set; }

    }
}