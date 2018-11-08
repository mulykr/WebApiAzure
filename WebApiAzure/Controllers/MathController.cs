using System;
using System.Web.Http;

namespace WebApiAzure.Controllers
{
    public class MathController : ApiController
    {
        /// <summary>
        /// Gets sin(x) or cos(x)
        /// </summary>
        /// <param name="func"></param>
        /// <param name="x"></param>
        /// <returns>Value of the function at the x point</returns>
        [HttpGet]
        public double Get(string func, double x)
        {
            func = func.ToLower();
            x = x * Math.PI / 180;

            switch (func)
            {
                case "sin":
                    return Math.Sin(x);
                case "cos":
                    return Math.Cos(x);
            }
            
            throw new ArgumentException();
        }
    }
}
