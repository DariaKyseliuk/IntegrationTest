using System.Collections.Generic;

namespace BLL.DTOs
{
    public class DriverDto
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DisplayName { get; set; }

        public List<CarDto> Cars { get; set; }
    }
}
