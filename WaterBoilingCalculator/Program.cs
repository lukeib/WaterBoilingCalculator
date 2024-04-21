public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите значение атмосферного давление на уровне моря:");
        double seaLevelPressure = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите высоту(в метрах), на которой необходимо расчитать атмосферное давление:");
        double heightAboveSeaLevel = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение температуры на уровне моря в цельсиях:");
        double seaLevelTemperatureInCelsius = double.Parse(Console.ReadLine());

        PressureFormula press = new PressureFormula(seaLevelPressure, heightAboveSeaLevel, seaLevelTemperatureInCelsius);
        Console.WriteLine($"Атмосферное давление на высоте: {heightAboveSeaLevel}м. примерно равно: {Math.Round(press.pressureAtHeight),2} мм.рт.ст.");
    }
}