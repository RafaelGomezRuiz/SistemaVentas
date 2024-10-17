namespace SistemaVentas.Core.Application.Interfaces.Services
{
    public interface IGenericService <SaveViewModel, ViewModel,Entity>
        where SaveViewModel : class
        where ViewModel : class
        where Entity : class
    {
        Task<SaveViewModel?> AddAsync(SaveViewModel saveVM);
        Task DeleteAsync(int entityId);
        Task<SaveViewModel> UpdateAsync(SaveViewModel saveVM, int svmId);
        Task<List<ViewModel>> GetAllAsync();
        Task<SaveViewModel> GetById(int entityId);
    }
}
