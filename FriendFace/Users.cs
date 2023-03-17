using System;
using System.Collections.Generic;

namespace FriendFace
{
    public class Users
    {
        public List<User> RegisteredUsers { get; private set; }

        public Users()
        {
            RegisteredUsers = new List<User>();
        }
        public void Add(User user)
        {
            RegisteredUsers.Add(user);
        }
        public User GetUser(string username)
        {
            var user = RegisteredUsers.Find(u => u.Username == username);

            if (user == null)
            {
                Console.WriteLine($"An account with the username {username} does not exist");
                Console.WriteLine();
                return null;
            }
            else
            {
                return user;
            }
        }
    }
}

