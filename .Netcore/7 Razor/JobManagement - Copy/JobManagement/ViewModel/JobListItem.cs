using JobManagement.Dto;

namespace JobManagement.ViewModel
{
    public class JobListItem
    {
        public int Id { get; set; }      // For Edit/Delete
        public JobDto Job { get; set; }
    }
}
