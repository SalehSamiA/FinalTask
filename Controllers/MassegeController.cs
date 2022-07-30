using Core.Data;
using Core.DTO;
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

    public class MassegeController : ControllerBase
    {
        private readonly Imassegeservice massegeservice;
        public MassegeController(Imassegeservice massegeservice)
        {
            this.massegeservice = massegeservice;

        }
        [HttpDelete("delete/{id}")] //delete record from database
        public string deleteMasseges(int id)
        {

            return massegeservice.deleteMasseges(id);
        }
        [HttpGet]//retrevie all data
        public List<massege_Api> getallMasseges()
        {
            return massegeservice.getallMasseges();
        }
        [HttpGet("{id}")] // retrive data by id
        public massege_Api getbyidMasseges(int id)
        {

            return massegeservice.getbyidMasseges(id);
        }
        [HttpPost]//insert new record in database
        public string insertMasseges([FromBody] massege_Api mas)
        {

            return massegeservice.insertMasseges(mas);
        }
        [HttpPut] //update
        public string updateMasseges([FromBody] massege_Api mas)
        {

            return massegeservice.updateMasseges(mas);
        }

        [HttpGet]
        [Route("Number")]
        public int getCountMasseges()
        {
            List<massege_Api> count = massegeservice.getallMasseges();
            int countOf = 0;
            foreach (var item in count)
            {
                if (item.subject!=null)
                    countOf++;
            }
            return countOf;
        }

    }
}
