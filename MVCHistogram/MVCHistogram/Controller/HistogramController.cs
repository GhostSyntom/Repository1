using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHistogram
{
    public class HistogramController
    {
        private HistogramModel _model;
        private HistogramView _view;

        public HistogramController()
        {
            _model = new HistogramModel();
            _view = new HistogramView();
        }

        public void Run()
        {
            _model.Count = _view.ReadInt("Enter count N: ");

            for (int i = 0; i < _model.Count; i++)
            {
                int number = _view.ReadInt("");
                _model.Numbers.Add(number);
            }

            double[] percentages = _model.CalculatePercentages();

            _view.ShowPercentages(percentages);
        }
    }
}
