using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data
{
    public class massege_Api
    {
        public int massegeid { get; set; }
        public int from_num { get; set; }
        public string subject { get; set; }
        public DateTime? sent { get; set; }
        public int to_num { get; set; }

        public int conid { get; set; }

    }
}