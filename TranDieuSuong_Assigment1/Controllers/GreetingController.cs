using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TranDieuSuong_Assigment1.Controllers
{
    
    public class GreetingController : ApiController
    {

    //Get api/Greeting/5
    /// <summary>
    /// Take the number of guess and return a welcoming message
    /// </summary>
    /// <param name="id">the number of guess</param>
    /// <returns>A greeting to the number of guests</returns>
    /// <example>
    /// Get api/greeting/2 ---> "Greeting to 2 people!"
    /// </example>
    public String Get(int id)
      {
      return $"Greeting to {id} people!";
      }

    //Push api/Greeting
    /// <summary>
    /// return the string "Hello World" in the command prompt
    /// </summary>
    /// <returns>"Hello World"</returns>
    public string Post()
    {
      return "Hello World";

    }
  }
    
}
