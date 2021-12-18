using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Plant : Decoration
    {
        //Has 5 comfort and its price is 10.
        private const int PlantComfort = 5;
        private const decimal PlantPrice = 10;
        public Plant() : base(PlantComfort,PlantPrice)
        {
        }
    }
}
