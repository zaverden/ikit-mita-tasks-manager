namespace TasksManager.ViewModel.Filters
{
    public class ProjectFilter
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? OpenTasksCountFrom { get; set; }
        public int? OpenTasksCountTo { get; set; }
    }
}
