namespace ElCarroRentale.Areas.API.AutoMapper.Resources
{
    public class CreateCarResource
    {
        public string RegistrationNumber { get; set; }
        public double HorsePower { get; set; }
        public string Brand { get; set; }
        public string Colour { get; set; }
        public double HourlyRate { get; set; }
        public bool AvailableForRent { get; set; }
    }
}