using System.Threading.Tasks;
using TasksManager.ViewModel.Requests;
using TasksManager.ViewModel.Responses;

namespace TasksManager.DataAccess.Commands
{
    public interface ICreateProjectCommand
    {
        Task<ProjectResponse> ExecuteAsunc(CreateProjectRequest request);
    }
}
