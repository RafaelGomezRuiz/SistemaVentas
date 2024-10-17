using AutoMapper;
using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Application.Interfaces.Services;

namespace SistemaVentas.Core.Application.Services
{
    public class GenericService<SaveViewModel, ViewModel, Entity> : IGenericService<SaveViewModel, ViewModel, Entity>
        where SaveViewModel : class
        where ViewModel : class
        where Entity : class
    {
        protected readonly IGenericRepository<Entity> _repository;
        protected readonly IMapper _mapper;

        public GenericService(IGenericRepository<Entity> _repository, IMapper _mapper)
        {
            this._repository = _repository;
            this._mapper = _mapper;
        }

        public virtual async Task<SaveViewModel?> AddAsync(SaveViewModel saveVM)
        {
            var entity = _mapper.Map<Entity>(saveVM);
            return _mapper.Map<SaveViewModel>(await _repository.AddAsync(entity));
        }

        public async virtual Task DeleteAsync(int entityId)
        {
            Entity entity = await _repository.GetById(entityId);
            await _repository.DeleteAsync(entity);
        }

        public async virtual Task<List<ViewModel>> GetAllAsync()
        {
            return _mapper.Map<List<ViewModel>>(await _repository.GetAllAsync());
        }

        public async virtual Task<SaveViewModel> GetById(int entityId)
        {
            return _mapper.Map<SaveViewModel>(await _repository.GetById(entityId));
        }

        public async virtual Task<SaveViewModel> UpdateAsync(SaveViewModel saveVM, int svmId)
        {
            Entity entity = await _repository.UpdateAsync(_mapper.Map<Entity>(saveVM),svmId);

            return _mapper.Map<SaveViewModel>(entity);
        }
    }
}
