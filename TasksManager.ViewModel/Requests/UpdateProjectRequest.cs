﻿using System.ComponentModel.DataAnnotations;

namespace TasksManager.ViewModel.Requests
{
    public class UpdateProjectRequest
    {
        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }
    }
}
