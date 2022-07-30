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

    public class groubmemController : ControllerBase
    {
        private readonly Igroub_memservice conver;
        public groubmemController(Igroub_memservice conver)
        {
            this.conver = conver;

        }
        [HttpDelete("delete/{id}")] //delete record from database
        public string deleteCard(int id)
        {

            return conver.deleteGroub_mems(id);
        }
        [HttpGet("{id}")] // retrive data by id
        public groub_mem_Api getbyidserviceucard(int id)
        {

            return conver.getbyidGroub_mems(id);
        }
        [HttpPost]//insert new record in database
        public string insertCard([FromBody] groub_mem_Api use)
        {

            return conver.insertGroub_mems(use);
        }
        [HttpPut] //update
        public string updateCard([FromBody] groub_mem_Api use)
        {

            return conver.updateGroub_mems(use);
        }

        [HttpGet] // retrive data by id
        public List<groub_mem_Api> getallCard()
        {

            return conver.getallGroub_mems();
        }


    }
}
