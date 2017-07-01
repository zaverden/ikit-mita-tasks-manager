using System.Threading.Tasks;

namespace TasksManager.DataAccess.Commands
{
    public interface IDeleteProjectCommand
    {
        Task ExecuteAsync(int projectId);
    }
}
