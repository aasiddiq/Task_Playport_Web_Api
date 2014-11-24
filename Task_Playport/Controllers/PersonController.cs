using Task_Playport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Net.Http;
using System.Text;

namespace Task_Playport.Controllers
{
    [RoutePrefix("api")]
    public class PersonController : ApiController
    {
        [Route("person/{Name}/hello/{Location}")]
        public HttpResponseMessage GetResponse(string Name, string Location)
        {
            string result = "";
            if (Name == null || Location == null)
                result = "Error, Try again";
            else
                result = "Hello " + Name + " from " + Location;
            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            resp.Content = new StringContent(result, Encoding.UTF8, "text/plain");
            return resp;
        }
    }
}
