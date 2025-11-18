using System;
using System.Collections.Generic;
using System.Text;

namespace MVCTileRepair
{
    public class TileModel
    {
        public double N { get; set; }
        public double W { get; set; }
        public double L { get; set; }
        public double M { get; set; }
        public double O { get; set; }
        public double TilesNeeded { get; set; }
        public double Time { get; set; }
        public void Calculate()
        {
            double area = N * N;
            double bench = M * O;
            double toCover = area - bench;
            double tile = W * L;
            TilesNeeded = toCover / tile;
            Time = TilesNeeded * 0.2;
        }
    }
}
