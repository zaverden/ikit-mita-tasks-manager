﻿using System;
using System.Threading.Tasks;
using TasksManager.DataAccess.Commands;
using TasksManager.Db;
using TasksManager.Entities;
using TasksManager.ViewModel.Requests;
using TasksManager.ViewModel.Responses;

namespace TasksManager.DataAccess.DbImplementation.Commands
{
    public class CreateProjectCommand : ICreateProjectCommand
    {
        private TasksContext Context { get; }
        public CreateProjectCommand(TasksContext context)
        {
            Context = context;
        }

        public async Task<ProjectResponse> ExecuteAsync(CreateProjectRequest request)
        {
            var project = new Project
            {
                Name = request.Name,
                Description = request.Description
            };
            await Context.Projects.AddAsync(project);
            await Context.SaveChangesAsync();
            return new ProjectResponse
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description,
                OpenTasksCount = 0
            };
        }
    }
}
