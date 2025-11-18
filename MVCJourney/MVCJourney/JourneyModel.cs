using System;
using System.Collections.Generic;
using System.Text;

namespace MVCJourney
{
    public class VacationModel
    {
        public double Budget { get; set; }
        public string Season { get; set; }
        public string Destination
        {
            get
            {
                if (Budget <= 100) return "Bulgaria";
                else if (Budget <= 1000) return "Balkans";
                else return "Europe";
            }
        }
        public string Accommodation
        {
            get
            {
                if (Destination == "Europe") return "Hotel";
                else return Season == "summer" ? "Camp" : "Hotel";
            }
        }
        public double Cost
        {
            get
            {
                double percentage = 0;
                if (Destination == "Bulgaria")
                {
                    percentage = Season == "summer" ? 0.30 : 0.70;
                }
                else if (Destination == "Balkans")
                {
                    percentage = Season == "summer" ? 0.40 : 0.80;
                }
                else
                {
                    percentage = 0.90;
                }
                return Budget * percentage;
            }
        }
    }
}
