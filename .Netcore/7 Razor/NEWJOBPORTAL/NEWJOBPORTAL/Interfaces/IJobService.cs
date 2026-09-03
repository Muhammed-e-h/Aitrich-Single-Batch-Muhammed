using NEWJOBPORTAL.Models;


namespace JobPortal.Interfaces
{
    public interface IJobService
    {
        Task<List<Job>> GetAllJobsAsync();

        Task<Job?> GetJobByIdAsync(int id);

        Task AddJobAsync(Job job);

        Task UpdateJobAsync(int id);

        Task DeleteJobAsync(int id);
    }
}