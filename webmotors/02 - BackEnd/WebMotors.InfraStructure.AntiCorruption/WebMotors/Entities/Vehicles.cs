namespace WebMotors.InfraStructure.AntiCorruption.WebMotors.Entities
{
    internal class Vehicles
    {
        public int Id { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Version { get; set; }
        public string? Image { get; set; }
        public int Km { get; set; }
        public string? Price { get; set; }
        public int YearModel { get; set; }
        public int YearFab { get; set; }
        public string? Color { get; set; }
    }
}
