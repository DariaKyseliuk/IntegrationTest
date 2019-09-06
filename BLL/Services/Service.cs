using AutoMapper;
using BLL.Interfaces;
using DAL.Interfaces;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class Service<TDto, TEntity>: IService<TDto, TEntity> where TEntity : IEntity
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public Service(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TDto> Get(string id)
        {
            TEntity entity = await _repository.Get(id);
            return _mapper.Map<TDto>(entity);
        }

        public async Task<TDto> Add(TDto entityDto)
        {
            TEntity entity = _mapper.Map<TEntity>(entityDto);
            TEntity createdEntity = await _repository.Create(entity);
            return _mapper.Map<TDto>(createdEntity);
        }

        public async Task<TDto> Update(TDto entityDto)
        {
            TEntity entity = _mapper.Map<TEntity>(entityDto);
            TEntity updatedEntity = await _repository.Update(entity);
            return _mapper.Map<TDto>(updatedEntity);
        }

        public async Task<bool> Delete(string id)
        {
            return await _repository.Delete(id);
        }
    }
}
