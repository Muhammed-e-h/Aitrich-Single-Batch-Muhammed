
//using AutoMapper;
//using NEWJOBPORTAL.Interfaces;
//using NEWJOBPORTAL.Models;
//using Microsoft.EntityFrameworkCore;

//namespace NEWJOBPORTAL.Repositories
//{
//    public class JobRepository :IJobRepository
//    {
//        private readonly JobManagementportalContext _context;
//        private readonly IMapper _Mapper;

//        public JobRepository(JobManagementportalContext context, IMapper mapper)
//        {
//            _context = context;
//            _Mapper = mapper;
//        }
//        public async Task<List<Job>> GetAllJobsAsync()
//        {
//            return await _context.Jobs.ToListAsync();


//        }
//        public async Task<Job?> GetJobByIdAsync(int id)
//        {

//            return _context.Jobs.FirstOrDefault(j => j.Id == id);
//            return _Mapper.Map<Job>(id);
//        }
//        public async Task AddJobAsync(Job job)
//        {
//            await _context.Jobs.AddAsync(job);
//            await _context.SaveChangesAsync();
//        }
//        //public async Task UpdateJobAsync(int id)
//        //{

//        //    await _context.Jobs.Update(id);
//        //    await _context.SaveChangesAsync();
//        //}

//        public async Task DeleteJobAsync(int id)
//        {
//            var job = await _context.Jobs.FindAsync(id);

//            if (job == null)
//                return;
//            _context.Jobs.Remove(job);
//            await _context.SaveChangesAsync();

//        }
//    }
//}
