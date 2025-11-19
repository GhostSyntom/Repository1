using System;
using System.Collections.Generic;
using System.Text;

namespace MVCPriceForTicket
{
    public class TransportController
    {
        private TransportView _view;
        private TransportModel _model;

        public TransportController()
        {
            _view = new TransportView();
            _model = new TransportModel();
        }

        public void Run()
        {
            _model.Kilometers = _view.ReadKilometers();
            _model.DayOrNight = _view.ReadDayOrNight();

            double cheapest = _model.GetCheapestTransport();

            _view.ShowResult(cheapest);
        }
    }
}
