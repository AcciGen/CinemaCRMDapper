namespace CinemaCRMDapper.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public long budget { get; set; }
        public float avgRate { get; set; }
    }
}
