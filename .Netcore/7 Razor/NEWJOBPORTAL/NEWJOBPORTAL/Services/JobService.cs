using NEWJOBPORTAL.Interfaces;
using NEWJOBPORTAL.Models;
using AutoMapper;
using NEWJOBPORTAL.DTOs;
using Microsoft.EntityFrameworkCore;
using JobPortal.Interfaces;

namespace NEWJOBPORTAL.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await _jobRepository.GetAllJobsAsync();
        }

        public async Task<Job?> GetJobByIdAsync(int id)
        {
            return await _jobRepository.GetJobByIdAsync(id);
        }
        public async Task AddJobAsync(Job job)
        {
            await _jobRepository.AddJobAsync(job);
        }

        public async Task UpdateJobAsync(int id)
        {
            await _jobRepository.UpdateJobAsync(id);
        }
        public async Task DeleteJobAsync(int id)
        {
            await _jobRepository.DeleteJobAsync(id);
        }


    }
}
