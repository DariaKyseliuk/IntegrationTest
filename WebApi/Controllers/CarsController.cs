using BLL.DTOs;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CarsController: Controller
    {
        private readonly ICarsService _carsService;

        public CarsController(ICarsService carsService)
        {
            _carsService = carsService;
        }

        [HttpGet("{id}")]
        public async Task<CarDto> Get(string id) => await _carsService.Get(id);

        [HttpPost]
        public async Task<CarDto> Create(CarDto entity) => await _carsService.Add(entity);

        [HttpPut]
        public async Task<CarDto> Update(CarDto entity) => await _carsService.Update(entity);

        [HttpDelete("{id}")]
        public async Task<bool> Delete(string id) => await _carsService.Delete(id);
    }
}
