//===========================
// Header File 
//
//===========================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace _03.SimpleWebApi.Controllers
{
    [ApiController]
    [Route("/controller")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() => "Hello Mario, the princess is in another castle";
    }
}
