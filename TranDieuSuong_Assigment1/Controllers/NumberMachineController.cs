using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TranDieuSuong_Assigment1.Controllers
{
    public class NumberMachineController : ApiController
    {

    /// <summary>
    /// This will square up the input number then subtract 100
    /// then it will divide the number by 10 and return the division remainder
    /// then it will double the number and add 1 to it
    /// </summary>
    /// <param name="id">user input number</param>
    /// <returns> (((id*id)-100/%10)*2 + 1 </returns>
    /// <example>
    /// Get/api/numbermachine/20 ---> 1
    /// </example>
    public int Get(int id)
    {
      int num = id * id;
      num = num - 100;
      num = num % 10;
      num = num * 2;
      num = num + 1;
      return num;
    }
  }
}
