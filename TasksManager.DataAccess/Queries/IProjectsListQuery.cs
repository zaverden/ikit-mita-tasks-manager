using System.Threading.Tasks;
using TasksManager.ViewModel;
using TasksManager.ViewModel.Filters;
using TasksManager.ViewModel.Responses;

namespace TasksManager.DataAccess.Queries
{
    public interface IProjectsListQuery
    {
        Task<ListResponse<ProjectResponse>> RunAsync(ProjectFilter filter, ListOptions options);
    }
}
