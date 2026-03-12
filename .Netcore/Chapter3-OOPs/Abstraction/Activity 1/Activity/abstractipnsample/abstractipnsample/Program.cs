using abstractipnsample;

internal class Program
{
    private static void Main(string[] args)
    {
       JobSeeker seeker = new JobSeeker();
        seeker.Login("aswathy1@gmail.com", "password");
        //seeker.Email = "aswathy1@gmail.com";
        //seeker.Password = "password";
        //seeker.Login();
        seeker.ApplayJob(1);
        seeker.Welcome();
      
    }
}