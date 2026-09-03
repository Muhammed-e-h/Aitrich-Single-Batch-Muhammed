namespace NEWJOBPORTAL.DTOs
{
    public class JobDTOs
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public string Company { get; set; }

        public string Location { get; set; } 

        public decimal Salary { get; set; }

        public DateTime PostedDate { get; set; }
    }
}