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

    public class postController : ControllerBase
    {
        private readonly Ipostservice conver;
        public postController(Ipostservice conver)
        {
            this.conver = conver;

        }
        [HttpDelete("delete/{id}")] //delete record from database
        public string deleteCard(int id)
        {

            return conver.deletePost(id);
        }
        [HttpGet("{id}")] // retrive data by id
        public post_Api getbyidserviceucard(int id)
        {

            return conver.getbyidserviceupost(id);
        }
        [HttpPost]//insert new record in database
        public string insertCard([FromBody] post_Api use)
        {

            return conver.insertPost(use);
        }
        [HttpPut] //update
        public string updateCard([FromBody] post_Api use)
        {

            return conver.updatePost(use);
        }

        [HttpGet] // retrive data by id
        public List<post_Api> getallCard()
        {

            return conver.getallPost();
        }


    }
}
