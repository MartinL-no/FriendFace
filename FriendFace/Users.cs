using System;
using System.Collections.Generic;

namespace FriendFace
{
    public class Users
    {
        public List<User> users { get; private set; }

        public Users()
        {
            this.users = new List<User>();
        }
        public void Add(User user)
        {
            this.users.Add(user);
        }
        public User GetUser(string username)
        {
            var user = this.users.Find(u => u.username == username);

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

