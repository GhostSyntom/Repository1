using MVCTubeForPool;

class Program
{
    static void Main(string[] args)
    {
        PoolController controller = new PoolController();
        controller.GetInput();
        controller.DisplayResult();
    }
}
