namespace SocialMedia
{
    internal class FuckfriendFace
    {

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
            Console.WriteLine("BRA!!");
            Console.WriteLine();
            Console.WriteLine("! !");
            Console.WriteLine(" _");
            Console.WriteLine();
            Console.WriteLine("Da setter vi opp profilen din da!");
            Console.WriteLine("#######");
            var freshBlood = new User(desiredNameAnswer, realNameAnswer + "r", "Void");
            List<String> friends = new List<String>();
            Console.ForegroundColor = ConsoleColor.White;
            MainPage(realNameAnswer, desiredNameAnswer, users);


        }
        public static void AddFriend()
        {
            ;
        }

        public static void RemoveFriend()
        {
            Console.WriteLine();
        }

        public static void MainPage(string realName, string desiredName, List<User> users)
        {
            Console.WriteLine("Hva vil du gjøre? \n Se profilen din? (p) \n Se en liste over andre brukere? (f)");
            string input = Console.ReadLine();
            if (input == "p")
            {
                Console.Clear();
                Console.WriteLine("Her er din profil");
                Console.WriteLine();
                Console.WriteLine($"Virkelig navn: {realName} \n Display: {desiredName} \n");
                Console.WriteLine();
                Console.WriteLine("Venneliste:");
                //foreach (var friend in Friendslist.Friends)
                //{
                //    Console.WriteLine(friend.Name);
                //}
            }
            else if (input == "f")
            {
                Console.Clear();
                Console.WriteLine("Her er en list eover andre bruker:");
                foreach (var user in users)
                {
                    Console.WriteLine(user.ScreenName);
                    Console.WriteLine(user.Location);
                    Console.WriteLine();
                }
            }
            else
            {
                int w = 1;
                while (w > 0)
                {
                    Console.WriteLine("RUN! ", Console.ForegroundColor = ConsoleColor.DarkRed);
                }
            }
        }
    }
}