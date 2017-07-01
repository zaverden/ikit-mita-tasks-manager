using System.Threading.Tasks;
using TasksManager.ViewModel.Requests;
using TasksManager.ViewModel.Responses;

namespace TasksManager.DataAccess.Commands
{
    public interface IUpdateProjectCommand
    {
        Task<ProjectResponse> ExecuteAsync(int projectId, UpdateProjectRequest request);
    }
}
