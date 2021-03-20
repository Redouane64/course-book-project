namespace CourseBook.WebApi.Infrastructure
{
    public class JwtTokenParameters
    {
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public double LifeTime { get; set; }
    }
}
