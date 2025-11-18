using MVCMagicNumbers;

class Program
{
    static void Main(string[] args)
    {
        MagicController controller = new MagicController();
        controller.GetInput();
        controller.Process();
        controller.DisplayResult();
    }
}