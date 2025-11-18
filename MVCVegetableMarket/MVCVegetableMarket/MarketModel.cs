using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MVCVegetableMarket
{
    internal class MarketModel
    {
        public double _levPerVegetableKg;
        public double _levPerFruitKg;

        public double _levToEuroRate = 1.94;

        public int _totalVegetableKg;
        public int _totalFruitKg;

        public double CalculateEuro()
        {
            double totalLeva = (_levPerVegetableKg * _totalVegetableKg) + (_levPerFruitKg * _totalFruitKg);
            return totalLeva / 1.94;
        }
        
    }
}
