using System;
using System.Collections.Generic;
using System.Text;

namespace MVCDivisionWithouthLeftout
{
    public class DivisionModel
    {
        public List<int> Numbers { get; set; } = new List<int>();
        public double PercentDivBy2 => (double)Numbers.FindAll(x => x % 2 == 0).Count / Numbers.Count * 100;
        public double PercentDivBy3 => (double)Numbers.FindAll(x => x % 3 == 0).Count / Numbers.Count * 100;
        public double PercentDivBy4 => (double)Numbers.FindAll(x => x % 4 == 0).Count / Numbers.Count * 100;
    }
}
