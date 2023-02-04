using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMediaIO
{
    public class User
    {
        private String Username;
        private String Password;
        public User(String username, String password)
        { 
            this.Username = username;
            this.Password = password;
        }

        public String GetUsername()
        {
            return this.Username;
        }

        public String GetPassword()
        {
            return this.Password;
        }
    }

    public class Post
    {
        private int id;
        private String author;
        private String title;
        private String content;
        
        public Post() { }
        public Post(int id, string author, string title, string content)
        {
            this.id = id;
            this.author = author;
            this.title = title;
            this.content = content;
        }

        //getters
        public int GetId()
        {
            return this.id;
        }

        public String GetAuthor() 
        {
            return this.author;
        }

        public String GetTitle()
        {
            return this.title;
        }

        public String GetContent()
        {
            return this.content;
        }
    }

    public static class Home
    {
        private static User currentUser;
        private static List<User> UserList = new List<User>();
        private static List<Post> PostList = new List<Post>();

        public static void SetCurrentUser(User user)
        {
            currentUser = user;
        }

        public static String GetCurrentUserName() 
        {
            return currentUser.GetUsername();
        }

        public static List<User> GetUserList()
        {
            return UserList;
        }

        public static List<Post> GetPostList()
        {
            return PostList;
        }


        private static void Main(string[] args)
        {

        }
    }
}