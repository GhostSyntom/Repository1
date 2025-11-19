using MVCVegetableMarket;

internal class Program
{
    static void Main(string[] args)
    {
        MarketController controller = new MarketController();
        controller.GetInput();
        controller.DisplayResult();
    }
}