using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class DriversService : Service<DriverDto, Driver>, IDriversService
    {
        public DriversService(IDriversRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
