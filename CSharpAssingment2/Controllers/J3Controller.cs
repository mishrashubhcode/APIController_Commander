using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CSharpAssingment2.Controllers
{
    public class J3Controller : ApiController
    {
        ///This is a J3 Question from year 2020 ( Mathematics and Computing Contests, CCC and CCO 2020 Problems and Tests)
        ///
        /// <summary>
        /// Computes the coordinates of the minimum bounding rectangle of a set of paint drops.
        /// </summary>
        /// <param name="paintDrops">A list of strings representing the coordinates of the paint drops.</param>
        /// <returns>A string representing the coordinates of the bottom-left and top-right corners of the minimum bounding rectangle.</returns>
        [HttpPost]
        public string PostPaintDrops([FromBody] List<string> paintDrops)
        {
            // Step 1: Parse input data

            //any paint drop with an x or y coordinate less than 'int.MaxValue' will update the value of minX and minY respectively.
            int minX = int.MaxValue, minY = int.MaxValue;
            int maxX = int.MinValue, maxY = int.MinValue;
            foreach (string paintDrop in paintDrops)
            {
                string[] parts = paintDrop.Split(',');
                int x = int.Parse(parts[0]);
                int y = int.Parse(parts[1]);
                minX = Math.Min(minX, x);
                minY = Math.Min(minY, y);
                maxX = Math.Max(maxX, x);
                maxY = Math.Max(maxY, y);
            }

            // Step 2: Compute coordinates of rectangular frame
            int bottomLeftX = minX - 1;
            int bottomLeftY = minY - 1;
            int topRightX = maxX + 1;
            int topRightY = maxY + 1;

            // Step 3: Create output string
            string output = $"{bottomLeftX},{bottomLeftY}\n{topRightX},{topRightY}";

            // Step 4: Return output
            return output;
        }

    }
}
