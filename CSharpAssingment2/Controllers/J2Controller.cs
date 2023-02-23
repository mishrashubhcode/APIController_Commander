using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CSharpAssingment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Calculates the number of ways to roll a sum of 10 with two dice.
        /// </summary>
        /// <param name="m">Number of sides on first die.</param>
        /// <param name="n">Number of sides on second die.</param>
        /// <returns>The number of ways to roll a sum of 10.</returns>
        /// 
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int count = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        count++;
                    }
                }
            }

            if (count==1)
            return "There is " + count + " way to get the sum 10.";

            else
                return "There are " + count + " ways to get the sum 10.";

        }
    }
}
