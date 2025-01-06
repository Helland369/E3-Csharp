namespace SocialMedia;

public class User
{
    private int _age, _phone;
    private string _fname, _lname, _email, _country;
    private List <User> _friends;

    public User(int age, string fname, string lname, string email, int phone, string country)
    {
        _age = age;
        _fname = fname;
        _lname = lname;
        _email = email;
        _phone = phone;
        _country = country;
        _friends = new List<User>();
    }
    
    public int Age { get { return _age; } set { _age = value; } }
    public string Fname { get { return _fname; } set { _fname = value; } }
    public string Lname { get { return _lname; } set { _lname = value; } }
    public string Email { get { return _email; } set { _email = value; } }
    public int Phone { get { return _phone; } set { _phone = value; } }
    public string Country { get { return _country; } set { _country = value; } }
    public List<User> Friends { get { return _friends; } set { _friends = value; } }
    
    public void AddFriend(User user) { _friends.Add(user); }
    public void RemoveFriend(User user) { _friends.Remove(user); }
}