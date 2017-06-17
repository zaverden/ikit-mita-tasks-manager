using System.Collections.Generic;

namespace TasksManager.ViewModel.Responses
{
    public class ProjectsListResponse
    {
        public ICollection<ProjectResponse> Items { get; set; }
        public string Sort { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalItemsCount { get; set; }
        public int TotalPagesCount
        {
            get
            {
                int pagesCount = TotalItemsCount / PageSize;
                if (TotalItemsCount % PageSize != 0)
                {
                    pagesCount += 1;
                }
                return pagesCount;
            }
        }
    }
}
