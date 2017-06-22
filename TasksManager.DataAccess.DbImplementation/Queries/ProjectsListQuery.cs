using System;
using System.Threading.Tasks;
using TasksManager.DataAccess.Queries;
using TasksManager.ViewModel;
using TasksManager.ViewModel.Filters;
using TasksManager.ViewModel.Responses;

namespace TasksManager.DataAccess.DbImplementation.Queries
{
    public class ProjectsListQuery : IProjectsListQuery
    {
        public Task<ListResponse<ProjectResponse>> RunAsync(ProjectFilter filter, ListOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
