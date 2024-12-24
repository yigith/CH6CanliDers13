namespace Uygulama1.Services
{
    public class WeatherComService
    {
        public double GetTemperature(string place)
        {
            // bu örnek kod gerçek bir network bazlı hizmetle değiştirilebilir
            switch (place.ToLower())
            {
                case "ankara":
                    return 10;
                case "izmir":
                    return 10;
                case "istanbul":
                    return 11;
                case "tokat":
                    return 13;
                default:
                    return new Random().Next(-10, 36);
            }
        }
    }
}
