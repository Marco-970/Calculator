using Calculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace Calculator
{
    internal class App
    {
        IUserInteractor _userInteractor;
        MathLogic _mathLogic;
        public App(IUserInteractor userInteractor, MathLogic mathLogic)
        {
            _userInteractor = userInteractor;
            _mathLogic = mathLogic;
        }

        public void Run()
        {
            _userInteractor.DisplayMessage("Select from the menu what you'd like to do:\n");
            foreach(var option in Enum.GetNames(typeof(MenuOptions)))
            {
                _userInteractor.DisplayMessage(option);
            }
        }
    }
}
