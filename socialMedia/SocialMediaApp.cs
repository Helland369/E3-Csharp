namespace socialMedia {


    class SocialMedia {

        User usr1 = new User("Per", "Gundersen", "Fredrikstad", "Jeg liker bil");
        User usr2 = new User("Pål", "Olsen", "Sarpsborg", "Jeg liker båt");
        User usr3 = new User("Espen", "Hansen", "Halden", "Jeg liker brød");
        User usr4 = new User("Gunnar", "Bråten", "Moss", "Jeg liker kake");
        User usr5 = new User("Hans", "Kristiansen", "Askim", "Jeg liker sjokolade");

        public List<User> userList = new List<User>();

        public SocialMedia() {
            userList.Add(usr1);
            userList.Add(usr2);
            userList.Add(usr3);
            userList.Add(usr4);
            userList.Add(usr5);
        }

        public void wievFriends() {

            if (usr1.friends != null) {
                foreach (User usr in usr1.friends) {
                    Console.WriteLine($"First name: {usr.fname}\nlast name: {usr.lname}\nPlace: {usr.place}\nBio: {usr.bio} \nFriends: {usr.friends}");
                }
            }
        }
        
        public void addFriend() {

            Console.WriteLine("Add a friend");

            foreach (User usr in userList)
            {
                Console.WriteLine(usr.fname, usr.lname, usr.place, usr.bio);
            }

            string input = Console.ReadLine().ToLower();

            switch (input) {
                case "pål":
                    usr1.friends.Add(usr2);
                    break;
                case "espen":
                    usr1.friends.Add(usr3);
                    break;
                case "gunnar":
                    usr1.friends.Add(usr4);
                    break;
                case "hans":
                    usr1.friends.Add(usr5);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        }

        public void removeFriend() {

            Console.WriteLine("Delete a friend");
            
            if (usr1.friends != null) {

                foreach (User usr in usr1.friends) {
                    Console.WriteLine(usr);
                }

                Console.WriteLine("Write the name of the friend you want to delete");
                string input = Console.ReadLine().ToLower();

                switch (input) {
                    case "pål":
                        usr1.friends.Remove(usr2);
                        break;
                    case "espen":
                        usr1.friends.Remove(usr3);
                        break;
                    case "gunnar":
                        usr1.friends.Remove(usr4);
                        break;
                    case "hans":
                        usr1.friends.Remove(usr5);
                        break;
                }

            } else {
                Console.WriteLine("You have no friends");
            }
        }

        public void printLogedinUser() {

            Console.WriteLine($"First name: {usr1.fname}\nLast name: {usr1.lname}\nPlace: {usr1.place}\nBio: {usr1.bio}");
        }

        public void mainMenu()
        {
            printLogedinUser();

            int x;

            while (true)
            {

                Console.WriteLine("1. Add friend \n2. Remove friend \n3. Wiev friend list");
                x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        addFriend();
                        break;
                    case 2:
                        removeFriend();
                        break;
                    case 3:
                        wievFriends();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
