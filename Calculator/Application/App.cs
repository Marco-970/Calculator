using Calculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace Calculator.Application
{
    internal class App
    {
        ICalculatorUserInteractor _userInteractor;
        MathLogic _mathLogic;
        public App(ICalculatorUserInteractor userInteractor, MathLogic mathLogic)
        {
            _userInteractor = userInteractor;
            _mathLogic = mathLogic;
        }

        public void Run()
        {
            _userInteractor.DisplayMessage("Select from the menu what you'd like to do. Write the name or the symbol if there is one:\n");
            foreach (var option in Enum.GetNames(typeof(MenuOptions)))
            {
                _userInteractor.DisplayMessage(option);
            }
            switch(_userInteractor.GetUserInput())
            {
                case "Addition":
                case "+":
                    (double x, double y) additionNumbers = _userInteractor.PromptUserForNumbers();
                    _userInteractor.DisplayMessage($"{additionNumbers.x} + {additionNumbers.y} = {_mathLogic.Add(additionNumbers.x, additionNumbers.y)}");
                    break;
                case "Subtraction":
                case "-":
                    (double x, double y) subtractionNumbers = _userInteractor.PromptUserForNumbers();
                    _userInteractor.DisplayMessage($"{subtractionNumbers.x} - {subtractionNumbers.y} = {_mathLogic.Subtract(subtractionNumbers.x, subtractionNumbers.y)}");
                    break;
                case "Multiplication":
                case "x":
                    (double x, double y) multiplicationNumbers = _userInteractor.PromptUserForNumbers();
                    _userInteractor.DisplayMessage($"{multiplicationNumbers.x} * {multiplicationNumbers.y} = {_mathLogic.Multiply(multiplicationNumbers.x, multiplicationNumbers.y)}");
                    break;
                case "Division":
                case "/":
                    (double x, double y) divisionNumbers = _userInteractor.PromptUserForNumbers();
                    _userInteractor.DisplayMessage($"{divisionNumbers.x} / {divisionNumbers.y} = {_mathLogic.Divide(divisionNumbers.x, divisionNumbers.y)}");
                    break;
                case "Square":
                    double squareNumber = _userInteractor.PromptUserForNumber();
                    _userInteractor.DisplayMessage($"√{squareNumber} = {_mathLogic.SquareRoot(squareNumber)}");
                    break;
                case "Power":
                    (double number, double power) pow = _userInteractor.PromptUserForPower();
                    _userInteractor.DisplayMessage($"{pow.number} pow {pow.power} = {_mathLogic.Power(pow.number, pow.power)}");
                    break;
                case "Sine":
                    double sinNumber = _userInteractor.PromptUserForNumber();
                    _userInteractor.DisplayMessage($"Sine of {sinNumber} = {_mathLogic.Sine(sinNumber)}");
                    break;
                case "Cosine":
                    double cosineNumber = _userInteractor.PromptUserForNumber();
                    _userInteractor.DisplayMessage($"Cosine of {cosineNumber} = {_mathLogic.Cosine(cosineNumber)}");
                    break;
                case "Tan":
                    double tanNumber = _userInteractor.PromptUserForNumber();
                    _userInteractor.DisplayMessage($"Tan of {tanNumber} = {_mathLogic.Tan(tanNumber)}");
                    break;

            }
        }
    }
}
