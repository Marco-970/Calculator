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
            _userInteractor.DisplayMessage("Enter the first number:");
            double x = double.Parse(_userInteractor.GetUserInput());
            _userInteractor.DisplayMessage("Enter the second number, leave blank if there is none:");
            double y = double.Parse(_userInteractor.GetUserInput());
            _userInteractor.DisplayMessage("Select from the menu what you'd like to do. Write the name or the symbol if there is one:\n");
            foreach(var option in Enum.GetNames(typeof(MenuOptions)))
            {
                _userInteractor.DisplayMessage(option);
            }
            switch(_userInteractor.GetUserInput())
            {
                case "Addition":
                case "+":
                    _userInteractor.DisplayMessage($"{x} + {y} = {_mathLogic.Add(x, y)}");
                    break;
                case "Subtraction":
                case "-":
                    _userInteractor.DisplayMessage($"{x} - {y} = {_mathLogic.Subtract(x, y)}");
                    break;
                case "Multiplication":
                case "x":
                    _userInteractor.DisplayMessage($"{x} * {y} = {_mathLogic.Multiply(x, y)}");
                    break;
                case "Division":
                case "/":
                    _userInteractor.DisplayMessage($"{x} / {y} = {_mathLogic.Divide(x, y)}");
                    break;
                case "Square":
                    _userInteractor.DisplayMessage($"√{x} = {_mathLogic.SquareRoot(x)}");
                    break;
            }
        }
    }
}
