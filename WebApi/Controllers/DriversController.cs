using BLL.DTOs;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class DriversController: Controller
    {
        private readonly IDriversService _driversSerice;

        public DriversController(IDriversService driversService)
        {
            _driversSerice = driversService;
        }

        [HttpGet]
        public void GetAll()
        {
            _driversSerice.Get("");
        }

        [HttpGet("{id}")]
        public async Task<DriverDto> Get(string id) => await _driversSerice.Get(id);

        [HttpPost]
        public async Task<DriverDto> Create(DriverDto entity) => await _driversSerice.Add(entity);

        [HttpPut]
        public async Task<DriverDto> Update(DriverDto entity) => await _driversSerice.Update(entity);

        [HttpDelete("{id}")]
        public async Task<bool> Delete(string id) => await _driversSerice.Delete(id);
    }
}
