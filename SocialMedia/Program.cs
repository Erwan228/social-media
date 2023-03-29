namespace SocialMedia
{
    internal class FuckfriendFace
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
        public static void Main(string[] args)
        {
            var erewan = new User("Erwan", "Music Rioulu", "Fox Falls");
            var sondre = new User("Simen", "Cobbler69", "London pub");
            var person1 = new User("Karl", "Rider", "Astra");
            var person2 = new User("Lars", "Lord Lolorito", "Eorzea");
            var person3 = new User("Per", "Penis Warrior", "Porsgrunn");
            var silve = new User("Erwan", "Silver Fox", "Drammen");
            List<User> users = new List<User>();
            users.Add(erewan);
            users.Add(sondre);
            users.Add(person1);
            users.Add(person2);
            users.Add(person3);
            users.Add(silve);
            foreach (var user in users)
            {
                Console.WriteLine(user.Name + " er kjent som " + user.ScreenName);
            }
            Console.WriteLine("\n La oss begynne");
            Console.WriteLine("Skriv inn ditt navn");
            string realNameAnswer = Console.ReadLine();
            Console.WriteLine("...Er det virkelig ditt virkelige navn? (y/n)");
            Console.ReadLine();
            Console.WriteLine("No matter...");
            Console.WriteLine("Hva vil du bli kalt på dette planet?");
            string desiredNameAnswer = Console.ReadLine();
            Console.WriteLine($"Da sier vi det...{desiredNameAnswer}r? Sa jeg det rikitg? (y/n)");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("...bra.", ConsoleColor.DarkRed);
            Console.WriteLine();
            Console.WriteLine("! !");
            Console.WriteLine(" _");
        }
        public static void AddFriend()
        {
            Console.WriteLine();
        }

        public static void RemoveFriend()
        {
            Console.WriteLine();
        }
    }
}