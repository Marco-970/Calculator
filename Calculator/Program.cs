using Tools;
namespace Calculator;

internal class Program
{
    static void Main(string[] args)
    {
        IUserInteractor _userInteractor = new ConsoleUserInteractor();
        App app = new App(_userInteractor);

        app.Run();
    }
}
