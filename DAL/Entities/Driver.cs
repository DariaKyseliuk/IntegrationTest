using System.Collections.Generic;

namespace DAL.Entities
{
    public class Driver: Entity
    {
        public override string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DisplayName { get; set; }

        public List<Car> Cars { get; set; }
    }
}
