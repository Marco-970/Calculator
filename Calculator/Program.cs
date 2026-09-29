using Calculator.Application;
using Tools;
namespace Calculator;

internal class Program
{
    static void Main(string[] args)
    {
        ICalculatorUserInteractor _userInteractor = new CalculatorConsoleUserInteractor((new ConsoleUserInteractor()));
        App app = new App(_userInteractor, new MathLogic());

        app.Run();
        _userInteractor.Quit();
    }
}
