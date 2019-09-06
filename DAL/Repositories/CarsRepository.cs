using DAL.Data;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class CarsRepository : Repository<Car>, ICarsRepository
    {
        public CarsRepository(SqlContext dbContext)
            : base(dbContext)
        {
        }
    }
}
