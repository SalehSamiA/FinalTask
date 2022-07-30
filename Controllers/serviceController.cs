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

    public class serviceController : ControllerBase
    {
        private readonly Iserviceservice conver;
        public serviceController(Iserviceservice conver)
        {
            this.conver = conver;

        }
        [HttpDelete("delete/{id}")] //delete record from database
        public string deleteCard(int id)
        {

            return conver.deleteService(id);
        }
        [HttpGet("{id}")] // retrive data by id
        public service_Api getbyidserviceucard(int id)
        {

            return conver.getbyidService(id);
        }
        [HttpPost]//insert new record in database
        public string insertCard([FromBody] service_Api use)
        {

            return conver.insertService(use);
        }
        [HttpPut] //update
        public string updateCard([FromBody] service_Api use)
        {

            return conver.updateService(use);
        }

        [HttpGet] // retrive data by id
        public List<service_Api> getallCard()
        {

            return conver.getallService();
        }


    }
}
