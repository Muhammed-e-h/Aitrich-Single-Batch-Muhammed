using AutoMapper;
using NEWJOBPORTAL.DTOs;
using NEWJOBPORTAL.Models;


namespace NEWJOBPORTAL.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job , JobDTOs>().ReverseMap();
        }
    }
}
