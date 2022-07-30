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

    public class CardapiController : ControllerBase
    {
        private readonly Icardservice cardservice;
        public CardapiController(Icardservice cardservice)
        {
            this.cardservice = cardservice;

        }
        [HttpDelete("delete/{id}")] //delete record from database
        public string deleteCard(int id)
        {

            return cardservice.deleteCard(id);
        }
        [HttpGet("{id}")] // retrive data by id
        public card_Api getbyidserviceucard(int id)
        {

            return cardservice.getbyidserviceucard(id);
        }
        [HttpPost]//insert new record in database
        public string insertCard([FromBody] card_Api use)
        {

            return cardservice.insertCard(use);
        }
        [HttpPut] //update
        public string updateCard([FromBody] card_Api use)
        {

            return cardservice.updateCard(use);
        }

        [HttpGet] // retrive data by id
        public List<card_Api> getallCard()
        {

            return cardservice.getallCard();
        }


    }
}
