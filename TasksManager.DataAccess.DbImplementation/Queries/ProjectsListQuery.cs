using System;
using System.Linq;
using System.Threading.Tasks;
using TasksManager.DataAccess.Queries;
using TasksManager.Db;
using TasksManager.Entities;
using TasksManager.ViewModel;
using TasksManager.ViewModel.Filters;
using TasksManager.ViewModel.Responses;
using TasksManager.DataAccess.DbImplementation.Extensions;
using Microsoft.EntityFrameworkCore;

namespace TasksManager.DataAccess.DbImplementation.Queries
{
    public class ProjectsListQuery : IProjectsListQuery
    {
        private TasksContext Context { get; }
        public ProjectsListQuery(TasksContext context)
        {
            Context = context;
        }

        public async Task<ListResponse<ProjectResponse>> RunAsync(ProjectFilter filter, ListOptions options)
        {
            IQueryable<ProjectResponse> query = Context.Set<Project>()
                .Select(p => new ProjectResponse
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    OpenTasksCount = p.Tasks.Count(t => t.Status != Entities.TaskStatus.Completed)
                });

            query = ApplyFilter(query, filter);
            int totalCount = await query.CountAsync();

            if (options.Sort == null)
            {
                options.Sort = "Id";
            }

            query = query.OrderBy(options.Sort);

            if (options.GetOffset() > 0)
            {
                query = query.Skip(options.GetOffset());
            }
            if (options.Count.ToInt32() != null)
            {
                query = query.Take(options.Count.ToInt32() ?? 1);
            }

            return new ListResponse<ProjectResponse>
            {
                Items = await query.ToListAsync(),
                Page = options.Page.Value,
                PageSize = options.Count.ToInt32() ?? 1,
                Sort = options.Sort,
                TotalItemsCount = totalCount
            };
        }

        private IQueryable<ProjectResponse> ApplyFilter(IQueryable<ProjectResponse> query, ProjectFilter filter)
        {
            if (filter.Id != null)
            {
                query = query.Where(pr => pr.Id == filter.Id);
            }

            if (filter.Name != null)
            {
                query = query.Where(pr => pr.Name.StartsWith(filter.Name));
            }

            if (filter.OpenTasksCountFrom != null)
            {
                query = query.Where(pr => pr.OpenTasksCount >= filter.OpenTasksCountFrom);
            }

            if (filter.OpenTasksCountTo != null)
            {
                query = query.Where(pr => pr.OpenTasksCount <= filter.OpenTasksCountTo);
            }

            return query;
        }
    }
}
