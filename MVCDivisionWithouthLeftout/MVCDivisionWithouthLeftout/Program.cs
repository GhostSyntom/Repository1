using MVCDivisionWithouthLeftout;

class Program
{
    static void Main(string[] args)
    {
        DivisionController controller = new DivisionController();
        controller.GetInput();
        controller.DisplayResult();
    }
}