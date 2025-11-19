using System;
using System.Collections.Generic;
using System.Text;

namespace MVCJourney
{
    public class VacationController
    {
        private VacationModel _model;
        public VacationController()
        {
            _model = new VacationModel();
        }
        public void GetInput()
        {
            Console.WriteLine("Enter budget:");
            _model.Budget = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter season (summer or winter):");
            _model.Season = Console.ReadLine();
        }
        public void DisplayResult()
        {
            Console.WriteLine($"Somewhere in {_model.Destination}");
            Console.WriteLine($"{_model.Accommodation} - {_model.Cost:F2}");
        }
    }
}
