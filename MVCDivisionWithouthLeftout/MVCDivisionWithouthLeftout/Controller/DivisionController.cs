using System;
using System.Collections.Generic;
using System.Text;

namespace MVCDivisionWithouthLeftout
{
    public class DivisionController
    {
        private DivisionModel _model;
        public DivisionController()
        {
            _model = new DivisionModel();
        }
        public void GetInput()
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                _model.Numbers.Add(int.Parse(Console.ReadLine()));
            }
        }
        public void DisplayResult()
        {
            Console.WriteLine($"{_model.PercentDivBy2:F2}%");
            Console.WriteLine($"{_model.PercentDivBy3:F2}%");
            Console.WriteLine($"{_model.PercentDivBy4:F2}%");
        }
    }
}
