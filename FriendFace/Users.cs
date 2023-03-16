using System;
using System.Collections.Generic;

namespace FriendFace
{
    public class Users
    {
        private List<User> users;

        public Users()
        {
            this.users = new List<User>();
        }
        public void Add(User user)
        {
            try
            {
                this.users.Add(user);
            }
            catch
            {
                Console.WriteLine($"An account with the username {user.username} already exists");
                Console.WriteLine();
            }
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

