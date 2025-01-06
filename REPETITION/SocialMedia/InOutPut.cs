namespace SocialMedia;

public class InOutPut
{
    private int _choice = 10;
    private string _input;
    private User _user;
    
    private User _mainUser = new User(30,"Per","Olsen","polsen@mail.com",12322123,"Norway");

    private List<User> _users = new List<User>
    {
        new User(43,"Gunnar","Hansen","ghansen@mail.com",22133213,"Sweden"),
        new User(33,"Pål","Gundersen","gundersen@mail.com",33121213,"Denmark"),
        new User(23,"Espen","Larsen","elarsen@mail.com",44212321,"France")
    };

    public InOutPut()
    {
        MainUserMenu();
    }

    private void DisplayMainUserInfo(User user)
    {
        Console.WriteLine("Logged in user: \n" +
                          $"Name: {user.Fname} {user.Lname}\n" +
                          $"Age: {user.Age}\n" +
                          $"Email: {user.Email}\n" +
                          $"Phone: {user.Phone}\n" +
                          $"Country: {user.Country}\n");
    }

    private User FinduserByName(List<User> users, string name)
    {
        return users.FirstOrDefault(u => u.Fname == name);
    }
    
    private User AddFriend()
    {
        Console.WriteLine("Enter the first name of the person you would like to add: \n");
        _input = Console.ReadLine();
        //foreach (User user in _users)
        //{
        //    if (user.Fname == _input)
        //    {
        //        return user;
        //    }
        //}
        return FinduserByName(_users, _input);
    }

    private User RemoveFriend()
    {
        Console.WriteLine("Enter the first name of the person you would like to remove: \n");
        _input = Console.ReadLine();
        
        //foreach (User user in _mainUser.Friends)
        //{
        //    if (user.Fname == _input)
        //    {
        //        return user;
        //    }
        //    Console.WriteLine("There is no user with this name");
        //    return null;
        //}

        return FinduserByName(_users, _input);
    }

    private void ShowAllFriends()
    {
        foreach (var user in _mainUser.Friends)
        {
            Console.WriteLine($"Name: {user.Fname} {user.Lname}\n");
        }
    }

    private void ShowMoreFriendInfo()
    {
       Console.WriteLine("Enter the name of the person you would like to show: \n");
       _input = Console.ReadLine();

       foreach (User user in _mainUser.Friends)
       {
           if (user.Fname == _input)
           {
               Console.WriteLine($"Name: {user.Fname} {user.Lname}\n" +
                                 $"Age: {user.Age}\n" +
                                 $"Email: {user.Email}\n" +
                                 $"Phone: {user.Phone}\n" +
                                 $"Country: {user.Country}\n" +
                                 "----------------------------");
           }
       }
    }

    private void ShowAllUsers()
    {
        foreach (User user in _users)
        {
            Console.WriteLine($"Name: {user.Fname} {user.Lname}\n");
        }
    }
    
    void MainUserMenu()
    {
        while (_choice != 0)
        {   
            DisplayMainUserInfo(_mainUser);
            
            Console.WriteLine("\n\n[1] Add Friend\n" +
                              "[2] Remove friend\n" +
                              "[3] Show all friends\n" +
                              "[4] Show more info about a friend\n" +
                              "[5] Show all users\n" +
                              "[0] Exit\n");
            
            _choice = Convert.ToInt32(Console.ReadLine());
            
            switch (_choice)
            {
                case 0:
                    return;
                case 1:
                    var addFriend = AddFriend();
                    if (addFriend != null)
                    {
                        _mainUser.AddFriend(addFriend);
                        Console.WriteLine("Friend added");
                    }
                    break;
                case 2:
                    var removeFriend = RemoveFriend();
                    if (removeFriend != null)
                    {
                        _mainUser.RemoveFriend(removeFriend);
                        Console.WriteLine("Friend removed");
                    }
                    break;
                case 3:
                    ShowAllFriends();
                    break;
                case 4:
                    ShowMoreFriendInfo();
                    break;
                case 5:
                    ShowAllUsers();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}