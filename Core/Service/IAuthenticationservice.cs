﻿using Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
  public  interface IAuthenticationservice
    {
        public string Authentication_jwt(login_api login);
    }
}
