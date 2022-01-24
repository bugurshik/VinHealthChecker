using System;

namespace VinHealthChecker.Models
{
    public class VinWrapper
    {
        public VinModel ETKAVin { get; set; }
        public VinModel PetVin { get; set; }
        public VinModel WrongVin { get; set; }
    }

    public class VinModel
    {
        public int Id { get; set; }
        public string Vin { get; set; }
        public string VinData { get; set; }
        public DateTime Date { get; set; }
    }
}
