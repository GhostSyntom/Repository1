using System;
using System.Collections.Generic;
using System.Text;

namespace MVCMagicNumbers
{
    public class MagicController
    {
        private MagicModel _model;
        public MagicController()
        {
            _model = new MagicModel();
        }
        public void GetInput()
        {
            Console.WriteLine("Enter magic number:");
            _model.MagicNumber = int.Parse(Console.ReadLine());
        }
        public void Process()
        {
            _model.GenerateMagicNumbers();
        }
        public void DisplayResult()
        {
            Console.WriteLine(string.Join(" ", _model.MagicNumbers));
        }
    }
}
