using NEWJOBPORTAL.Models;

namespace NEWJOBPORTAL.Interfaces
{
    public interface IJobRepository
    {
        Task<List<Job>> GetAllJobsAsync();
        Task<Job?> GetJobByIdAsync(int id);

        Task AddJobAsync(Job job);
        Task UpdateJobAsync(int id);

        Task DeleteJobAsync(int id);
    }
}
