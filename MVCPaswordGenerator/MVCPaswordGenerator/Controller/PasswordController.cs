using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPaswordGenerator
{
    public class PasswordController
    {
        private PasswordModel _model;
        private PasswordView _view;

        public PasswordController()
        {
            _model = new PasswordModel();
            _view = new PasswordView();
        }

        public void Run()
        {
            _model.N = _view.ReadInt("Enter n: ");
            _model.L = _view.ReadInt("Enter l: ");

            var passwords = _model.GeneratePasswords();

            _view.ShowPasswords(passwords);
        }
    }
}
