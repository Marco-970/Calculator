using Calculator.Application;
using Tools;
namespace Calculator;

internal class Program
{
    static void Main(string[] args)
    {
        ConsoleUserInteractor _consoleUserInteractor = new ConsoleUserInteractor();
        ICalculatorUserInteractor _userInteractor = new CalculatorConsoleUserInteractor((_consoleUserInteractor));
        App _app = new App(_userInteractor, new MathLogic());

        bool _keepCalculating = true;
        while (_keepCalculating)
        {
            _app.Run();
            _keepCalculating = _userInteractor.PromptUserForAnotherCalculation();
            _consoleUserInteractor.Clear();
        }
        _userInteractor.Quit();
    }
}
