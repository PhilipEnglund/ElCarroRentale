using System;

namespace ElCarroRentale.Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public double HorsePower { get; set; }
        public string Brand { get; set; }
        public string Colour { get; set; }
        public DateTime LastInspection { get; set; }
        public DateTime NextInspection { get; set; }
        public string LatestInspector { get; set; }
        public int Milage { get; set; }
        public double HourlyRate { get; set; }
        public bool AvailableForRent { get; set; }
    }
}