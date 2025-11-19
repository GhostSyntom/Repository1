using MVCTileRepair;

class Program
{
    static void Main(string[] args)
    {
        TileController controller = new TileController();
        controller.GetInput();
        controller.Process();
        controller.DisplayResult();
    }
}