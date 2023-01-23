namespace PIProjekt.Models
{
    public class GasVehicle : Vehicle
    {
        public int GasPercentage { get; set; } = GasBatteryPercentage.GetPercentage();
    }
}
