using MVCJourney;

class Program
{
    static void Main(string[] args)
    {
        VacationController controller = new VacationController();
        controller.GetInput();
        controller.DisplayResult();
    }
}