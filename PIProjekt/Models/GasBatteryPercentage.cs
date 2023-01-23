namespace PIProjekt.Models
{
    public class GasBatteryPercentage
    {
        internal static int GetPercentage()
        {
            Random random = new Random();
            return random.Next(0, 101);
        }
    }
}
