using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExam
{
    public class ExamController
    {
        private ExamView _view;
        private ExamModel _model;

        public ExamController()
        {
            _view = new ExamView();
            _model = new ExamModel();
        }

        public void Run()
        {
            _model.ExamHour = _view.ReadNumber("Exam hour: ");
            _model.ExamMinute = _view.ReadNumber("Exam minute: ");
            _model.ArrivalHour = _view.ReadNumber("Arrival hour: ");
            _model.ArrivalMinute = _view.ReadNumber("Arrival minute: ");

            string status = _model.GetStatus();
            _view.ShowStatus(status);

            string details = _model.GetDetailedMessage();
            _view.ShowDetails(details);
        }
    }
}
