using System;
using System.Collections.Generic;
using System.Text;

namespace MVCVegetableMarket
{
    internal class MarketController
    {
        private MarketModel _model;
        public MarketController()
        {
            _model = new MarketModel();
        }
        public void GetInput()
        {
            Console.WriteLine("Enter price for vegetables per kg:");
            _model.LevPerVegetableKg = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter price for fruits per kg:");
            _model.LevPerFruitKg = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter kg of vegetables:");
            _model.TotalVegetableKg = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter kg of fruits:");
            _model.TotalFruitKg = int.Parse(Console.ReadLine());
        }
        public void DisplayResult()
        {
            double euro = _model.CalculateEuro();
            Console.WriteLine($"Total revenue in euros: {euro}");
        }
    }
}
