using DAL.Data;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class DriversRepository: Repository<Driver>, IDriversRepository
    {
        public DriversRepository(SqlContext dbContext)
            : base(dbContext)
        {
        }
    }
}
