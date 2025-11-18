using System;
using System.Collections.Generic;
using System.Text;

namespace MVCTubeForPool
{
    public class PoolModel
    {
        public int V { get; set; }
        public int P1 { get; set; }
        public int P2 { get; set; }
        public double H { get; set; }
        public double TotalWater => (P1 + P2) * H;
        public bool IsOverflow => TotalWater > V;
        public int FullPercent => (int)((TotalWater / V) * 100);
        public double WaterP1 => P1 * H;
        public double WaterP2 => P2 * H;
        public int Pipe1Percent => (int)((WaterP1 / TotalWater) * 100);
        public int Pipe2Percent => (int)((WaterP2 / TotalWater) * 100);
        public double Overflow => TotalWater - V;
    }
}
