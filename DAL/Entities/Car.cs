namespace DAL.Entities
{
    public class Car: Entity
    {
        public override string Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Number { get; set; }

        public string DriverId { get; set; }

        public Driver Driver { get; set; }
    }
}
