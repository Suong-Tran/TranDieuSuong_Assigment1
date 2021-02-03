using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TranDieuSuong_Assigment1.Controllers
{
    public class SquareController : ApiController
    {
      //Get api/Square/5

    /// <summary>
    /// This will square up any input number
    /// </summary>
    /// <param name="id">user input</param>
    /// <returns>the square of the number</returns>
    /// <example>
    /// Get api/square/4 ---> 16
    /// </example>
      public int Get(int id)
      {
        return id*id;
      }
  }
}
