using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class CarsService : Service<CarDto, Car>, ICarsService
    {
        public CarsService(ICarsRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
