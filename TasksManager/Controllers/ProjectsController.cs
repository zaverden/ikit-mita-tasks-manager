using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TasksManager.ViewModel;
using TasksManager.ViewModel.Filters;
using TasksManager.ViewModel.Requests;
using TasksManager.ViewModel.Responses;

namespace TasksManager.Controllers
{
    [Route("api/[controller]")]
    public class ProjectsController : Controller
    {
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ListResponse<ProjectResponse>))]
        public Task<IActionResult> GetProjectsListAsync(ProjectFilter filter, ListOptions options)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ProducesResponseType(201, Type = typeof(ProjectResponse))]
        [ProducesResponseType(400)]
        public Task<IActionResult> CreateProjectAsync([FromBody]CreateProjectRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{projectId}")]
        [ProducesResponseType(200, Type = typeof(ProjectResponse))]
        [ProducesResponseType(404)]
        public Task<IActionResult> GetProjectAsync(int projectId)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{projectId}")]
        [ProducesResponseType(200, Type = typeof(ProjectResponse))]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        public Task<IActionResult> UpdateProjectAsync(int projectId, [FromBody]UpdateProjectRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{projectId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public Task<IActionResult> DeleteProjectAsync(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
