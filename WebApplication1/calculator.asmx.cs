using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://akashmishra_calculator.com/webservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public int add(int a,int b)
        {
            return a+b;
        }

        [WebMethod]
        public int sub(int a, int b)
        {
            return a - b;
        }


        [WebMethod]
        public int moltiply(int a, int b)
        {
            return a * b;
        }


        [WebMethod]
        public int devide(int a, int b)
        {
            return a / b;
        }


        [WebMethod]
        public int modulo(int a, int b)
        {
            return a % b;
        }
    }
}
