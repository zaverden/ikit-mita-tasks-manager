using System.Threading.Tasks;
using TasksManager.ViewModel.Responses;

namespace TasksManager.DataAccess.Queries
{
    public interface IProjectQuery
    {
        Task<ProjectResponse> RunAsync(int projectId);
    }
}
