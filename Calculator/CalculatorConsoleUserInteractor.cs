using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace Calculator
{
    public class CalculatorConsoleUserInteractor : ICalculatorUserInteractor
    {
        private readonly IUserInteractor _console;
        public CalculatorConsoleUserInteractor(IUserInteractor console)
        {
            _console = console;
        }
        public (double number, double power) PromptUserForPower()
        {
            Console.WriteLine("Enter the number");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the power");
            double power = double.Parse(Console.ReadLine());
            return (number, power);
        }
        public (double x, double y) PromptUserForNumbers()
        {
            Console.WriteLine("Enter the first number");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double y = double.Parse(Console.ReadLine());
            return (x, y);
        }
        public double PromptUserForNumber()
        {
            Console.WriteLine("Enter the number");
            return double.Parse(Console.ReadLine());
        }

        public void DisplayMessage(string message) => _console.DisplayMessage(message);

        public void WriteOnSameLine(string message) => _console.WriteOnSameLine(message);

        public void ReadKey() => _console.ReadKey();

        public string GetUserInput() => _console.GetUserInput();

        public void Clear() => _console.Clear();

        public void Quit() => _console.Quit();

        public bool PromptUserForAnotherCalculation()
        {
            Console.WriteLine("Do you want to calculate some more? Y/N");
            return _console.GetUserInput().ToUpper() == "Y" ? true : false;
        }
    }
}
