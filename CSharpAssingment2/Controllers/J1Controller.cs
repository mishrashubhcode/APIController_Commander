using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CSharpAssingment2.Controllers
{
    public class J1Controller : ApiController
    {
        private int[] burgerCalories = { 461, 431, 420, 0 };
        private int[] drinkCalories = { 130, 160, 118, 0 };
        private int[] sideCalories = { 100, 57, 70, 0 };
        private int[] dessertCalories = { 167, 266, 75, 0 };

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public int Menu(int burger, int drink, int side, int dessert)
        {
            int totalCalories = burgerCalories[burger - 1] + drinkCalories[drink - 1] + sideCalories[side - 1] + dessertCalories[dessert - 1];
            return totalCalories;
        }
    }
}

