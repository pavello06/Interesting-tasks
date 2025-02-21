namespace Autopark.Car
{
    public enum EngineType
    {
        Petrol,
        Gas,
        Electric
    }

    public class Engine
    {
        public static int[] PricesCoefficients = [5, 4, 7];

        public EngineType Type { get; }

        public Engine(EngineType type)
        {
            Type = type;
        }
    }
}