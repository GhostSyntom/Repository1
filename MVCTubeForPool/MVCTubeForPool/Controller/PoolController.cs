using System;
using System.Collections.Generic;
using System.Text;

namespace MVCTubeForPool
{
    public class PoolController
    {
        private PoolModel _model;
        public PoolController()
        {
            _model = new PoolModel();
        }
        public void GetInput()
        {
            Console.WriteLine("Enter pool volume V:");
            _model.V = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter pipe 1 flow rate P1:");
            _model.P1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter pipe 2 flow rate P2:");
            _model.P2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter hours H:");
            _model.H = double.Parse(Console.ReadLine());
        }
        public void DisplayResult()
        {
            if (_model.IsOverflow)
            {
                Console.WriteLine($"For {_model.H} hours the pool overflows with {_model.Overflow} liters.");
            }
            else
            {
                Console.WriteLine($"The pool is {_model.FullPercent}% full. Pipe 1: {_model.Pipe1Percent}%. Pipe 2: {_model.Pipe2Percent}%.");
            }
        }
    }
}
