namespace socialMedia {


    class User {
        public string fname { get; set; }
        public string lname { get; set; }
        public string place { get; set; }
        public string bio { get; set; }

        public User(string fname, string lname, string place, string bio) {
            this.fname = fname;
            this.lname = lname;
            this.place = place;
            this.bio = bio;
        }
        
        public List<User> friends = new List<User>();

    }
}
