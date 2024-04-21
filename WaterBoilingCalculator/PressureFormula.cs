public class PressureFormula
{
    public const double AVERAGE_TEMPERATURE_LAPLACIAN_ATMOSPHERE = 0.0065; // средняя температурная лапласиана атмосферы (обычно примерно 0.0065 K/m),
    public const double ACCELERATION_OF_GRAVITY = 9.8066; // ускорение свободного падения (приблизительно 9.8 m/s^2)
    public const double MOLAR_MASS_AIR = 0.029; // молярная масса воздуха (приблизительно 0.029 kg/mol),
    public const double UNIVERSAL_GAS_CONSTANT = 8.3144; // универсальная газовая постоянная (приблизительно 8.314 J/(mol·K)).
    private double _seaLevelPressure;
    private double _heightAboveSeaLevel;
    private double _seaLevelTemperatureInCelsius; // Используем градусы Цельсия
    public double pressureAtHeight;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="seaLevelPressure">Атмосферное давление на уровне моря</param>
    /// <param name="heightAboveSeaLevel">Высота над уровнем моря</param>
    /// <param name="seaLevelTemperatureInCelsius">Температура над уровнем моря в цельсиях</param>
    public PressureFormula(double seaLevelPressure, double heightAboveSeaLevel, double seaLevelTemperatureInCelsius)
    {
        _seaLevelPressure = seaLevelPressure;
        _heightAboveSeaLevel = heightAboveSeaLevel;
        _seaLevelTemperatureInCelsius = seaLevelTemperatureInCelsius + 273.15; // конвертация из цельсия в кельвины
        PressureCalculation();
    }
    /// <summary>
    /// Формула основанная на барометрическом уравнении
    /// </summary>
    /// <returns>Давление на заданной высоте</returns>
    public double PressureCalculation()
    {
        pressureAtHeight = _seaLevelPressure * Math.Pow(1- (AVERAGE_TEMPERATURE_LAPLACIAN_ATMOSPHERE * _heightAboveSeaLevel / _seaLevelTemperatureInCelsius),
            (ACCELERATION_OF_GRAVITY * MOLAR_MASS_AIR) / (UNIVERSAL_GAS_CONSTANT * AVERAGE_TEMPERATURE_LAPLACIAN_ATMOSPHERE));
        return pressureAtHeight;
    }
}
