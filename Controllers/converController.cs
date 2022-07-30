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

    public class converController : ControllerBase
    {
        private readonly Iconverservice conver;
        public converController(Iconverservice conver)
        {
            this.conver = conver;

        }
        [HttpDelete("delete/{id}")] //delete record from database
        public string deleteCard(int id)
        {

            return conver.deleteConvers(id);
        }
        [HttpGet("{id}")] // retrive data by id
        public conver_Api getbyidserviceucard(int id)
        {

            return conver.getbyidConvers(id);
        }
        [HttpPost]//insert new record in database
        public string insertCard([FromBody] conver_Api use)
        {

            return conver.insertConvers(use);
        }
        [HttpPut] //update
        public string updateCard([FromBody] conver_Api use)
        {

            return conver.updateConvers(use);
        }

        [HttpGet] // retrive data by id
        public List<conver_Api> getallCard()
        {

            return conver.getallConvers();
        }


    }
}
