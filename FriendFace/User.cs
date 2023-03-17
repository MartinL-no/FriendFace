using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendFace
{
    public class User
    {
        public string Username { get; private set; }
        public int Age { get; private set; }
        public string Gender { get; private set; }
        public List<string> Friends { get; private set; }

        public User(string username, int age, string gender)
        {
            Friends = new List<string>();
            Username = username;
            Age = age;
            Gender = gender;
        }
        public void AddFriend(User requestedFriend)
        {
            if (Friends.Contains(requestedFriend.Username))
            {
                Console.WriteLine($"you are already friends with {requestedFriend.Username}");
                Console.WriteLine();
            }
            else
            {
                Friends.Add(requestedFriend.Username);
                requestedFriend.AcceptFriendRequest(this);

                Console.WriteLine($"you are now friends with {requestedFriend.Username}");
                Console.WriteLine();
            }
        }
        public void AcceptFriendRequest(User userSendingFriendRequest)
        {
            if (Friends.Contains(userSendingFriendRequest.Username))
            {
                Console.WriteLine($"{userSendingFriendRequest.Username} is already friends with you");
                Console.WriteLine();
            }
            else
            {
                Friends.Add(userSendingFriendRequest.Username);
            }
        }
        public void RemoveFriend(User friendToRemove)
        {
            friendToRemove.RemoveUserRequestingAsFriend(this);
            Friends.Remove(friendToRemove.Username);

            Console.WriteLine($"you are not friends with {friendToRemove.Username}");
            Console.WriteLine();
        }
        public void RemoveUserRequestingAsFriend(User friendToRemove)
        {
            Friends.Remove(friendToRemove.Username);
        }
    }
}