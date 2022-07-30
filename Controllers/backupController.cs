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

    public class backupController : ControllerBase
    {
        private readonly Ibackupservice backupservice;
        public backupController(Ibackupservice backupservice)
        {
            this.backupservice = backupservice;

        }
        [HttpDelete("delete/{id}")] //delete record from database
        public string deleteBackupmess(int id)
        {

            return backupservice.deleteBackupmess(id);
        }
        [HttpGet("{id}")] // retrive data by id
        public backupmes_Api getbyidBackupmess(int id)
        {

            return backupservice.getbyidBackupmess(id);
        }
        [HttpPost]//insert new record in database
        public string insertBackupmess([FromBody] backupmes_Api use)
        {

            return backupservice.insertBackupmess(use);
        }
        [HttpPut] //update
        public string updateBackupmess([FromBody] backupmes_Api use)
        {

            return backupservice.updateBackupmess(use);
        }

        [HttpGet] // retrive data by id
        public List<backupmes_Api> getallBackupmess()
        {

            return backupservice.getallBackupmess();
        }

    }
}
