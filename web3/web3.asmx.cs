using System;
using System.Web;
using System.Web.Services;

namespace web3
{
    public class web3 : System.Web.Services.WebService
    {
        [WebMethod]
        public decimal sumar(decimal a, decimal b)
        {
            decimal result = a + b;
            return result;
        }

        [WebMethod]
        public decimal restar(decimal a, decimal b)
        {
            decimal result = a - b;
            return result;
        }

        [WebMethod]
        public decimal multiplicar(decimal a, decimal b)
        {
            return a * b;
        }


        [WebMethod]
        public decimal dividir(decimal a, decimal b)
        {
            if (b == 0)
            { return 0; }
            else
            {
                decimal result = a / b;
                return result;
            }
        }
    }
}
