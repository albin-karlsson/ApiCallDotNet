namespace ApiCallDotNet.Models
{
    public class Root
    {
        public List<User> Users { get; set; }
        public int Total { get; set; }
        public int Skip { get; set; }
        public int Limit { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Hair Hair { get; set; }
    }

    public class Hair
    {
        public string Color { get; set; }
        public string Type { get; set; }
    }
}
