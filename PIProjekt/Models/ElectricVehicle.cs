namespace PIProjekt.Models
{
    public class ElectricVehicle : Vehicle
    {
        public int BatteryPercentage { get; set; } = GasBatteryPercentage.GetPercentage();
    }
}
