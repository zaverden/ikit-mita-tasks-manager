namespace TasksManager.Entities
{
    public class TagsInTask : DomainObject
    {
        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}
