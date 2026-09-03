using AutoMapper;
using JobManagement.Dto;
using JobManagement.Model;
//using JobManagement.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace JobManagement.Service
{
    public class JobService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public JobService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Job?> GetJobByIdAsync(int id)
        {
            return await _context.Jobs.FindAsync(id);
        }
        // Get All Jobs
        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

        // Get Job By Id
        public async Task<JobDto?> GetJobDtoByIdAsync(int id)
        {
            var job = await _context.Jobs.FindAsync(id);

            if (job == null)
            {
                return null;
            }

            return _mapper.Map<JobDto>(job);
        }
        // Create Job
        public async Task CreateJobAsync(JobDto dto)
        {
            var job = _mapper.Map<Job>(dto);

            job.PostedDate = DateTime.Now;

            await _context.Jobs.AddAsync(job);

            await _context.SaveChangesAsync();
        }

        // Update Job
        public async Task UpdateJobAsync(int id, JobDto dto)
        {
            var job = await _context.Jobs.FindAsync(id);

            if (job == null)
                return;

            _mapper.Map(dto, job);

            await _context.SaveChangesAsync();
        }

        // Delete Job
        public async Task DeleteJobAsync(int id)
        {
            var job = await _context.Jobs.FindAsync(id);

            if (job == null)
                return;

            _context.Jobs.Remove(job);

            await _context.SaveChangesAsync();
        }
    }
}
