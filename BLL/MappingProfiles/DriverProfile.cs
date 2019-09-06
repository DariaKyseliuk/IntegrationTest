using AutoMapper;
using BLL.DTOs;
using DAL.Entities;

namespace BLL.MappingProfiles
{
    public class DriverProfile: Profile
    {
        public DriverProfile()
        {
            CreateMap<DriverDto, Driver>()
                .ForMember(d => d.Cars, o => o.Ignore());

            CreateMap<Driver, DriverDto>();
        }
    }
}
