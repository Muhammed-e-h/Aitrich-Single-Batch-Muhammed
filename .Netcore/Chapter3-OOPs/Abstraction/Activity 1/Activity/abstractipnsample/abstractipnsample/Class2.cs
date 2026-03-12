using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractipnsample
{
    internal class JobSeeker:User
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Location {  get; set; }
        public string PhoneNo {  get; set; }
        public void ApplayJob(int  jobid)
        {
            Console.WriteLine("Job Searching Started...........");
        }
        public override void Welcome()
        {
           Console.WriteLine("welcome to Hire me now");
        }
    }
}
