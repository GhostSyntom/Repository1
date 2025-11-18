using System;
using System.Collections.Generic;
using System.Text;

namespace MVCTileRepair
{
    public class TileController
    {
        private TileModel _model;
        public TileController()
        {
            _model = new TileModel();
        }
        public void GetInput()
        {
            _model.N = double.Parse(Console.ReadLine());
            _model.W = double.Parse(Console.ReadLine());
            _model.L = double.Parse(Console.ReadLine());
            _model.M = double.Parse(Console.ReadLine());
            _model.O = double.Parse(Console.ReadLine());
        }
        public void Process()
        {
            _model.Calculate();
        }
        public void DisplayResult()
        {
            Console.WriteLine(_model.TilesNeeded);
            Console.WriteLine(_model.Time);
        }
    }
