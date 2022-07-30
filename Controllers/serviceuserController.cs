using Core.Data;
using Core.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class serviceuserController : ControllerBase
    {
        private readonly Iserviceuserservice conver;
        public serviceuserController(Iserviceuserservice conver)
        {
            this.conver = conver;

        }
        [HttpDelete("delete/{id}")] //delete record from database
        public string deleteCard(int id)
        {

            return conver.deleteService_user(id);
        }
        [HttpGet("{id}")] // retrive data by id
        public service_user_api getbyidserviceucard(int id)
        {

            return conver.getbyidserviceuservice_user(id);
        }
        [HttpPost]//insert new record in database
        public string insertCard([FromBody] service_user_api use)
        {

            return conver.insertService_user(use);
        }
        [HttpPut] //update
        public string updateCard([FromBody] service_user_api use)
        {

            return conver.updateService_user(use);
        }

        [HttpGet] // retrive data by id
        public List<service_user_api> getallCard()
        {

            return conver.getallService_user();
        }


    }
}
