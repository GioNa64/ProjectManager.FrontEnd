using ProyectManager.Models;

namespace ProyectManager.Services
{
    public interface ITareaService
    {
        Task<IEnumerable<Tarea>> GetAll();
        Task<Tarea> GetById(int id);

    }
}
