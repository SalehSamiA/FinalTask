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

    public class likeController : ControllerBase
    {
        private readonly Ilikesservice conver;
        public likeController(Ilikesservice conver)
        {
            this.conver = conver;

        }
        [HttpDelete("delete/{id}")] //delete record from database
        public string deleteCard(int id)
        {

            return conver.deleteLikes(id);
        }
        [HttpGet("{id}")] // retrive data by id
        public likes_Api getbyidserviceucard(int id)
        {

            return conver.getbyidserviceulikes(id);
        }
        [HttpPost]//insert new record in database
        public string insertCard([FromBody] likes_Api use)
        {

            return conver.insertLikes(use);
        }
        [HttpPut] //update
        public string updateCard([FromBody] likes_Api use)
        {

            return conver.updateLikes(use);
        }

        [HttpGet] // retrive data by id
        public List<likes_Api> getallCard()
        {

            return conver.getallLikes();
        }


    }
}
