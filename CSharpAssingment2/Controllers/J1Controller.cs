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
        /// <summary>
        /// Computes the total calories of the meal based on user's menu choices.
        /// </summary>
        /// <param name="burger">Integer representing the index of burger choice.</param>
        /// <param name="drink">Integer representing the index of drink choice.</param>
        /// <param name="side">Integer representing the index of side order choice.</param>
        /// <param name="dessert">Integer representing the index of dessert choice.</param>
        /// <returns>A string containing the total calorie count of the meal.</returns>
        /// 
        private int[] burgerCalories = { 461, 431, 420, 0 };
        private int[] drinkCalories = { 130, 160, 118, 0 };
        private int[] sideCalories = { 100, 57, 70, 0 };
        private int[] dessertCalories = { 167, 266, 75, 0 };

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int totalCalories = burgerCalories[burger - 1] + drinkCalories[drink - 1] + sideCalories[side - 1] + dessertCalories[dessert - 1];
            return $"Your total calorie count is {totalCalories}";
        }
    }
}

