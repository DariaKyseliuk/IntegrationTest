namespace BLL.DTOs
{
    public class CarDto
    {
        public string Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Number { get; set; }

        public DriverDto Driver { get; set; }
    }
}
