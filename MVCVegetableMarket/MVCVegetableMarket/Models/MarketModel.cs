using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MVCVegetableMarket
{
    internal class MarketModel
    {
        public double LevPerVegetableKg;
        public double LevPerFruitKg;

        public double LevToEuroRate = 1.94;

        public int TotalVegetableKg;
        public int TotalFruitKg;

        public double CalculateEuro()
        {
            double totalLeva = (LevPerVegetableKg * TotalVegetableKg) + (LevPerFruitKg * TotalFruitKg);
            return totalLeva / 1.94;
        }
        
    }
}
