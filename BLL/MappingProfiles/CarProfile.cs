using AutoMapper;
using BLL.DTOs;
using DAL.Entities;

namespace BLL.MappingProfiles
{
    public class CarProfile: Profile
    {
        public CarProfile()
        {
            CreateMap<CarDto, Car>()
                .ForMember(d => d.DriverId, c => c.MapFrom(s => s.Driver.Id))
                .ForMember(d => d.Driver, o => o.Ignore());

            CreateMap<Car, CarDto>();
        }
    }
}
