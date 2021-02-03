using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TranDieuSuong_Assigment1.Controllers
{
    public class AddTenController : ApiController
    {
    //Get api/AddTen/10

    /// <summary>
    /// This will add ten into the input value
    /// </summary>
    /// <param name="id"> user input </param>
    /// <returns>the value plus ten</returns>
    /// <example>
    /// Get api/addten/10 ---> 20
    /// </example>
      public int Get(int id)
      {
        return id + 10;
      }

  }
}
