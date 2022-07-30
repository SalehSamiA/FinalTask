using Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repoisitory
{
   public interface IAuthentication
    {
        public login_api auth(login_api login);
    }
}