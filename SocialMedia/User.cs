namespace SocialMedia
{
    public class User
    {
        public string Name { get; private set; }
        public string ScreenName { get; private set; }
        public string[] Friends { get; private set; }
        public string Location { get; private set; }
        public User(string name, string screeenname, string location)
        {
            Name = name;
            ScreenName = screeenname;
            Location = location;
        }



    }
}
