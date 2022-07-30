using Core.Data;
using Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
    public interface Iuser_apiservice
    {
        public List<usercount> getCountUsers();
        public string updateUsers(userac_Api user);
        public string insertUsers(userac_Api user);

        public string deleteUsers(int id);

        public List<userac_Api> getallUsers();

        public userac_Api getbyidUsers(int id);

        public List<countryuser> getcountcountry();
        public bool Insert(string FilePath);


    }
}
