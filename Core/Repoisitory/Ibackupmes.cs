using Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repoisitory
{
  public  interface Ibackupmes
    {
        public string updateBackupmess(backupmes_Api back);
        public string insertBackupmess(backupmes_Api back);

        public string deleteBackupmess(int id);

        public List<backupmes_Api> getallBackupmess();

        public backupmes_Api getbyidBackupmess(int id);



    }
}
