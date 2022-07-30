using Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repoisitory
{
  public  interface Iemp_apirepositiorycs
    {
        public bool checkemailisexist(empverifiy emp);

        public bool checkverify(empverifiy emp);

    }
}
