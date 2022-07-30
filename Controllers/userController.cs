using Core;
using Core.Data;
using Core.DTO;
using Core.Service;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FinalTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class userController : ControllerBase

    {
        private readonly Iuser_apiservice user_apiservice;
        public userController(Iuser_apiservice user_apiservice)
        {
            this.user_apiservice = user_apiservice;

        }
        [HttpDelete("delete/{id}")] //delete record from database
        public string deleteUsers(int id)
        {

            return user_apiservice.deleteUsers(id);
        }
        [HttpGet("{id}")] // retrive data by id
        public userac_Api getbyidUsers(int id)
        {

            return user_apiservice.getbyidUsers(id);
        }
        [HttpPost]//insert new record in database
        public string insertUsers([FromBody] userac_Api use)
        {

            return user_apiservice.insertUsers(use);
        }
        [HttpPut] //update
        public string updateUsers([FromBody] userac_Api use)
        {

            return user_apiservice.updateUsers(use);
        }

        [HttpGet] // retrive data by id
        public List<userac_Api> getallUsers()
        {

            return user_apiservice.getallUsers();
        }

        [HttpGet]
        [Route("countuser")]

        public List<usercount> getCountUsers()
        {
            return user_apiservice. getCountUsers();

    }
        [HttpGet]
        [Route("country")]

        public List<countryuser> getcountcountry()
        {
            return user_apiservice.getcountcountry();

        }

        [HttpPost]
        [Route("text/{filePath}")]
        public bool InsertUsers(string filePath)
        {
            return user_apiservice.Insert(filePath);
        }
        [HttpPost]
        [Route("weather")]

        public String WeatherDetail(string City)  
        {  
  
            //Assign API KEY which received from OPENWEATHERMAP.ORG  
            string appId = "8113fcc5a7494b0518bd91ef3acc074f";  
  
            //API path with CITY parameter and other parameters.  
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&cnt=1&APPID={1}", City, appId);  
  
            using (WebClient client = new WebClient())  
            {  
                string json = client.DownloadString(url);  
                  
                //********//  
                //     JSON RECIVED   
                //********//  
                //{"coord":{ "lon":72.85,"lat":19.01},  
                //"weather":[{"id":711,"main":"Smoke","description":"smoke","icon":"50d"}],  
                //"base":"stations",  
                //"main":{"temp":31.75,"feels_like":31.51,"temp_min":31,"temp_max":32.22,"pressure":1014,"humidity":43},  
                //"visibility":2500,  
                //"wind":{"speed":4.1,"deg":140},  
                //"clouds":{"all":0},  
                //"dt":1578730750,  
                //"sys":{"type":1,"id":9052,"country":"IN","sunrise":1578707041,"sunset":1578746875},  
                //"timezone":19800,  
                //"id":1275339,  
                //"name":"Mumbai",  
                //"cod":200}  
  
                //Converting to OBJECT from JSON string.  
                RootObject weatherInfo = (new JavaScriptSerializer()).Deserialize<RootObject>(json);  
  
                //Special VIEWMODEL design to send only required fields not all fields which received from   
                //www.openweathermap.org api  
                ResultViewModel rslt = new ResultViewModel();  
  
                rslt.Country = weatherInfo.sys.country;  
                rslt.City = weatherInfo.name;  
                rslt.Lat = Convert.ToString(weatherInfo.coord.lat);  
                rslt.Lon = Convert.ToString(weatherInfo.coord.lon);  
                rslt.Description = weatherInfo.weather[0].description;  
                rslt.Humidity = Convert.ToString(weatherInfo.main.humidity);  
                rslt.Temp = Convert.ToString(weatherInfo.main.temp);  
                rslt.TempFeelsLike = Convert.ToString(weatherInfo.main.feels_like);  
                rslt.TempMax = Convert.ToString(weatherInfo.main.temp_max);  
                rslt.TempMin = Convert.ToString(weatherInfo.main.temp_min);  
                rslt.WeatherIcon = weatherInfo.weather[0].icon;  
  
                //Converting OBJECT to JSON String   
                var jsonstring = new JavaScriptSerializer().Serialize(rslt);  
  
                //Return JSON string.  
                return jsonstring;  
            }  
        }

    }
}
